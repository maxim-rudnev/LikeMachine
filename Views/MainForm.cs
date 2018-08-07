using LikeMachine.Domain;
using LikeMachine.Kernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LikeMachine
{
    public partial class MainForm : Form
    {
        #region CONSTRUCTOR
        List<User> _userList = new List<User>();
        VkClient _vkClient = null;
        Settings _settings = null;
        Random _rnd = new Random();


        public MainForm()
        {
            InitializeComponent();

            // инициализация контроллов
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.MarqueeAnimationSpeed = 0;


            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic |
                    BindingFlags.Instance | BindingFlags.SetProperty, null,
                    dataGridViewUsers, new object[] { true });


            comboBoxSex.DataSource = Globals.SexDictionary;
            comboBoxSex.DisplayMember = "Key";
            comboBoxSex.ValueMember = "Value";

            comboBoxStatus.DataSource = Globals.StatusDictionary;
            comboBoxStatus.DisplayMember = "Key";
            comboBoxStatus.ValueMember = "Value";

            List<KeyValuePair<string, string>> ageFromDictionary = new List<KeyValuePair<string, string>>();
            ageFromDictionary.Add(new KeyValuePair<string, string>("Не указано", null));
            for (int i = 0; i < 100; i++) ageFromDictionary.Add(new KeyValuePair<string, string>(i.ToString(), i.ToString()));

            List<KeyValuePair<string, string>> ageToDictionary = new List<KeyValuePair<string, string>>();
            ageToDictionary.Add(new KeyValuePair<string, string>("Не указано", null));
            for (int i = 0; i < 100; i++) ageToDictionary.Add(new KeyValuePair<string, string>(i.ToString(), i.ToString()));

            comboBoxAgeFrom.DataSource = ageFromDictionary;
            comboBoxAgeFrom.DisplayMember = "Key";
            comboBoxAgeFrom.ValueMember = "Value";

            comboBoxAgeTo.DataSource = ageToDictionary;
            comboBoxAgeTo.DisplayMember = "Key";
            comboBoxAgeTo.ValueMember = "Value";






            ///////////////////////////////////////

            // инициализация VkClient
            try
            {
                _vkClient = VkClient.Create();
            }
            // если пользователь закрыл окно авторизации, то закрывается все приложение
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
                Environment.Exit(0);
            }

            ///////////////////////////////////////
            // инициализация настроек
            try
            {
                _settings = Settings.GetSettings();

                if (_settings.Message != null)
                {
                    textBoxMessage.Text = _settings.GetMessage(); 
                    textBoxGroups.Text = _settings.GetGroups(); 
                    checkBoxShowCaptcha.Checked = _settings.ShowCaptcha;
                }
            }
            // 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
                Environment.Exit(0);
            }
        }


        #endregion

        #region HANDLERS
        private async void buttonGetList_Click(object sender, EventArgs e)
        {
            // блокировка всего окна на время загрузки данных в таблицу, и включение прогресс бара
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            this.Enabled = false;

            /////////////////////////////////////////////////


            // ассинхронное получение списка пользователей
            try
            {
                _userList = await _vkClient.UsersSearch((bool)checkBoxOnline.Checked,
                                                        (string)comboBoxAgeFrom.SelectedValue,
                                                        (string)comboBoxAgeTo.SelectedValue,
                                                        (Sex?)comboBoxSex.SelectedValue,
                                                        textBoxHometown.Text,
                                                        (string)comboBoxStatus.SelectedValue,
                                                        textBoxInterests.Text);

                dataGridViewUsers.Rows.Clear();

                foreach (User user in _userList)
                {
                    int num = dataGridViewUsers.Rows.Add(new object[]
                     {
                     user.UserLink,
                     user.LastName,
                     user.FirstName,
                     user.MaidenName,
                     user.Age,
                     user.BDate,
                     user.City,
                     user.Sex,
                     user.Status,
                     user.Relation,
                     user.HomePhone,
                     user.MobilePhone,
                     user.Ineterests,
                     user.Music,
                     user.Movies,
                     user.Activities,
                     user.Books,
                     user.Games,
                     user.About
                     });

                    dataGridViewUsers.Rows[num].Tag = user;
                    dataGridViewUsers.Rows[num].ReadOnly = true;
                }


                dataGridViewUsers.Invalidate();

                labelTotalUsers.Text = string.Format("Всего: {0}", _userList.Count());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ////////////////////////////////////////


            // разблокировка окна и отключение прогресс-бара после получения данных
            this.Enabled = true;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.MarqueeAnimationSpeed = 0;
            /////////////////////////////////////////////

        }

        private async void buttonLikeFriends_Click(object sender, EventArgs e)
        {
            // блокировка окна и включение прогресс бара на время обработки 
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 30;
            this.Enabled = false;

            ////////////////////////////////////////////


            // выполнение обработки
            try
            {
                // для остановки процесса лайков можно закрыть окно ввода капчи, чтобы это отловить, в контексте try инициализируется переменная cf
                CaptchaForm cf = null;

                foreach (var user in _userList)
                {
                    try
                    {
                        await _vkClient.LikePhoto(user.Id, user.PhotoId);
                        Logger.AddLine(user.UserLink);
                        _timeOut();
                    }
                    // В случае если при лайке необхдим ввод капчи, то происходит исключение
                    catch (VkApiException ex)
                    {
                        while (true)
                        {
                            if (checkBoxShowCaptcha.Checked == false ) break;

                            cf = new CaptchaForm(ex.CaptchaImage);
                            cf.ShowDialog();

                            // Если форма ввода капчи была закрыта, то процесс останавливается, и происходит переход к обработке следующего пользователя
                            if (cf.DialogResult == DialogResult.Cancel) break;

                            string captcha_sid = ex.CaptchaSid;
                            string captcha_key = cf.CaptchaKey;

                            try
                            {
                                await _vkClient.LikePhoto(user.Id,
                                            user.PhotoId,
                                            captcha_sid,
                                            captcha_key);

                                Logger.AddLine(user.UserLink);
                                _timeOut();
                                break;
                            }
                            catch (VkApiException ex2) { ex = ex2; }
                        }

                        if (checkBoxShowCaptcha.Checked == true)
                            if (cf.DialogResult == DialogResult.Cancel) break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //////////////////////////////////////////////

            // разблокировка окна и отключение прогресс-бара после обработки
            this.Enabled = true;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.MarqueeAnimationSpeed = 0;
            /////////////////////////////////////////////

        }

        private void _timeOut()
        {
            Thread.Sleep(_rnd.Next(100, 1000));
        }

        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string url = (string)dataGridViewUsers.Rows[e.RowIndex].Cells[0].Value;

            Process.Start(url);
        }

        private void labelSupportUrl_Click(object sender, EventArgs e)
        {
			Process.Start("http://likemachine.sharpcoder.ru");
		}

        private void labelReport_Click(object sender, EventArgs e)
        {
            Process.Start(Globals.ReportFile);
        }

		#endregion



		int _groupsTotal = 0;
		int _captchaCount = 0;
		int _messageCount = 0;


        private async void buttonSend_Click(object sender, EventArgs e)
        {
            // сохранение настроек
            _settings.SetMessage(textBoxMessage.Text);
            _settings.SetGroups(textBoxGroups.Text);
            _settings.ShowCaptcha = checkBoxShowCaptcha.Checked;
            _settings.Save();

            // построение списка групп
            List<string> groupList = textBoxGroups.Text.Split('\n').ToList();

            List<string> groupIdList = new List<string>();

            foreach (string group in groupList)
            {
                string groupId = group.Replace("https://vk.com/", "");

                groupIdList.Add(groupId);
            }

            string groupListLine = string.Empty;

            foreach (string groupId in groupIdList) groupListLine += groupId + ",";

            // получение информации о группах
            List<Group> vkGroupList = new List<Group>();

            try
            {
                vkGroupList = await _vkClient.GroupsGetById(groupListLine);
            }
            catch (VkApiException ex)
            {
                CaptchaForm cf = null;

                while (true)
                {
                    cf = new CaptchaForm(ex.CaptchaImage);
                    cf.ShowDialog();

                    // Если форма ввода капчи была закрыта, то процесс останавливается, и происходит переход к обработке следующего пользователя
                    if (cf.DialogResult == DialogResult.Cancel) break;

                    string captcha_sid = ex.CaptchaSid;
                    string captcha_key = cf.CaptchaKey;

                    try
                    {
                        vkGroupList = await _vkClient.GroupsGetById(groupListLine);

                        break;
                    }
                    catch (VkApiException ex2) { ex = ex2; }
                }
            }

			// обнуление счетчиков
			_groupsTotal = vkGroupList.Count();
			_messageCount = 0;
			_captchaCount = 0;

            labelFriendingStatus.Text = "Статус: идет рассылка.";

			//////////////////
			// выполнение рассылки
			try
            {
                

                foreach (Group vkGroup in vkGroupList)
                {
                    if (vkGroup.CanPost)
                    {
                        try
                        {
                            await _vkClient.WallPost(-vkGroup.Id, _settings.GetMessage());
							_messageCount++;
							_renewCounters();

                            _wait();
                        }
                        catch (VkApiException ex)
                        {
                            if (_settings.ShowCaptcha == false) break;

                            CaptchaForm cf = null;

                            while (true)
                            {
                                cf = new CaptchaForm(ex.CaptchaImage);
                                cf.ShowDialog();

                                // Если форма ввода капчи была закрыта, то процесс останавливается, и происходит переход к обработке следующего пользователя
                                if (cf.DialogResult == DialogResult.Cancel) break;

                                string captcha_sid = ex.CaptchaSid;
                                string captcha_key = cf.CaptchaKey;

                                try
                                {
                                    await _vkClient.WallPost(-vkGroup.Id, _settings.GetMessage(), captcha_sid, captcha_key);
									_messageCount++;
									_captchaCount++;
									_renewCounters();

                                    _wait();
                                    break;
                                }
                                catch (VkApiException ex2)
                                {
                                    ex = ex2;
                                }
                            }

                            if (cf.DialogResult == DialogResult.Cancel) break;

                        }
                    }
                    else if (vkGroup.FixedPost != null)
                    {
                        int postId = vkGroup.FixedPost.Value;

                        var postList = await _vkClient.WallGetById(-vkGroup.Id, postId);

                        foreach (var post in postList)
                        {
                            if (post.CommentCanPost)
                            {
                                try
                                {
                                    await _vkClient.WallCreateComment(-vkGroup.Id, postId, _settings.GetMessage());
									_messageCount++;
									_renewCounters();

                                    _wait();
                                }
                                catch (VkApiException ex)
                                {
                                    if (checkBoxShowCaptcha.Checked == false) break;

                                    CaptchaForm cf = null;

                                    while (true)
                                    {
                                        cf = new CaptchaForm(ex.CaptchaImage);
                                        cf.ShowDialog();

                                        // Если форма ввода капчи была закрыта, то процесс останавливается, и происходит переход к обработке следующего пользователя
                                        if (cf.DialogResult == DialogResult.Cancel) break;

                                        string captcha_sid = ex.CaptchaSid;
                                        string captcha_key = cf.CaptchaKey;

                                        try
                                        {
                                            await _vkClient.WallCreateComment(-vkGroup.Id, postId, _settings.GetMessage(), captcha_sid, captcha_key);
											_messageCount++;
											_captchaCount++;
											_renewCounters();

                                            _wait();
                                            break;
                                        }
                                        catch (VkApiException ex2)
                                        {
                                            ex = ex2;
                                        }
                                    }

                                    if (cf.DialogResult == DialogResult.Cancel) break;
                                }
                            }
                        }


                    }

                }
            }
            catch (Exception ex)
            {

            }


            labelFriendingStatus.Text = "Статус: рассылка завершена.";

        }

        private void _wait()
        {
            Thread.Sleep(_rnd.Next(500, 1500));
        }

        private void _renewCounters()
		{
			labelTotalGroups.Text = string.Format("Всего групп: {0}", _groupsTotal);
			labelMessageCount.Text = string.Format("Сообщений разослано: {0}", _messageCount);
			labelCaptchaCount.Text = string.Format("Капчи введено: {0}", _captchaCount);
		}
        
    }
}

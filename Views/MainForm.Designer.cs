namespace LikeMachine
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelSupportUrl = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.labelReport = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxOnline = new System.Windows.Forms.CheckBox();
            this.textBoxInterests = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxHometown = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAgeTo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxAgeFrom = new System.Windows.Forms.ComboBox();
            this.buttonGetList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLikeFriends = new System.Windows.Forms.Button();
            this.labelTotalUsers = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new LikeMachine.Utility.SortedDataGridView();
            this.UserLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaidenName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobilePhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Music = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Books = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Games = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.About = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelCaptchaCount = new System.Windows.Forms.Label();
            this.labelMessageCount = new System.Windows.Forms.Label();
            this.labelTotalGroups = new System.Windows.Forms.Label();
            this.checkBoxShowCaptcha = new System.Windows.Forms.CheckBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxGroups = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.labelFriendingStatus = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSupportUrl
            // 
            this.labelSupportUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSupportUrl.AutoSize = true;
            this.labelSupportUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSupportUrl.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelSupportUrl.Location = new System.Drawing.Point(819, 9);
            this.labelSupportUrl.Name = "labelSupportUrl";
            this.labelSupportUrl.Size = new System.Drawing.Size(204, 16);
            this.labelSupportUrl.TabIndex = 15;
            this.labelSupportUrl.Text = "Сайт: likemachine.sharpcoder.ru";
            this.labelSupportUrl.Click += new System.EventHandler(this.labelSupportUrl_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(12, 678);
            this.progressBar1.MarqueeAnimationSpeed = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1012, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 17;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageSearch);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Location = new System.Drawing.Point(12, 28);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1012, 644);
            this.tabControlMain.TabIndex = 18;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.labelReport);
            this.tabPageSearch.Controls.Add(this.groupBox1);
            this.tabPageSearch.Controls.Add(this.label4);
            this.tabPageSearch.Controls.Add(this.buttonLikeFriends);
            this.tabPageSearch.Controls.Add(this.labelTotalUsers);
            this.tabPageSearch.Controls.Add(this.dataGridViewUsers);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 22);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(1004, 618);
            this.tabPageSearch.TabIndex = 0;
            this.tabPageSearch.Text = "Поиск";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // labelReport
            // 
            this.labelReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelReport.AutoSize = true;
            this.labelReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReport.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelReport.Location = new System.Drawing.Point(3, 595);
            this.labelReport.Name = "labelReport";
            this.labelReport.Size = new System.Drawing.Size(117, 16);
            this.labelReport.TabIndex = 24;
            this.labelReport.Text = "Открыть отчет";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.checkBoxOnline);
            this.groupBox1.Controls.Add(this.textBoxInterests);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxHometown);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxStatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxAgeTo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxSex);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxAgeFrom);
            this.groupBox1.Controls.Add(this.buttonGetList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(992, 223);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            // 
            // checkBoxOnline
            // 
            this.checkBoxOnline.AutoSize = true;
            this.checkBoxOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxOnline.Location = new System.Drawing.Point(144, 192);
            this.checkBoxOnline.Name = "checkBoxOnline";
            this.checkBoxOnline.Size = new System.Drawing.Size(64, 17);
            this.checkBoxOnline.TabIndex = 22;
            this.checkBoxOnline.Text = "Онлайн";
            this.checkBoxOnline.UseVisualStyleBackColor = true;
            // 
            // textBoxInterests
            // 
            this.textBoxInterests.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInterests.Location = new System.Drawing.Point(144, 163);
            this.textBoxInterests.Name = "textBoxInterests";
            this.textBoxInterests.Size = new System.Drawing.Size(200, 20);
            this.textBoxInterests.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(13, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Интересы";
            // 
            // textBoxHometown
            // 
            this.textBoxHometown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHometown.Location = new System.Drawing.Point(144, 29);
            this.textBoxHometown.Name = "textBoxHometown";
            this.textBoxHometown.Size = new System.Drawing.Size(200, 20);
            this.textBoxHometown.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Город (строкой)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Семейное положение";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(144, 136);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(200, 21);
            this.comboBoxStatus.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Возраст до";
            // 
            // comboBoxAgeTo
            // 
            this.comboBoxAgeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAgeTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAgeTo.FormattingEnabled = true;
            this.comboBoxAgeTo.Location = new System.Drawing.Point(144, 82);
            this.comboBoxAgeTo.Name = "comboBoxAgeTo";
            this.comboBoxAgeTo.Size = new System.Drawing.Size(87, 21);
            this.comboBoxAgeTo.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Пол";
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(144, 109);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(87, 21);
            this.comboBoxSex.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Возраст от";
            // 
            // comboBoxAgeFrom
            // 
            this.comboBoxAgeFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAgeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxAgeFrom.FormattingEnabled = true;
            this.comboBoxAgeFrom.Location = new System.Drawing.Point(144, 56);
            this.comboBoxAgeFrom.Name = "comboBoxAgeFrom";
            this.comboBoxAgeFrom.Size = new System.Drawing.Size(87, 21);
            this.comboBoxAgeFrom.TabIndex = 9;
            // 
            // buttonGetList
            // 
            this.buttonGetList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGetList.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonGetList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetList.ForeColor = System.Drawing.Color.White;
            this.buttonGetList.Location = new System.Drawing.Point(350, 29);
            this.buttonGetList.Name = "buttonGetList";
            this.buttonGetList.Size = new System.Drawing.Size(636, 181);
            this.buttonGetList.TabIndex = 0;
            this.buttonGetList.Text = "Получить список";
            this.buttonGetList.UseVisualStyleBackColor = false;
            this.buttonGetList.Click += new System.EventHandler(this.buttonGetList_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(992, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Список пользователей";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonLikeFriends
            // 
            this.buttonLikeFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLikeFriends.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonLikeFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLikeFriends.ForeColor = System.Drawing.Color.White;
            this.buttonLikeFriends.Location = new System.Drawing.Point(3, 531);
            this.buttonLikeFriends.Name = "buttonLikeFriends";
            this.buttonLikeFriends.Size = new System.Drawing.Size(992, 61);
            this.buttonLikeFriends.TabIndex = 21;
            this.buttonLikeFriends.Text = "Лайкнуть список";
            this.buttonLikeFriends.UseVisualStyleBackColor = false;
            this.buttonLikeFriends.Click += new System.EventHandler(this.buttonLikeFriends_Click);
            // 
            // labelTotalUsers
            // 
            this.labelTotalUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalUsers.AutoSize = true;
            this.labelTotalUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalUsers.Location = new System.Drawing.Point(591, 512);
            this.labelTotalUsers.Name = "labelTotalUsers";
            this.labelTotalUsers.Size = new System.Drawing.Size(55, 16);
            this.labelTotalUsers.TabIndex = 22;
            this.labelTotalUsers.Text = "Всего:";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToOrderColumns = true;
            this.dataGridViewUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserLink,
            this.LastName,
            this.FirstName,
            this.MaidenName,
            this.Age,
            this.BDate,
            this.City,
            this.Sex,
            this.Status,
            this.Relation,
            this.HomePhone,
            this.MobilePhone,
            this.Interests,
            this.Music,
            this.Movies,
            this.Activities,
            this.Books,
            this.Games,
            this.About});
            this.dataGridViewUsers.Location = new System.Drawing.Point(3, 255);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersVisible = false;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(992, 253);
            this.dataGridViewUsers.TabIndex = 20;
            // 
            // UserLink
            // 
            this.UserLink.HeaderText = "UserLink";
            this.UserLink.Name = "UserLink";
            this.UserLink.ReadOnly = true;
            this.UserLink.Width = 150;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Фамилия";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Имя";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // MaidenName
            // 
            this.MaidenName.HeaderText = "Отчество";
            this.MaidenName.Name = "MaidenName";
            this.MaidenName.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.HeaderText = "Возраст";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 70;
            // 
            // BDate
            // 
            this.BDate.HeaderText = "Дата рождения";
            this.BDate.Name = "BDate";
            this.BDate.ReadOnly = true;
            this.BDate.Width = 120;
            // 
            // City
            // 
            this.City.HeaderText = "Город";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.HeaderText = "Пол";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            this.Sex.Width = 50;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 200;
            // 
            // Relation
            // 
            this.Relation.HeaderText = "Семейное положение";
            this.Relation.Name = "Relation";
            this.Relation.ReadOnly = true;
            this.Relation.Width = 130;
            // 
            // HomePhone
            // 
            this.HomePhone.HeaderText = "Домашний телефон";
            this.HomePhone.Name = "HomePhone";
            this.HomePhone.ReadOnly = true;
            this.HomePhone.Width = 160;
            // 
            // MobilePhone
            // 
            this.MobilePhone.HeaderText = "Мобильный телефон";
            this.MobilePhone.Name = "MobilePhone";
            this.MobilePhone.ReadOnly = true;
            this.MobilePhone.Width = 160;
            // 
            // Interests
            // 
            this.Interests.HeaderText = "Интересы";
            this.Interests.Name = "Interests";
            this.Interests.Width = 250;
            // 
            // Music
            // 
            this.Music.HeaderText = "Любимая музыка";
            this.Music.Name = "Music";
            this.Music.Width = 250;
            // 
            // Movies
            // 
            this.Movies.HeaderText = "Любимые фильмы";
            this.Movies.Name = "Movies";
            this.Movies.Width = 250;
            // 
            // Activities
            // 
            this.Activities.HeaderText = "Деятельность";
            this.Activities.Name = "Activities";
            this.Activities.Width = 250;
            // 
            // Books
            // 
            this.Books.HeaderText = "Любимые книги";
            this.Books.Name = "Books";
            this.Books.Width = 250;
            // 
            // Games
            // 
            this.Games.HeaderText = "Любимые игры";
            this.Games.Name = "Games";
            this.Games.Width = 250;
            // 
            // About
            // 
            this.About.HeaderText = "О себе";
            this.About.Name = "About";
            this.About.Width = 250;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelFriendingStatus);
            this.tabPage2.Controls.Add(this.labelCaptchaCount);
            this.tabPage2.Controls.Add(this.labelMessageCount);
            this.tabPage2.Controls.Add(this.labelTotalGroups);
            this.tabPage2.Controls.Add(this.checkBoxShowCaptcha);
            this.tabPage2.Controls.Add(this.buttonSend);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBoxGroups);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBoxMessage);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1004, 618);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Френдинг";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelCaptchaCount
            // 
            this.labelCaptchaCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCaptchaCount.AutoSize = true;
            this.labelCaptchaCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCaptchaCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelCaptchaCount.Location = new System.Drawing.Point(764, 106);
            this.labelCaptchaCount.Name = "labelCaptchaCount";
            this.labelCaptchaCount.Size = new System.Drawing.Size(99, 13);
            this.labelCaptchaCount.TabIndex = 8;
            this.labelCaptchaCount.Text = "Капчи введено:";
            // 
            // labelMessageCount
            // 
            this.labelMessageCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMessageCount.AutoSize = true;
            this.labelMessageCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMessageCount.ForeColor = System.Drawing.Color.Red;
            this.labelMessageCount.Location = new System.Drawing.Point(764, 84);
            this.labelMessageCount.Name = "labelMessageCount";
            this.labelMessageCount.Size = new System.Drawing.Size(145, 13);
            this.labelMessageCount.TabIndex = 7;
            this.labelMessageCount.Text = "Сообщений разослано:";
            // 
            // labelTotalGroups
            // 
            this.labelTotalGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalGroups.AutoSize = true;
            this.labelTotalGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTotalGroups.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelTotalGroups.Location = new System.Drawing.Point(764, 62);
            this.labelTotalGroups.Name = "labelTotalGroups";
            this.labelTotalGroups.Size = new System.Drawing.Size(83, 13);
            this.labelTotalGroups.TabIndex = 6;
            this.labelTotalGroups.Text = "Всего групп:";
            // 
            // checkBoxShowCaptcha
            // 
            this.checkBoxShowCaptcha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxShowCaptcha.AutoSize = true;
            this.checkBoxShowCaptcha.Location = new System.Drawing.Point(764, 38);
            this.checkBoxShowCaptcha.Name = "checkBoxShowCaptcha";
            this.checkBoxShowCaptcha.Size = new System.Drawing.Size(120, 17);
            this.checkBoxShowCaptcha.TabIndex = 5;
            this.checkBoxShowCaptcha.Text = "Показывать капчу";
            this.checkBoxShowCaptcha.UseVisualStyleBackColor = true;
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSend.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSend.Location = new System.Drawing.Point(6, 565);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(992, 47);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Отправить сообщения";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(992, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Группы";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxGroups
            // 
            this.textBoxGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxGroups.Location = new System.Drawing.Point(6, 218);
            this.textBoxGroups.Multiline = true;
            this.textBoxGroups.Name = "textBoxGroups";
            this.textBoxGroups.Size = new System.Drawing.Size(992, 341);
            this.textBoxGroups.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(992, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сообщение";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMessage.Location = new System.Drawing.Point(6, 37);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(741, 146);
            this.textBoxMessage.TabIndex = 0;
            // 
            // labelFriendingStatus
            // 
            this.labelFriendingStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFriendingStatus.AutoSize = true;
            this.labelFriendingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFriendingStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelFriendingStatus.Location = new System.Drawing.Point(764, 170);
            this.labelFriendingStatus.Name = "labelFriendingStatus";
            this.labelFriendingStatus.Size = new System.Drawing.Size(51, 13);
            this.labelFriendingStatus.TabIndex = 9;
            this.labelFriendingStatus.Text = "Статус:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1036, 709);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelSupportUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Like Machine";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSupportUrl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageSearch;
        private System.Windows.Forms.Label labelReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxOnline;
        private System.Windows.Forms.TextBox textBoxInterests;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxHometown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAgeTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxAgeFrom;
        private System.Windows.Forms.Button buttonGetList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLikeFriends;
        private System.Windows.Forms.Label labelTotalUsers;
        private Utility.SortedDataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaidenName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Relation;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobilePhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interests;
        private System.Windows.Forms.DataGridViewTextBoxColumn Music;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activities;
        private System.Windows.Forms.DataGridViewTextBoxColumn Books;
        private System.Windows.Forms.DataGridViewTextBoxColumn Games;
        private System.Windows.Forms.DataGridViewTextBoxColumn About;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxGroups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.CheckBox checkBoxShowCaptcha;
		private System.Windows.Forms.Label labelCaptchaCount;
		private System.Windows.Forms.Label labelMessageCount;
		private System.Windows.Forms.Label labelTotalGroups;
        private System.Windows.Forms.Label labelFriendingStatus;
    }
}
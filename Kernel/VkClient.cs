using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using LikeMachine.Domain;
using System.Threading;

namespace LikeMachine.Kernel
{
    public class VkClient
    {
        #region STATIC METHODS
        public static VkClient Create()
        {
            string token = GetAuthToken();
            VkClient cl = new VkClient(token);


            return cl;
        }

        public static string GetAuthToken()
        {
            string client_id = "6396747";
            string scope = "all,photos,wall";
            string authUrl = string.Format("https://oauth.vk.com/authorize?client_id={0}&scope={1}&display=page&v=5.17&response_type=token",
                                                client_id, scope);

            AuthForm af = new AuthForm(authUrl);
            af.ShowDialog();

            if (af.DialogResult == System.Windows.Forms.DialogResult.Cancel) throw new Exception("Вы закрыли Like Machine");

            return af.AccessToken;
        }

       

        #endregion

        #region CONSTRUCTOR

        string _token = null;
        string _fields = "photo_id, verified, sex, bdate, city, country, home_town, has_photo, photo_50, photo_100, photo_200_orig, photo_200, photo_400_orig, photo_max, photo_max_orig, online, lists, domain, has_mobile, contacts, site, education, universities, schools, status, last_seen, followers_count, common_count, occupation, nickname, relatives, relation, personal, connections, exports, wall_comments, activities, interests, music, movies, tv, books, games, about, quotes, can_post, can_see_all_posts, can_see_audio, can_write_private_message, can_send_friend_request, is_favorite, is_hidden_from_feed, timezone, screen_name, maiden_name, crop_photo, is_friend, friend_status, career, military, blacklisted, blacklisted_by_me";
        string _groupFields = "city,country,place,description,wiki_page,market,members_count,counters,start_date,finish_date,can_post,can_see_all_posts,activity,status,contacts,links,fixed_post,verified,site,ban_info,cover,is_closed,deactivated,is_admin,admin_level,is_member,invited_by,type,photo_50,photo_100,photo_200,age_limits,can_create_topic,can_message,can_upload_doc,can_upload_video,crop_photo,has_photo,is_hidden_from_feed,is_messages_blocked,main_album_id,main_section";
        string _apiVersion = "5.3";
        Dictionary<string, string> _cityCache = new Dictionary<string, string>();

        HttpClient _httpClient = null;
        int _count = 1000;
        int _maxCount = 2000;

        public VkClient(string token)
        {
            _token = token;
            _httpClient = new HttpClient();

        }

        #endregion

        #region PUBLIC METHODS
        public async Task<List<Group>> GroupsGetById(string groupsIdOrName)
        {
            string reqUrl = "https://api.vk.com/method/" + "groups.getById?" +
                                                            "access_token=" + _token + "&" +
                                                            "group_ids=" + Uri.EscapeDataString(groupsIdOrName) + "&" +
                                                            "fields=" + Uri.EscapeDataString(_groupFields) + "&" +
                                                             "v=" + _apiVersion;

            ///////////////////////////////////////////////////////


            // Выполнение запроса

            HttpResponseMessage resp = await _httpClient.GetAsync(reqUrl);
            resp.EnsureSuccessStatusCode();
            string text = await resp.Content.ReadAsStringAsync();

            var JsonResponse = JsonConvert.DeserializeObject<dynamic>(text)["response"];


            List<Group> res = new List<Group>();
            
            foreach (var groupItem in JsonResponse)
            {
                var group = new Group();

                group.Id = groupItem.id;
                group.Name = groupItem.name;
                group.ScreenName = groupItem.screen_name;

                group.CanPost = (groupItem.can_post == 1) ? true : false;
                group.CanCreateTopic = (groupItem.can_create_topic == 1) ? true : false;

                try
                {
                    string postId = groupItem.fixed_post;

                    group.FixedPost = int.Parse(postId);
                }
                catch { }

                res.Add(group);
            }

            return res;
        }

        public async Task<List<Post>> WallGetById(int ownerId, int postId)
        {
            List<Post> res = new List<Post>();

            // Построение запроса

            string reqUrl = "https://api.vk.com/method/" + "wall.getById?" +
                                                            "access_token=" + _token + "&" +
                                                            "posts=" + string.Format("{0}_{1}",ownerId,postId) + "&" +
                                                            "extended=1&"+
                                                            "fields=" + Uri.EscapeDataString("owner_id") + "&"+
                                                            "v=" + _apiVersion;

            ///////////////////////////////////////////////////////


            // Выполнение запроса

            HttpResponseMessage resp = await _httpClient.GetAsync(reqUrl);
            resp.EnsureSuccessStatusCode();
            string text = await resp.Content.ReadAsStringAsync();

            var JsonResponse = JsonConvert.DeserializeObject<dynamic>(text)["response"]["items"];


            

            foreach (var postItem in JsonResponse)
            {
                var post = new Post();

                post.Id = postItem.id;                
                post.FromId = postItem.from_id;

                try
                {
                    post.OwnerId = postItem.owner_id;
                }
                catch
                {
                    post.OwnerId = postItem.to_id;
                }

                post.PostType = postItem.post_type;
                post.CommentCanPost = postItem.comments.can_post;

                res.Add(post);
            }

            return res;
        }


        public async Task WallPost(int ownerId, string message, string captcha_sid = null, string captcha_key = null)
        {
            // Построение запроса wall.post

            string reqUrl = "https://api.vk.com/method/" + "wall.post?" +
                                                            "access_token=" + _token + "&" +
                                                            "owner_id="+ ownerId  + "&" +
                                                            "message=" + Uri.EscapeDataString(message) + "&"+
                                                                ((captcha_sid != null) ? "captcha_sid=" + captcha_sid + "&" : "") +
                                                                ((captcha_key != null) ? "captcha_key=" + captcha_key + "&" : "") +
                                                             "v=" + _apiVersion;

            ///////////////////////////////////////////////////////


            // Выполнение запроса

            HttpResponseMessage resp = await _httpClient.GetAsync(reqUrl);
            resp.EnsureSuccessStatusCode();
            string text = await resp.Content.ReadAsStringAsync();

            var JsonResponse = JsonConvert.DeserializeObject<dynamic>(text)["response"];

            if (JsonResponse == null)
            {
                JsonResponse = JsonConvert.DeserializeObject<dynamic>(text)["error"];

                if (JsonResponse.error_code == "14")
                {
                    VkApiException ex = new VkApiException((string)JsonResponse.error_code,
                                                (string)JsonResponse.error_msg,
                                                (string)JsonResponse.captcha_sid,
                                                (string)JsonResponse.captcha_img);

                    throw ex;
                }
                else
                {

                }
            }
        }

        public async Task WallCreateComment(int ownerId, int postId, string message, string captcha_sid = null, string captcha_key = null)
        {
            // Построение запроса 

            string reqUrl = "https://api.vk.com/method/" + "wall.createComment?" +
                                                            "access_token=" + _token + "&" +
                                                            "owner_id=" + ownerId + "&" +
                                                            "post_id=" + postId + "&" +
                                                            "message=" + Uri.EscapeDataString(message) + "&" +
                                                            "guid=" + Uri.EscapeDataString(Guid.NewGuid().ToString()) + "&" +
                                                                ((captcha_sid != null) ? "captcha_sid=" + captcha_sid + "&" : "") +
                                                                ((captcha_key != null) ? "captcha_key=" + captcha_key + "&" : "") +
                                                             "v=" + _apiVersion;

            ///////////////////////////////////////////////////////


            // Выполнение запроса

            HttpResponseMessage resp = await _httpClient.GetAsync(reqUrl);
            resp.EnsureSuccessStatusCode();
            string text = await resp.Content.ReadAsStringAsync();

            var JsonResponse = JsonConvert.DeserializeObject<dynamic>(text)["response"];

            if (JsonResponse == null)
            {
                JsonResponse = JsonConvert.DeserializeObject<dynamic>(text)["error"];

                if (JsonResponse.error_code == "14")
                {
                    throw new VkApiException((string)JsonResponse.error_code,
                                                (string)JsonResponse.error_msg,
                                                (string)JsonResponse.captcha_sid,
                                                (string)JsonResponse.captcha_img);
                }
                else
                {

                }
            }
        }

        public async Task<List<User>> UsersSearch(bool online, string agefrom, string ageto, Sex? sex, string homeTown, string status, string interests )
        {
            // Построение запроса users.search

            string reqUrl = "https://api.vk.com/method/" + "users.search?" +
                                                            "access_token=" + _token + "&" +
                                                            "fields=" + Uri.EscapeDataString(_fields) + "&" +
                                                                ((online) ? ("online=1" + "&") : "") +
                                                                ((agefrom   != string.Empty     && agefrom != null) ? ("age_from="  + agefrom + "&") : "") +
                                                                ((ageto     != string.Empty     && ageto != null)   ? ("age_to="    + ageto + "&") : "") +
                                                                ((sex.HasValue)     ? ("sex="       + (int)sex + "&") : "") +
                                                                ((homeTown  !=  string.Empty  && homeTown   != null)        ? ("hometown="  + Uri.EscapeDataString(homeTown) + "&") : "") +
                                                                ((status    !=  string.Empty  && status     != null)        ? ("status="    + Uri.EscapeDataString(status) + "&") : "") +
                                                                ((interests !=  string.Empty  && interests  != string.Empty)? ("interests=" + Uri.EscapeDataString(interests) + "&") : "") +
                                                            "has_photo=1&" +
                                                            "count=" + _count + "&" +
                                                            //"offset="+offset+"&" +
                                                            "v="+_apiVersion;

            ///////////////////////////////////////////////////////


            // Выполнение запроса

            HttpResponseMessage resp = await _httpClient.GetAsync(reqUrl);
            resp.EnsureSuccessStatusCode();
            string text = await resp.Content.ReadAsStringAsync();

            int itemsCount = JsonConvert.DeserializeObject<dynamic>(text)["response"].count;
            var JsonResponse = JsonConvert.DeserializeObject<dynamic>(text)["response"]["items"];

            //////////////////////////////////////////////////////////

            // Обработка данных, полученных запросом

            List<User> lst = new List<User>();            

            foreach (var userItem in JsonResponse)
            {

                var user = new User();

                user.Id = userItem.id;
                user.UserLink = string.Format("http://vk.com/id{0}", user.Id);

                user.FirstName = userItem.first_name;
                user.LastName = userItem.last_name;
                user.MaidenName = userItem.maiden_name;
                user.BDate = userItem.bdate;
                user.Age = _tryParseAge((string)user.BDate);

                user.City = await _parseCity( (string)userItem.city);
                user.Relation = _parseRelation( (string)userItem.relation);

                user.Status = userItem.status;
                user.HomePhone = userItem.home_phone;
                user.MobilePhone = userItem.mobile_phone;
                user.Sex = _parseSex( (string)userItem.sex );

                user.PhotoId = userItem.photo_id;
                // Если у пользователя отсутствует photo_id - пропускаем этого пользователя
                if (user.PhotoId == null) break;
                else user.PhotoId = user.PhotoId.Split('_')[1]; // выделение ItemId из возвращенного Id. Первая часть возвращенного id - это id пользователя


                user.Ineterests = userItem.interests;
                user.Music = userItem.music;
                user.Movies = userItem.movies;
                user.Activities = userItem.activities;
                user.Books = userItem.books;
                user.Games = userItem.games;
                user.About = userItem.about;


                //try
                //{
                //    user.IsLiked = await _isLiked(user.Id, user.PhotoId);
                //}
                //catch { }

                lst.Add(user);
            }



            return lst;
        }

        public async Task LikePhoto(string owner_id, string item_id, string captcha_sid =null, string captcha_key = null)
        {
            // Построение запроса likes.add
            string reqUrl = "https://api.vk.com/method/" + "likes.add?" +
                                                            "access_token=" + _token + "&" +
                                                            "type=photo&" +
                                                            "owner_id=" + owner_id + "&" +
                                                            "item_id=" + item_id + "&" +
                                                                ((captcha_sid!=null)? "captcha_sid="+ captcha_sid +"&": "") + 
                                                                ((captcha_key != null) ? "captcha_key=" + captcha_key +"&": "") +
                                                            "v=" +_apiVersion;

            // Выполнение запроса

            HttpResponseMessage resp = await _httpClient.GetAsync(reqUrl);
            resp.EnsureSuccessStatusCode();
            string text = await resp.Content.ReadAsStringAsync();

            var JsonResponse = JsonConvert.DeserializeObject<dynamic>(text)["response"];

            if (JsonResponse == null)
            {
                JsonResponse = JsonConvert.DeserializeObject<dynamic>(text)["error"];

                if (JsonResponse.error_code == "14")
                {
                    throw new VkApiException( (string)JsonResponse.error_code, 
                                                (string)JsonResponse.error_msg, 
                                                (string)JsonResponse.captcha_sid,
                                                (string)JsonResponse.captcha_img);
                }
                else
                {

                }
            }
           
        }

        public async Task<City> GetCityById(string city_id)
        {
            City city = null;

            string reqUrl = "https://api.vk.com/method/" + "database.getCitiesById?" +
                                                            "access_token=" + _token + "&" +
                                                            "city_ids=" + city_id + "&" +
                                                            "v=" + _apiVersion;

            // Выполнение запроса

            HttpResponseMessage resp = await _httpClient.GetAsync(reqUrl);
            resp.EnsureSuccessStatusCode();
            string text = await resp.Content.ReadAsStringAsync();

            var JsonResponse = JsonConvert.DeserializeObject<dynamic>(text)["response"];

            if (JsonResponse.Count > 0)
            {
                city = new City()
                {
                    Id = JsonResponse[0].id,
                    Title = JsonResponse[0].title
                };
            }

            return city;
        }

        #endregion

        #region PRIVATE METHODS

        private async Task<string> _parseCity(string city_id)
        {
            string res = null;

            // поиск названия города в кэше
            try
            {
                res = _cityCache[city_id];
            }
            // ключ отсутствует в словаре
            catch (Exception ex)
            {
                // запрос информации от вконтакте
                try
                {
                    City city = await GetCityById(city_id);

                    // проверка того, был ли найден город
                    if (city != null)
                        _cityCache.Add(city.Id, city.Title);
                    else
                        throw new Exception();

                    // поиск в кэше после добавления
                    res = _cityCache[city_id];
                }
                catch
                {

                }
            }


            return res;
        }

        private string _tryParseAge(string bDateStr)
        {
            string ageStr = null;


            try
            {
                // проверка того, указана ли у пользователя полная дата рождения, если нет, то выдавать исключение
                if (bDateStr.Split('.').Count() != 3) throw new Exception();

                // обработка даты
                int age;

                DateTime now = DateTime.Now;
                DateTime bDate = DateTime.Parse(bDateStr);
                age = now.Year - bDate.Year;

                if (bDate > now.AddYears(-age)) age--;

                ageStr = age.ToString();

            }
            catch (Exception ex)
            {

            }


            return ageStr;
        }


        private string _parseSex(string sex)
        {
            string res = null;

            switch (sex)
            {
                case "1":
                    res = "Жен.";
                    break;
                case "2":
                    res = "Муж.";
                    break;
            }

            return res;
        }

        private string _parseRelation(string relation)
        {
            string res = null;

            //1 — не женат/ не замужем;
            //2 — есть друг/ есть подруга;
            //3 — помолвлен / помолвлена;
            //4 — женат / замужем;
            //5 — всё сложно;
            //6 — в активном поиске;
            //7 — влюблён / влюблена;
            //8 — в гражданском браке;
            //0 — не указано

            switch (relation)
            {
                case "1":
                    res = "не женат / не замужем";
                    break;
                case "2":
                    res = "есть друг/ есть подруга";
                    break;
                case "3":
                    res = "помолвлен / помолвлена";
                    break;
                case "4":
                    res = "женат / замужем";
                    break;
                case "5":
                    res = "всё сложно";
                    break;
                case "6":
                    res = "в активном поиске";
                    break;
                case "7":
                    res = "влюблён / влюблена";
                    break;
                case "8":
                    res = "в гражданском браке";
                    break;
                case "0":
                    res = "не указано";
                    break;
            }


            return res;
        }
        
        private async Task<bool> _isLiked(string ownder_id, string item_id)
        {
            bool res = false;

            string reqUrl = "https://api.vk.com/method/" + "likes.isLiked?" +
                                                            "access_token=" + _token + "&" +
                                                            "user_id=298463317&"+
                                                            "type=photo&" +
                                                            "owner_id=" + ownder_id + "&" +
                                                            "item_id=" + item_id.Split('_')[1] + "&" +
                                                            "v=5.0";

            HttpResponseMessage resp = await _httpClient.GetAsync(reqUrl);
            resp.EnsureSuccessStatusCode();
            string text = await resp.Content.ReadAsStringAsync();

            var JsonResponse = JsonConvert.DeserializeObject<dynamic>(text)["response"];

            Thread.Sleep(1000);

            res = (JsonResponse.liked == "1") ? true : false;

            return res;
        }

        #endregion
    }




}

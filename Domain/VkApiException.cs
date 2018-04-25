using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeMachine.Domain
{
    public class VkApiException : Exception
    {
        public VkApiException(string code, string msg) : base(msg) { }

        public VkApiException(string code, string msg, string captcha_sid, string captcha_image) : base(msg)
        {
            CaptchaSid = captcha_sid;
            CaptchaImage = captcha_image;
        }

        public string CaptchaSid { get; set; }

        public string CaptchaImage { get; set; }
    }
}

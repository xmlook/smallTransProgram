using System;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Security.Cryptography;

namespace TranslationAPI
{
    static class TranslationOp
    {
        /// <summary>
        /// 将中文翻译为英文
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string translation(string source,string before,string after)
        {
            TranslationResult result = GetTranslationFromBaiduFanyi(source, before,after);
            //判断是否出错
            if(result.Error_code == null)
            {
                return result.Trans_result[0].dst;
            }
            else
            {
                //检查appid和密钥是否正确
                return "翻译出错，错误码：" + result.Error_code + "，错误信息：" + result.Error_msg;
            }
        }
        public static string toEnglish(string s)
        {
            string str="en";
            if (s == "自动检测")
                str = "auto";
            else if (s == "英语")
                str = "en";
            else if (s == "中文")
                str = "zh";
            else if (s == "德语")
                str = "de";
            else if (s == "日语")
                str = "jp";
            return str;
        }
        public static string toChinese(string s)
        {
            string str = "";
            if (s == "auto")
                str = "自动检测";
            else if (s == "en")
                str = "英语";
            else if (s == "zh")
                str = "中文";
            else if (s == "de")
                str = "德语";
            else if (s == "jp")
                str = "日语";
            return str;
        }
        public static int judgement(string s)
        {
            int jud = 0;
            if (s !=String.Empty)
            {
                char[] c = s.ToCharArray();

                if (c[0] >= 0x4e00 && c[0] <= 0x9fbb)//判断是否为汉字
                    jud = 1;
                else jud = 2;
            }
            return jud;
        }

        /// <summary>
        /// 调用百度翻译API进行翻译
        /// 详情可参考http://api.fanyi.baidu.com/api/trans/product/apidoc
        /// </summary>
        /// <param name="q">待翻译字符</param>
        /// <param name="from">源语言</param>
        /// <param name="to">目标语言</param>
        /// <returns></returns>
        private static TranslationResult GetTranslationFromBaiduFanyi(string q, string str1, string str2)
        {
            //百度翻译开放平台API账号密码
            string appId = "20170715000064741";
            string password = "bGvI5PXZqGwui0sqREn_";

            string jsonResult = String.Empty;

            string languageFrom = str1;
            string languageTo = str2;
            //随机数
            string randomNum = System.DateTime.Now.Millisecond.ToString();
            //md5加密
            string md5Sign = GetMD5WithString(appId + q + randomNum + password);
            //url
            string url = String.Format("http://api.fanyi.baidu.com/api/trans/vip/translate?q={0}&from={1}&to={2}&appid={3}&salt={4}&sign={5}",
                HttpUtility.UrlEncode(q, Encoding.UTF8),
                languageFrom,
                languageTo,
                appId,
                randomNum,
                md5Sign
                );
            WebClient wc = new WebClient();
            try
            {
                jsonResult = wc.DownloadString(url);
            }
            catch
            {
                jsonResult = string.Empty;
            }
            //解析json
            JavaScriptSerializer jss = new JavaScriptSerializer();
            TranslationResult result = jss.Deserialize<TranslationResult>(jsonResult);
            return result;
        }

        //对字符串做md5加密
        private static string GetMD5WithString(string input)
        {
            if (input == null)
            {
                return null;
            }
            MD5 md5Hash = MD5.Create();
            //将输入字符串转换为字节数组并计算哈希数据  
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            //创建一个 Stringbuilder 来收集字节并创建字符串  
            StringBuilder sBuilder = new StringBuilder();
            //循环遍历哈希数据的每一个字节并格式化为十六进制字符串  
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            //返回十六进制字符串  
            return sBuilder.ToString();
        }

    }

    public class Translation
    {
        public string src{ get; set; }
        public string dst { get; set; }
    }

    public class TranslationResult
    {
        //错误码，翻译结果无法正常返回
        public string Error_msg { get; set; }
        public string Error_code { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string Query { get; set; }
        //翻译正确，返回的结果
        //这里是数组的原因是百度翻译支持多个单词或多段文本的翻译，在发送的字段q中用换行符（\n）分隔
        public Translation[] Trans_result { get; set; }
    }

}

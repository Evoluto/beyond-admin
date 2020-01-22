using System;
using System.Web.Mvc;
using System.Net;
using System.Net.Http;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Web;
using Newtonsoft.Json;

namespace BeyondThemes.BeyondAdmin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Blank()
        {
            return View();
        }
        public ActionResult Elements()
        {
            return View();
        }
        public ActionResult Tabs()
        {
            return View();
        }
        public ActionResult Modals()
        {
            return View();
        }
        public ActionResult Buttons()
        {
            return View();
        }
        public ActionResult FormLayouts()
        {
            return View();
        }
        public ActionResult FormInputs()
        {
            return View();
        }
        public ActionResult Widgets()
        {
            return View();
        }
        public ActionResult Databoxes()
        {
            return View();
        }
        public ActionResult Alerts()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FontAwesome()
        {
            return View();
        }
        public ActionResult GlyphIcons()
        {
            return View();
        }
        public ActionResult Typicons()
        {
            return View();
        }
        public ActionResult WeatherIcons()
        {
            return View();
        }
        public ActionResult NestableList()
        {
            return View();
        }
        public ActionResult TreeView()
        {
            return View();
        }
        public ActionResult SimpleTables()
        {
            return View();
        }

        private static string HttpPostRequest(string url, Dictionary<string, string> postParameters)
        {
            string postData = "";

            foreach (string key in postParameters.Keys)
            {
                postData += "&" + HttpUtility.UrlEncode(key) + "="
                        + HttpUtility.UrlEncode(postParameters[key]) ;
            }

            HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            myHttpWebRequest.Method = "POST";

            byte[] data = Encoding.ASCII.GetBytes(postData);

            myHttpWebRequest.ContentType = "application/x-www-form-urlencoded";
            myHttpWebRequest.ContentLength = data.Length;

            Stream requestStream = myHttpWebRequest.GetRequestStream();
            requestStream.Write(data, 0, data.Length);
            requestStream.Close();

            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();

            Stream responseStream = myHttpWebResponse.GetResponseStream();

            StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);

            string response = myStreamReader.ReadToEnd();

            myStreamReader.Close();
            responseStream.Close();
            myHttpWebResponse.Close();

            return response;
        }

        public static string PostRequest(string url, string body, string token)
        {
            HttpWebRequest request = System.Net.WebRequest.Create(url) as System.Net.HttpWebRequest;
            request.KeepAlive = true;
            request.Method = "POST";
            request.ContentLength = 0;
            request.ContentType = "application/json";

            //Add token to the request header
            request.Headers.Add("Authorization", String.Format("Bearer {0}", token));

            //POST web request
            byte[] byteArray = new byte[0];
            if (!string.IsNullOrEmpty(body))
            {
                byteArray = System.Text.Encoding.UTF8.GetBytes(body);
                request.ContentLength = byteArray.Length;
            }

            //Write JSON byte[] into a Stream
            using (Stream writer = request.GetRequestStream())
            {
                writer.Write(byteArray, 0, byteArray.Length);

                var httpWebResponse = (HttpWebResponse)request.GetResponse();

                Stream responseStream = httpWebResponse.GetResponseStream();

                StreamReader myStreamReader = new StreamReader(responseStream, Encoding.Default);

                var responseString = myStreamReader.ReadToEnd();

                myStreamReader.Close();
                responseStream.Close();
                httpWebResponse.Close();

                return responseString;
            }
        }

        public ActionResult Projects()
        {
            var parameters =
                new Dictionary<string, string>()
                {
                    { "grant_type", "password" },
                    { "username", "super_admin@mail.com" },
                    { "password", "Miami123." }
                };
            var responseToken = HttpPostRequest("https://ignatius.io/token", parameters);
            Models.TokenViewModel token = new Models.TokenViewModel();
            token = JsonConvert.DeserializeObject<Models.TokenViewModel>(responseToken);

            string url = "https://ignatius.io/api/report/queryreport";
            string body = @"{ReportId: 703}";
            //string token = responseToken; // "RyoxKCY40WY9MtJftSs5ZElAacsvYV56lduL8n3jGKQ4iv-xPEXIaE0RXI5CkzxRptp-ScLoM3_ShhCSxdXHYlSjXWuDqu8gRyqUDR0s-KuzHvIW2cTyYcX_uSlhXO0VUsUPCmjGQ8zllkVXMM1Vk__l1foHEuGwm2nLRboAKkhrryyry0AcYAIo-JjWDBgzM0Cl5rys2qZB9m9IUMxKS-SOpruVmR7ZqvkMSCGpKcG-1aZbuz6ZhwpPtuAi2BvxdzX4f_CdSDwT6L5cgXDzi7DUPzulfNEuQ1prO4I0XC8aMprthjusc5k1sd_aDiV9";
            var response = PostRequest(url, body, token.Access_token);
            //var response1 = JsonConvert.DeserializeObject(response).ToString();
            //var jsonResponse = JsonConvert.SerializeObject(response1);
            List<Models.ProjectViewModel> listprojects = JsonConvert.DeserializeObject<List<Models.ProjectViewModel>>(response);

            return View(listprojects);
        }

        public ActionResult DataTables()
        {
            return View();
        }
        public ActionResult DataPickers()
        {
            return View();
        }

        public ActionResult Wizards()
        {
            return View();
        }

        public ActionResult FormValidation()
        {
            return View();
        }

        public ActionResult FormInputMask()
        {
            return View();
        }
        public ActionResult FormEditors()
        {
            return View();
        }
        public ActionResult Profile()
        {
            return View();
        }
        public ActionResult Calendar()
        {
            return View();
        }
        public ActionResult FlotCharts()
        {
            return View();
        }
        public ActionResult MorrisCharts()
        {
            return View();
        }
        public ActionResult SparklineCharts()
        {
            return View();
        }
        public ActionResult EasyPieCharts()
        {
            return View();
        }
        public ActionResult ChartJS()
        {
            return View();
        }
        public ActionResult Inbox()
        {
            return View();
        }
        public ActionResult Compose()
        {
            return View();
        }
        public ActionResult ViewMessage()
        {
            return View();
        }
        public ActionResult Timeline()
        {
            return View();
        }
        public ActionResult PricingTables()
        {
            return View();
        }
        public ActionResult Invoice()
        {
            return View();
        }
        public ActionResult Typography()
        {
            return View();
        }
        public ActionResult Error404()
        {
            return View();
        }
        public ActionResult Error500()
        {
            return View();
        }
        public ActionResult Grid()
        {
            return View();
        }
        public ActionResult Persian()
        {
            return View();
        }
        public ActionResult Arabic()
        {
            return View();
        }
    }
}

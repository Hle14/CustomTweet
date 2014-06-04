using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.WebClient;

using System.Web;

namespace CustomTweet
{
    public static class Utilities
    {

        public static string Generate_Credentials(string consumer_key,string consumer_secret)
        {
            //encode the consumer key and secret
            //concatenate them to form bearer token credentials
            string bearer_token_credentials = HttpContext.Current.Server.UrlEncode(consumer_key) + ":" + HttpContext.Current.Server.UrlEncode(consumer_secret);

            //encode credentials
            return Convert.ToBase64String(Encoding.Unicode.GetBytes(bearer_token_credentials));
        }

        public static string Request_BearerToken(string encoded_credentials)
        {
            string response = "";

            //specificy request type

            //create authorization header

            //create content-type header

            //create body of request

            //perform http request, store response
            
            //https://dev.twitter.com/docs/auth/application-only-auth
            //http://d-fens.ch/2014/04/12/httpclient-and-how-to-use-headers-content-type-and-postasync/
            using (var client = new HttpClient())
            {
                string content_type = "application/x-www-form-urlencoded;charset=UTF-8";
                string user_agent = "GenghisDesktopApp";
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(content_type));
                client.DefaultRequestHeaders.Add("Authorization", String.Format("Basic {0}", encoded_credentials));
                client.DefaultRequestHeaders.Add("User-Agent"user_agent);


                //var values = new List<KeyValuePair<string, string>>();
                //values.Add(new KeyValuePair<string, string>("Authorization", "Basic " + encoded_credentials));
                //values.Add(new KeyValuePair<string,string>("Content-Type","application/x-www-form-urlencoded;charset=UTF-8");

                ////set authorization header
                //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", encoded_credentials);

                

            }

            return response;
        }
    }
}

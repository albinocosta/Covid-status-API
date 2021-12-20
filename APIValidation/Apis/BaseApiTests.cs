using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using APIValidation.Apis.Models;
using NUnit.Framework;
using RestSharp;
using RestSharp.Serialization.Json;
using static APIValidation.Utils.Settings.Settings;

namespace APIValidation.Apis
{
    public class BaseApiTests
    {
        public static RestClient Client;
        public static IRestRequest Request;
        public static IRestResponse Response;
        public static void SetBaseUri()
        {
            Client = new RestClient(baseUrl);
        }

        public static void GetCriticalCases()
        {
            Request = new RestRequest("countries/Portugal?yesterday", Method.GET);
            Response = Client.Execute(Request);
            Console.WriteLine((int)Response.StatusCode);
        }

        public static void WantToCheck()
        {

        }

        private static T DeserialiseResponse<T>()
        {
            JsonDeserializer jsonDeserializer = new JsonDeserializer();
            return jsonDeserializer.Deserialize<T>(Response);
        }

        public static void AssertCriticalLess100(int criticalcases)
        {
            var result = DeserialiseResponse<List<HomeTimeline>>();
            Assert.True(result[0].Critical < criticalcases);
        }

        public static void AssertStatusCode(int statuscode)
        {
            Assert.That((int)Response.StatusCode, Is.EqualTo(statuscode));
        }
    }
}

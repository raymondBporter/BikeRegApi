using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Collections.Generic;

namespace BikeReg
{
    static public class BikeRegApi
    {

        public static BikeRegLoginResult GetLogin(string username, string password) =>
            Post<BikeRegLoginResult>(BikeRegResource.PromoterLogin, new { username, password });
        public static List<BikeRegEvent> GetEvents(string token) =>
            Post<List<BikeRegEvent>>(BikeRegResource.PromoterEvents, new { token });
        public static List<BikeRegEventCategory> GetEventCategories(string token, string eventID) =>
            Post<List<BikeRegEventCategory>>(BikeRegResource.EventCategories, new { token, eventID });
        public static List<BikeRegEventEntry> GetEventEntries(string token, string eventID) =>
            Post<List<BikeRegEventEntry>>(BikeRegResource.EventEntries, new { token, eventID });




        const string BaseURL = "https://www.BikeReg.com/api/director/";
        enum BikeRegResource { PromoterLogin, PromoterEvents, EventCategories, EventEntries };
        static string Header(this BikeRegResource resource) =>
            resource == BikeRegResource.PromoterLogin ? "PromoterLoginResult" : "Get" + resource.ToString() + "Result";
        static T Post<T>(BikeRegResource resource, object body)
        {
            var request = new RestRequest(resource.ToString(), Method.POST).AddJsonBody(body);
            var content = new RestClient(BaseURL).Execute(request).Content;
            var serializedValue = JsonConvert.DeserializeObject<JObject>(content).Property(resource.Header()).Value.ToString();
            return JsonConvert.DeserializeObject<T>(serializedValue);
        }
    }
}

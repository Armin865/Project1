/*Author: Lam Nguyen
 * Date:10/01/2020
 * Description: DTO Controller for data from api
 */
using DTO_WindowForm_API.PersonDTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;


namespace DTO_WindowForm_API.JsonParseObject
{//https://www.c-sharpcorner.com/UploadFile/raj1979/consume-Asp-Net-web-api-using-httpclient-in-wpf/
    public class JsonObject
    {
        public List<Person> Get()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://beautysignindev.azurewebsites.net/signin");
            //client.DefaultRequestHeaders.Add("appkey", "myapp_key");
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

             HttpResponseMessage response = client.GetAsync("").Result;
           
                var employees = response.Content.ReadAsAsync<List<Person>>().Result;
                return employees;
            
           
        }
        public HttpResponseMessage Post(string FirstName, string LastName,string Phone)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://beautysignindev.azurewebsites.net/signin");
            //client.DefaultRequestHeaders.Add("appkey", "myapp_key");
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));

            var person = new Person();
            person.firstName = FirstName;
            person.lastName = LastName;
            person.phone = Phone;

            var response = client.PostAsJsonAsync("", person).Result;
            return response;




        }
    }
}

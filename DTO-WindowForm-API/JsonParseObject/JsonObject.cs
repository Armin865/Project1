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
        HttpClient client;
          public JsonObject()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://beautysignindev.azurewebsites.net/signin");

            client.DefaultRequestHeaders.Accept.Add(
                   new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public List<Person> Get()//Get data from the API
        {   //using Http Client to make the get request 
           
            //client.DefaultRequestHeaders.Add("appkey", "myapp_key");
            //Tell Server that we want the JSON format
            client.DefaultRequestHeaders.Accept.Add(
               new MediaTypeWithQualityHeaderValue("application/json"));
            //Get the response after send the request
             HttpResponseMessage response = client.GetAsync("").Result;
           //Save the Response content in the persons variable
                var persons = response.Content.ReadAsAsync<List<Person>>().Result;
                return persons;
            
           
        }
        //Make Post request 
        public HttpResponseMessage Post(string FirstName, string LastName,string Phone)
        {   
            var person = new Person();
            person.firstName = FirstName;
            person.lastName = LastName;
            person.phone = Phone;
            //Save the response after execute the post request
            var response = client.PostAsJsonAsync("", person).Result;
            return response;




        }
    }
}

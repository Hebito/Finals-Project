using System;
using IceAndFireAPI.Objects;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace IceAndFireAPI
{
    public class JsonHelper
    {
        //Retrieve ID and retrieves Http Response into Json, then places into Character Object
        public static async Task<Character> GetCharacter(string CharacterID)
        {
            using (HttpClient client = new HttpClient())
            {
                Character myDeserializedClass = new Character();
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                try
                {
                    HttpResponseMessage response = await client.GetAsync($"https://anapioficeandfire.com/api/characters/{CharacterID}");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);

                    myDeserializedClass = JsonConvert.DeserializeObject<Character>(responseBody);

                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }

                return myDeserializedClass;
            }
        }

        //Retrieve House ID from a Character's allegiance list, and places into House object.
        public static async Task<House> GetHouse(string HouseID)
        {
            using (HttpClient client = new HttpClient())
            {
                House myDeserializedClass = new House();
                // Call asynchronous network methods in a try/catch block to handle exceptions.
                try
                {
                    HttpResponseMessage response = await client.GetAsync(HouseID);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // Above three lines can be replaced with new helper method below
                    // string responseBody = await client.GetStringAsync(uri);

                    myDeserializedClass = JsonConvert.DeserializeObject<House>(responseBody);

                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", e.Message);
                }

                return myDeserializedClass;
            }
        }
    }
}

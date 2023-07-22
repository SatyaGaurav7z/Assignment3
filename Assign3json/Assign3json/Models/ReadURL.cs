using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Text;

namespace Assign3json.Models
{
    internal class ReadURL
    {
        // Data: https://jsonplaceholder.typicode.com/users
        string jsonDataFromUrl;

        public void Read()
        {
            Console.WriteLine("- URL Data");

            string URL = "https://jsonplaceholder.typicode.com/users";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (Stream responseStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                jsonDataFromUrl = reader.ReadToEnd();

                if (jsonDataFromUrl != null)
                {
                    // Now log your data in the console
                    // Console.WriteLine("data- ---(" + jsonDataFromUrl + ")");
                }
                else
                {
                    Console.WriteLine("No Data- -");
                }
            }
        }

        public void print_name()
        {
            Console.WriteLine("\n\n============ Name =========\n\n");

            
            var jsonObject = JArray.Parse(jsonDataFromUrl);

            
            foreach (var jsonObjectItem in jsonObject)
            {
                Console.WriteLine(jsonObjectItem["name"]);
            }
        }

        public void print_email()
        {
            Console.WriteLine("\n\n============ Email =========\n\n");

             
            var jsonObject = JArray.Parse(jsonDataFromUrl);

            
            foreach (var jsonObjectItem in jsonObject)
            {
                Console.WriteLine(jsonObjectItem["email"]);
            }
        }

        public void print_city()
        {
            Console.WriteLine("\n\n============ City =========\n\n");

            
            var jsonObject = JArray.Parse(jsonDataFromUrl);

           
            foreach (var jsonObjectItem in jsonObject)
            {
                Console.WriteLine(jsonObjectItem["address"]["city"]);
            }
        }

        public void createfile()
        {
            
            var jsonObject = JArray.Parse(jsonDataFromUrl);

          
            string filedata = "";
            foreach (var jsonObjectItem in jsonObject)
            {
                filedata = filedata + jsonObjectItem["email"].ToString();
            }

            string writefilename = "json_name.txt";
            string userDownloadsPath = @"C:\Users\satya\Downloads";
            string writefilePath = Path.Combine(userDownloadsPath, writefilename);

            File.WriteAllText(writefilePath, filedata);
            Console.WriteLine("File created at: " + writefilePath);
        }
    }
}

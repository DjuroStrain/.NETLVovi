using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Net;

namespace Countries
{
    public class CountryRepository
    {
        public static string CallRestMethod(string url)
        {
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentType = "application/x-www-form-urlencoded";
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(),
           enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();
            return result;
        }

        public List<Country> GetCountries()
        {
            CallRestMethod("https://restcountries.com/v3.1/all");

            List<Country> coutry = new List<Country>();
            string url = "https://restcountries.com/v3.1/all";
            string json = CallRestMethod(url);

            JArray json2 = JArray.Parse(json);

            foreach (JObject item in json2)
            {
                coutry.Add(new Country
                {
                    Code = (string)item.GetValue("alpha3Code").ToString(),
                    Name = (string)item.GetValue("name").ToString(),
                    Capital = (string)item.GetValue("capital").ToString(),
                    Population = (int)item.GetValue("population"),
                    Area = (string)item.GetValue("area").ToString(),
                    Region = (string)item.GetValue("region").ToString()
                }) ;
            }

            return coutry;

        }

        public List<string> GetRegions()
        {
            var countries = GetCountries();
            List<string> regions = new List<string>();
            regions = countries.Select(x => x.Region).Distinct().ToList();
            regions.Insert(0, "All");
            return regions;
        }

        public List<Country> Filter(List<Country> countries, string region, string name, string capital, int population_min, int population_max)
        {
            var countries2 = GetCountries();
            if (region != "All")
            {
                var fList = countries2.Where(x => x.Region == region && x.Name == name && x.Capital == capital && x.Population >= population_min && x.Population <= population_max).ToList();
                return fList;
            }
            else
            {
                return countries;
            }
        }


    }
}

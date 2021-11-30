using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DateTimeFormats
{
    public static class Program
    {
        private static void Main()
        {

            var dateTime = Convert.ToDateTime("2020-06-08T12:00:00.000Z");

            var settings = new JsonSerializerSettings
            {
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateFormatString = @"yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffK"
            };

            var jsonObject = JsonConvert.SerializeObject(dateTime, settings);
            Console.WriteLine(jsonObject);
        }
    }
}

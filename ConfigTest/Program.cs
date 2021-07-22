using System;

namespace ConfigTest
{
    public static class Program
    {
        private static void Main()
        {
            // returns string value if exists
            var s0 = ConfigHelper.GetSetting("StringValue");

            // returns null for missing value
            var n0 = ConfigHelper.GetSetting("MissingValue");               

            // returns a value of the desired type
            var s1 = ConfigHelper.GetSetting<string>("StringValue");
            var i1 = ConfigHelper.GetSetting<int>("IntValue");
            var d1 = ConfigHelper.GetSetting<decimal>("DecimalValue");
            var f1 = ConfigHelper.GetSetting<float>("FloatValue");
            var dt1 = ConfigHelper.GetSetting<DateTime>("DateTimeValue");
            var b1 = ConfigHelper.GetSetting<bool>("BoolValue");

            // returns default value if the setting does not exist
            var s2 = ConfigHelper.GetSetting("MissingValue", "DefaultValue");
            var i2 = ConfigHelper.GetSetting("MissingValue", 999);
            var d2 = ConfigHelper.GetSetting("MissingValue", 9.99m);
            var f2 = ConfigHelper.GetSetting("MissingValue", 9.99f);
            var dt2 = ConfigHelper.GetSetting("MissingValue", new DateTime(2018, 1, 1));
            var b2 = ConfigHelper.GetSetting("MissingValue", true);

            // throws not found exception
            var s3 = ConfigHelper.GetSetting<string>("MissingValue");

            // throws invalid setting exception
            var i3 = ConfigHelper.GetSetting<int>("InvalidValue");          
            var d3 = ConfigHelper.GetSetting<decimal>("InvalidValue");      
            var f3 = ConfigHelper.GetSetting<float>("InvalidValue");        
            var dt3 = ConfigHelper.GetSetting<DateTime>("InvalidValue");    
            var b3 = ConfigHelper.GetSetting<bool>("InvalidValue");         
        }
    }
}

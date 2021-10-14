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
            var e1 = ConfigHelper.GetSetting<MyEnum>("MyEnum");

            // returns default value if the setting does not exist
            var s2 = ConfigHelper.GetSetting("MissingValue", "DefaultValue");
            var i2 = ConfigHelper.GetSetting("MissingValue", 999);
            var d2 = ConfigHelper.GetSetting("MissingValue", 9.99m);
            var f2 = ConfigHelper.GetSetting("MissingValue", 9.99f);
            var dt2 = ConfigHelper.GetSetting("MissingValue", new DateTime(2018, 1, 1));
            var b2 = ConfigHelper.GetSetting("MissingValue", true);
            var e2 = ConfigHelper.GetSetting("MissingValue", MyEnum.Default);

            // throws not found exception if the setting does not exist and no default value specified
            var s3 = ConfigHelper.GetSetting<string>("MissingValue");

            // throws invalid setting exception if the value can not be converted
            var i3 = ConfigHelper.GetSetting<int>("InvalidValue");
            var d3 = ConfigHelper.GetSetting<decimal>("InvalidValue");
            var f3 = ConfigHelper.GetSetting<float>("InvalidValue");
            var dt3 = ConfigHelper.GetSetting<DateTime>("InvalidValue");
            var b3 = ConfigHelper.GetSetting<bool>("InvalidValue");
            var e3 = ConfigHelper.GetSetting<MyEnum>("InvalidValue");

            // throws invalid setting exception if the value can not be converted, even if a default value is specified
            var i4 = ConfigHelper.GetSetting("InvalidValue", 999);
            var d4 = ConfigHelper.GetSetting("InvalidValue", 9.99m);
            var f4 = ConfigHelper.GetSetting("InvalidValue", 9.99f);
            var dt4 = ConfigHelper.GetSetting("InvalidValue", new DateTime(2018, 1, 1));
            var b4 = ConfigHelper.GetSetting("InvalidValue", true);
            var e4 = ConfigHelper.GetSetting("InvalidValue", MyEnum.Default);
        }
    }
}

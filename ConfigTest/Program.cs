using System;

namespace ConfigTest
{
    public static class Program
    {
        private static void Main()
        {
            var s1 = ConfigHelper.GetSetting<string>("StringValue");
            var i1 = ConfigHelper.GetSetting<int>("IntValue");
            var d1 = ConfigHelper.GetSetting<decimal>("DecimalValue");
            var f1 = ConfigHelper.GetSetting<float>("FloatValue");
            var dt1 = ConfigHelper.GetSetting<DateTime>("DateTimeValue");
            var b1 = ConfigHelper.GetSetting<bool>("BoolValue");

            var s2 = ConfigHelper.GetSetting("blah", "DefaultValue");
            var i2 = ConfigHelper.GetSetting("blah", 999);
            var d2 = ConfigHelper.GetSetting("blah", 9.99m);
            var f2 = ConfigHelper.GetSetting("blah", 9.99f);
            var dt2 = ConfigHelper.GetSetting("blah", new DateTime(2018, 1, 1));
            var b2 = ConfigHelper.GetSetting("blah", true);

            var i3 = ConfigHelper.GetSetting<int>("InvalidValue");
            var d3 = ConfigHelper.GetSetting<decimal>("InvalidValue");
            var f3 = ConfigHelper.GetSetting<float>("InvalidValue");
            var dt3 = ConfigHelper.GetSetting<DateTime>("InvalidValue");
            var b3 = ConfigHelper.GetSetting<bool>("InvalidValue");
        }
    }
}

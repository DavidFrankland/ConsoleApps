using System;
using System.Collections.Generic;
using System.Reflection;
using log4net;

namespace Log4netTest
{
    public static class Program
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private static void Main()
        {
            var message = "Main";
            Log.Fatal(message);
            Log.Error(message);
            Log.Warn(message);
            Log.Info(message);
            Log.Debug(message);

            var t = new Thing();
            t.DoStuff();
        }
    }

    public class Thing
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public void DoStuff()
        {
            var message = "DoStuff";
            Log.Fatal(message);
            Log.Error(message);
            Log.Warn(message);
            Log.Info(message);
            Log.Debug(message);
        }
    }
}

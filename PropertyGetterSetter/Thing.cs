using System;

namespace PropertyGetterSetter
{
    public class Thing
    {
        public override string ToString()
        {
            return $"Id:{Id} Value:{Value}";
        }

        public int Id { get; set; }
        public string Value { get; set; }
    }
}

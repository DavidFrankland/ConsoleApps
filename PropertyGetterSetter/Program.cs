using System;
using System.Linq.Expressions;
using System.Reflection;

namespace PropertyGetterSetter
{
    public static class Program
    {
        private static void Main()
        {
            Thing thing = new Thing
            {
                Id = 1,
                Value = "Thing 1"
            };

            SetProperty(thing, x => x.Id, 123);

            var setter = PropertySetter<Thing, int>(x => x.Id);
            setter(thing, 456);

            var property = GetProperty(thing, x => x.Value);

            Console.WriteLine(property);
        }

        private static TProperty GetProperty<T, TProperty>(T t, Func<T, TProperty> getter)
        {
            return getter(t);
        }

        /// <summary>
        /// The "Ian Mercer" technique
        /// </summary>
        private static Action<T, TProperty> PropertySetter<T, TProperty>(Expression<Func<T, TProperty>> expression)
        {
            var memberExpression = (MemberExpression)expression.Body;
            var property = (PropertyInfo)memberExpression.Member;
            var setMethod = property.GetSetMethod();

            var parameterT = Expression.Parameter(typeof(T), "x");
            var parameterTProperty = Expression.Parameter(typeof(TProperty), "y");

            var newExpression =
                Expression.Lambda<Action<T, TProperty>>(
                    Expression.Call(parameterT, setMethod, parameterTProperty),
                    parameterT,
                    parameterTProperty
                );

            return newExpression.Compile();
        }

        private static void SetProperty<T, TProperty>(T t, Expression<Func<T, TProperty>> setter, TProperty newValue)
        {
            var prop = (PropertyInfo)((MemberExpression)setter.Body).Member;
            prop.SetValue(t, newValue);
        }
    }
}

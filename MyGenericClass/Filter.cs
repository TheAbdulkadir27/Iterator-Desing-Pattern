using System;
using System.Collections.Generic;
namespace MyGenericClass
{
    public static class Filter
    {
        public static IEnumerable<T> Where2<T>(this IEnumerable<T> entities, Func<T,bool> func)
        {
            foreach (var item in entities)
            {
                if(func(item))
                {
                    yield return item;
                }
            }
        }
    }
}

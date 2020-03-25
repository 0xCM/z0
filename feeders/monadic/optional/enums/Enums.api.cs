//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Collections.Concurrent;
    using System.Linq;

    using static Monadic;

    public static partial class Enums
    {
        [MethodImpl(Inline)]
        public static E zero<E>()
            where E : unmanaged, Enum
                => default(E);

        /// <summary>
        /// Reads a generic numeric value from a boxed enum
        /// </summary>
        /// <param name="e">The enum value to reinterpret</param>
        /// <typeparam name="V">The numeric value type</typeparam>
        [MethodImpl(Inline)]
        public static V numeric<V>(Enum e)
            where V : unmanaged
                => (V)Convert.ChangeType(e, e.GetTypeCode());
 
        /// <summary>
        /// Gets the literals defined by an enumeration together with their integral values
        /// </summary>
        /// <param name="peek">If true, extracts the content, bypassing any caching</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="V">The numeric value type</typeparam>
        public static EnumValues<E,V> values<E,V>(bool peek = false)
            where E : unmanaged, Enum
            where V : unmanaged
                => peek ? CreateValueIndex<E,V>() : (EnumValues<E,V>)ValueCache.GetOrAdd(typeof(E), _ => CreateValueIndex<E,V>());

        /// <summary>
        /// Determines whether an enum has a specified integral value
        /// </summary>
        /// <param name="v">The test value</param>
        /// <typeparam name="E">The enum source type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline)]
        public static bool defined<E,V>(V v)
            where E : unmanaged, Enum
            where V : unmanaged
                => Enum.IsDefined(typeof(E), v);

        /// <summary>
        /// Determines whether an enum defines a name-identified literal
        /// </summary>
        /// <param name="name">The test name</param>
        /// <typeparam name="E">The enum source type</typeparam>
        [MethodImpl(Inline)]
        public static bool defined<E>(string name)
            where E : unmanaged, Enum
                => Enum.IsDefined(typeof(E), name);
        
        /// <summary>
        /// Gets the literals defined by an enumeration
        /// </summary>
        /// <param name="peek">If true, extracts the content directly, bypassing any caching</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static E[] valarray<E>(bool peek = false)
            where E : unmanaged, Enum
                => peek ? CreateValArray<E>()  : (E[])LiteralCache.GetOrAdd(typeof(E), _ => CreateValArray<E>());

        /// <summary>
        /// Constructs a arbitrarily deduplicated value-to-member index
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="V">The numeric value type</typeparam>
        public static IDictionary<V,E> dictionary<E,V>(bool peek = false)
            where E : unmanaged, Enum
            where V : unmanaged
        {
            var pairs = values<E,V>(peek);
            var index = new Dictionary<V,E>();
            foreach(var pair in pairs)
                index.TryAdd(pair.NumericValue, pair.LiteralValue);
            return index;
        }

        /// <summary>
        /// Gets the names of the (unique) enumeration literals
        /// </summary>
        /// <param name="e">An enum type representative</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static string[] names<E>()
            => Enum.GetNames(typeof(E));        

        /// <summary>
        /// Gets the literals defined by an enumeration together with their integral values
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The value type</typeparam>
        static EnumValues<E,T> CreateValueIndex<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var index = CreateLiteralIndex<E>();
            var dst = new EnumValue<E,T>[index.Length];
            for(var i=0; i<index.Length; i++)
            {
                var literal = index[i];
                dst[i] =  EnumValue.Define(literal, numeric<E,T>(literal.Value));
            }
            return dst;        
        }

        /// <summary>
        /// Gets the literals defined by an enumeration
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        static E[] CreateValArray<E>()
            where E : unmanaged, Enum
        {
            var i = literals<E>(false);
            var dst = new E[i.Length];
            for(var j = 0; j<dst.Length; j++)
                dst[j] = i[j].Value;
            return dst;    
        }

        static ConcurrentDictionary<Type,object> IndicesCache {get;}
            = new ConcurrentDictionary<Type, object>();

        static ConcurrentDictionary<Type,object> ValueCache {get;}
            = new ConcurrentDictionary<Type, object>();
   }
}
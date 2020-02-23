//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    public static class Enums
    {
        [MethodImpl(Inline)]
        public static E zero<E>()
            where E : unmanaged, Enum
            => (E)typeof(E).GetEnumUnderlyingType().NumericKind().Zero().Value;

        /// <summary>
        /// Reads a generic value from a generic enum. 
        /// </summary>
        /// <param name="e">The enum value to reinterpret</param>
        /// <typeparam name="E">The enum source type</typeparam>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe T value<E,T>(E e, T t = default)
            where E : unmanaged, Enum
            where T : unmanaged
                => Unsafe.Read<T>((T*)(&e));

        /// <summary>
        /// Reads a generic enum member from a generic value
        /// </summary>
        /// <param name="v">The value to reinterpret</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe E member<T,E>(T v, E e = default)
            where E : unmanaged, Enum
            where T : unmanaged
                => Unsafe.Read<E>((E*)&v);

        /// <summary>
        /// Gets the literals defined by an enumeration
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static E[] members<E>(E e = default)
            where E : unmanaged, Enum
                => (E[])Enum.GetValues(typeof(E));

        /// <summary>
        /// Gets the literals defined by an enumeration together with their integral values
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The value type</typeparam>
        public static Pair<E,T>[] pairs<E,T>(E e = default, T t = default)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var members = members<E>();
            var pairs = new Pair<E,T>[members.Length];
            for(var i=0; i<members.Length; i++)
                pairs[i] = paired(members[i], value<E,T>(members[i]));
            return pairs;        
        }

        /// <summary>
        /// Constructs a arbitrarily deduplicated value-to-member index
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The value type</typeparam>
        public static IDictionary<T,E> values<E,T>(E e = default, T t = default)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var pairs = pairs<E,T>();
            var index = new Dictionary<T,E>();
            foreach(var pair in pairs)
                index.TryAdd(pair.B, pair.A);
            return index;
        }

        /// <summary>
        /// Gets the names of the (unique) enumeration literals
        /// </summary>
        /// <param name="e">An enum type representative</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static string[] names<E>(E e = default)
            => Enum.GetNames(typeof(E));

        /// <summary>
        /// Parses an enumeration literal
        /// </summary>
        /// <param name="name">The literal name</param>
        /// <param name="cased">True if casing should be respected, false to ignore case</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static E parse<E>(string name, bool cased = false, E @default = default)
            where E : unmanaged, Enum
                => Root.Try(() => Enum.Parse<E>(name, !cased)).ValueOrDefault(@default);
   }
}
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

    using static Root;

    public static class Enums
    {
        [MethodImpl(Inline)]
        public static E zero<E>()
            where E : unmanaged, Enum
            => (E)typeof(E).GetEnumUnderlyingType().NumericKind().Zero().Value;

        /// <summary>
        /// Reads a generic numeric value from a generic enum. 
        /// </summary>
        /// <param name="e">The enum value to reinterpret</param>
        /// <typeparam name="E">The enum source type</typeparam>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe V numeric<E,V>(E e, V t = default)
            where E : unmanaged, Enum
            where V : unmanaged
                => Unsafe.Read<V>((V*)(&e));

        /// <summary>
        /// Reads a generic enum member from a generic value
        /// </summary>
        /// <param name="v">The value to reinterpret</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe E literal<T,E>(T v, E e = default)
            where E : unmanaged, Enum
            where T : unmanaged
                => Unsafe.Read<E>((E*)&v);

        /// <summary>
        /// Gets the literals defined by an enumeration
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static E[] literals<E>(E e = default)
            where E : unmanaged, Enum
                => (E[])LiteralCache.GetOrAdd(typeof(E), _ => CreateLiterals<E>());
                //=> (E[])Enum.GetValues(typeof(E));

        /// <summary>
        /// Gets the literals defined by an enumeration together with their integral values
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The value type</typeparam>
        public static EnumValues<E,T> values<E,T>(E e = default, T t = default)
            where E : unmanaged, Enum
            where T : unmanaged
                => (EnumValues<E,T>)ValueCache.GetOrAdd(typeof(E), _ => CreateValues<E,T>());

        /// <summary>
        /// Gets the declaration-order indices for each defined literal
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        public static LiteralIndices<E> indices<E>()
            where E : unmanaged, Enum
                => (LiteralIndices<E>)IndicesCache.GetOrAdd(typeof(E), _ => CreateIndices<E>());

        /// <summary>
        /// Constructs a arbitrarily deduplicated value-to-member index
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The value type</typeparam>
        public static IDictionary<T,E> dictionary<E,T>(E e = default, T t = default)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var pairs = values<E,T>();
            var index = new Dictionary<T,E>();
            foreach(var pair in pairs)
                index.TryAdd(pair.Value, pair.Enum);
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

        /// <summary>
        /// Interprets an enum value as a signed byte
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static sbyte @sbyte<E>(E e = default, sbyte t = default)
            where E : unmanaged, Enum
                => Enums.numeric(e,t);

        /// <summary>
        /// Interprets an enum value as a byte
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static byte @byte<E>(E e, byte t = default)
            where E : unmanaged, Enum
                => Enums.numeric(e,t);

        /// <summary>
        /// Interprets an enum value as an unsigned 16-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ushort @ushort<E>(E e, ushort t = default)
            where E : unmanaged, Enum
                => Enums.numeric(e,t);

        /// <summary>
        /// Interprets an enum value as a signed 16-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static short @short<E>(E e, short t = default)
            where E : unmanaged, Enum
                => Enums.numeric(e,t);

        /// <summary>
        /// Interprets an enum value as a signed 32-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static int @int<E>(E e, int t = default)
            where E : unmanaged, Enum
                => Enums.numeric(e,t);

        /// <summary>
        /// Interprets an enum value as an unsigned 32-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static uint @uint<E>(E e, uint t = default)
            where E : unmanaged, Enum
                => Enums.numeric(e,t);

        /// <summary>
        /// Interprets an enum value as a signed 64-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static long @long<E>(E e, long t = default)
            where E : unmanaged, Enum
                => Enums.numeric(e,t);

        /// <summary>
        /// Interprets an enum value as an unsigned 64-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ulong @ulong<E>(E e, ulong t = default)
            where E : unmanaged, Enum
                => Enums.numeric(e,t);                

        /// <summary>
        /// Gets the literals defined by an enumeration together with their integral values
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The value type</typeparam>
        static EnumValues<E,T> CreateValues<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
        {
            //var members = literals<E>();
            var index = indices<E>();
            var dst = new EnumValue<E,T>[index.Length];
            for(var i=0; i<index.Length; i++)
            {
                var literal = index[i].Literal;
                var value = numeric<E,T>(literal);
                //dst[i] = (i, members[i], numeric<E,T>(members[i]));
                dst[i] = (i, literal, value);
            }
            return dst;        
        }

        /// <summary>
        /// Gets the literals defined by an enumeration
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static E[] CreateLiterals<E>()
            where E : unmanaged, Enum
        {
            var i = indices<E>();
            var dst = new E[i.Length];
            for(var j = 0; j<dst.Length; j++)
                dst[j] = i[j].Literal;
            return dst;    
        }

        public static LiteralIndices<E> CreateIndices<E>()
            where E : unmanaged, Enum
        {
            var fields = typeof(E).LiteralFields().ToArray();
            var dst = new LiteralIndex<E>[fields.Length];
            for(var i=0; i< fields.Length; i++)
            {
                var f = fields[i];
                var literal = Enums.parse<E>(f.Name);
                dst[i] = (Enums.parse<E>(f.Name),i);
            }
            return dst;
        }

        // static LiteralIndices<E> CreateIndices<E>()
        //     where E : unmanaged, Enum
        // {
        //     var members = literals<E>();
        //     var dst = new LiteralIndex<E>[members.Length];
        //     for(var i=0; i<members.Length; i++)
        //         dst[i] = (members[i],i);
        //     return dst;        
        // }

        static ConcurrentDictionary<Type,object> LiteralCache {get;}
            = new ConcurrentDictionary<Type, object>();

        static ConcurrentDictionary<Type,object> IndicesCache {get;}
            = new ConcurrentDictionary<Type, object>();

        static ConcurrentDictionary<Type,object> ValueCache {get;}
            = new ConcurrentDictionary<Type, object>();

   }
}
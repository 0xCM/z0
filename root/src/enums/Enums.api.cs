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
        /// <summary>
        /// Attempts to parses an enumeration literal, ignoring case, and returns a default value if parsing failed
        /// </summary>
        /// <param name="name">The literal name</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static E parse<E>(string name, E @default)
            where E : unmanaged, Enum
                => Root.Try(() => Enum.Parse<E>(name, true)).ValueOrDefault(@default);

        /// <summary>
        /// Attempts o parse an enum literal, ignoring case, and returns a null value if parsing failed
        /// </summary>
        /// <param name="name">The literal name</param>
        /// <typeparam name="E">The enum type</typeparam>
        public static ParseResult<E> parse<E>(string name)
            where E : unmanaged, Enum
        {
            try
            {                
                return ParseResult.Success(name,Enum.Parse<E>(name,true));
            }
            catch(Exception e)
            {
                return ParseResult.Fail<E>(name, e);
            }
        }

        [MethodImpl(Inline)]
        public static E zero<E>()
            where E : unmanaged, Enum
            => (E)typeof(E).GetEnumUnderlyingType().NumericKind().Zero().Value;

        /// <summary>
        /// Reads a generic numeric value from a generic enum. 
        /// </summary>
        /// <param name="e">The enum value to reinterpret</param>
        /// <typeparam name="E">The enum source type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe V numeric<E,V>(E e)
            where E : unmanaged, Enum
            where V : unmanaged
                => Unsafe.Read<V>((V*)(&e));

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
        /// Reads a generic numeric value from a boxed enum
        /// </summary>
        /// <param name="e">The enum value to reinterpret</param>
        /// <typeparam name="V">The numeric value type</typeparam>
        [MethodImpl(Inline)]
        public static V numeric<V>(Enum e)
            where V : unmanaged
                => (V)Convert.ChangeType(e, e.GetTypeCode());

        /// <summary>
        /// Determines an enumeration's underlying kind
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static EnumKind kind<E>()
            where E : unmanaged, Enum
                => (EnumKind)default(E).GetTypeCode();

        /// <summary>
        /// Reads a generic enum member from a generic value
        /// </summary>
        /// <param name="v">The value to reinterpret</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="V">The numeric value type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe E literal<E,V>(V v)
            where E : unmanaged, Enum
            where V : unmanaged
                => Unsafe.Read<E>((E*)&v);
        
        /// <summary>
        /// Puts an enum value into a (numeric) box
        /// </summary>
        /// <param name="e">The enumeration value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static BoxedNumber box<E>(E e)
            where E : unmanaged, Enum
                => BoxedNumber.Define(Convert.ChangeType(e, kind<E>().TypeCode()), kind<E>().NumericKind());

        /// <summary>
        /// Gets the literals defined by an enumeration
        /// </summary>
        /// <param name="peek">If true, extracts the content directly, bypassing any caching</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static E[] literals<E>(bool peek = false, bool skipzero = true)
            where E : unmanaged, Enum
                => peek 
                ? CreateLiterals<E>(skipzero) 
                : (E[])LiteralCache.GetOrAdd(typeof(E), _ => CreateLiterals<E>(skipzero));

        /// <summary>
        /// Gets the literals defined by an enumeration together with their integral values
        /// </summary>
        /// <param name="peek">If true, extracts the content, bypassing any caching</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="V">The numeric value type</typeparam>
        public static EnumValues<E,V> values<E,V>(bool peek = false, bool skipzero = true)
            where E : unmanaged, Enum
            where V : unmanaged
                => peek 
                ? CreateValues<E,V>(skipzero) 
                : (EnumValues<E,V>)ValueCache.GetOrAdd(typeof(E), _ => CreateValues<E,V>(skipzero));

        /// <summary>
        /// Gets the declaration-order indices for each defined literal
        /// </summary>
        /// <param name="peek">If true, extracts the content directly, bypassing any caching</param>
        /// <typeparam name="E">The enum type</typeparam>
        public static LiteralIndices<E> indices<E>(bool peek = false, bool skipzero = true)
            where E : unmanaged, Enum
                => peek 
                 ? CreateIndices<E>(skipzero) 
                 : (LiteralIndices<E>)IndicesCache.GetOrAdd(typeof(E), _ => CreateIndices<E>(skipzero));

        /// <summary>
        /// Constructs a arbitrarily deduplicated value-to-member index
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="V">The numeric value type</typeparam>
        public static IDictionary<V,E> dictionary<E,V>(bool peek = false, bool skipzero = true)
            where E : unmanaged, Enum
            where V : unmanaged
        {
            var pairs = values<E,V>(peek, skipzero);
            var index = new Dictionary<V,E>();
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
        public static string[] names<E>()
            => Enum.GetNames(typeof(E));
        
        /// <summary>
        /// Interprets an enum value as a signed byte
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static sbyte i8<E>(E e = default)
            where E : unmanaged, Enum
                => Enums.numeric<E,sbyte>(e);

        /// <summary>
        /// Interprets an enum value as a byte
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static byte u8<E>(E e)
            where E : unmanaged, Enum
                => Enums.numeric<E,byte>(e);

        /// <summary>
        /// Interprets an enum value as an unsigned 16-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ushort u16<E>(E e)
            where E : unmanaged, Enum
                => Enums.numeric<E,ushort>(e);

        /// <summary>
        /// Interprets an enum value as a signed 16-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static short i16<E>(E e)
            where E : unmanaged, Enum
                => Enums.numeric<E,short>(e);

        /// <summary>
        /// Interprets an enum value as a signed 32-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static int i32<E>(E e)
            where E : unmanaged, Enum
                => Enums.numeric<E,int>(e);

        /// <summary>
        /// Interprets an enum value as an unsigned 32-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static uint u32<E>(E e)
            where E : unmanaged, Enum
                => Enums.numeric<E,uint>(e);

        /// <summary>
        /// Interprets an enum value as a signed 64-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static long i64<E>(E e)
            where E : unmanaged, Enum
                => Enums.numeric<E,long>(e);

        /// <summary>
        /// Interprets an enum value as an unsigned 64-bit integer
        /// </summary>
        /// <param name="e">The enum value</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static ulong u64<E>(E e)
            where E : unmanaged, Enum
                => Enums.numeric<E,ulong>(e);

        /// <summary>
        /// Gets the literals defined by an enumeration together with their integral values
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="T">The value type</typeparam>
        static EnumValues<E,T> CreateValues<E,T>(bool skipzero = true)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var index = CreateIndices<E>(skipzero);
            var dst = new EnumValue<E,T>[index.Length];
            for(var i=0; i<index.Length; i++)
            {
                var literal = index[i].Literal;
                var value = numeric<E,T>(literal);
                dst[i] = (i, literal, value);
            }
            return dst;        
        }

        /// <summary>
        /// Gets the literals defined by an enumeration
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        static E[] CreateLiterals<E>(bool skipzero = true)
            where E : unmanaged, Enum
        {
            var i = indices<E>(false, skipzero);
            var dst = new E[i.Length];
            for(var j = 0; j<dst.Length; j++)
                dst[j] = i[j].Literal;
            return dst;    
        }

        static LiteralIndices<E> CreateIndices<E>(bool skipzero = true)
            where E : unmanaged, Enum
        {
            var fields = typeof(E).LiteralFields().ToArray();
            var indices = list<LiteralIndex<E>>(fields.Length);
            for(var i=0; i< fields.Length; i++)
            {
                var value = (E)fields[i].GetRawConstantValue();
                if(value.IsNone())                
                {
                    if(!skipzero)
                        indices.Add((value,i));
                }
                else
                    indices.Add((value,i));
            }
            return LiteralIndex.Define(indices.ToArray());
        }

        static ConcurrentDictionary<Type,object> LiteralCache {get;}
            = new ConcurrentDictionary<Type, object>();

        static ConcurrentDictionary<Type,object> IndicesCache {get;}
            = new ConcurrentDictionary<Type, object>();

        static ConcurrentDictionary<Type,object> ValueCache {get;}
            = new ConcurrentDictionary<Type, object>();
   }
}
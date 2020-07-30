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

    using static Konst;
    using static z;

    [ApiHost]
    public partial class Enums
    {
        [MethodImpl(Inline)]
        public static Refinement<V,T> refine<V,T>(V src, T t = default)
            where V : unmanaged, Enum
            where T : unmanaged
                => new Refinement<V,T>(src);            

        [MethodImpl(Inline)]
        public static E zero<E>()
            where E : unmanaged, Enum
                => default(E);

        /// <summary>
        /// Computes the bit-width of an enum with a specified base kind
        /// </summary>
        /// <param name="base">An integral type refined by an enum</param>
        [MethodImpl(Inline)]
        public static TypeWidth width(EnumScalarKind @base)
        {
            var exp = (byte)(@base & EnumScalarKind.WidthMask);
            return (TypeWidth)Pow2.pow(exp);
        }
                   
        /// <summary>
        /// Determines an enumeration's underlying kind
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static EnumTypeCode typecode<E>()
            where E : unmanaged, Enum
                => Primitive.ecode<E>();

        /// <summary>
        /// Reads a generic numeric value from a generic enum. 
        /// </summary>
        /// <param name="e">The enum value to reinterpret</param>
        /// <typeparam name="E">The enum source type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe T scalar<E,T>(E e)
            where E : unmanaged, Enum
            where T : unmanaged
                => EnumValue.scalar<E,T>(e);

        /// <summary>
        /// Reads a generic enum member from a generic value
        /// </summary>
        /// <param name="v">The value to reinterpret</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="V">The numeric value type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe E literal<E,T>(T v)
            where E : unmanaged, Enum
            where T : unmanaged
                => EnumValue.literal<E,T>(v);

        /// <summary>
        /// Reads a generic numeric value from a boxed enum
        /// </summary>
        /// <param name="e">The enum value to reinterpret</param>
        /// <typeparam name="V">The numeric value type</typeparam>
        [MethodImpl(Inline)]
        public static V scalar_slow<V>(Enum e)
            where V : unmanaged
                => (V)Convert.ChangeType(e, e.GetTypeCode());
 
        /// <summary>
        /// Gets the literals defined by an enumeration together with their integral values
        /// </summary>
        /// <param name="peek">If true, extracts the content, bypassing any caching</param>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="V">The numeric value type</typeparam>
        public static EnumLiterals<E,V> values<E,V>()
            where E : unmanaged, Enum
            where V : unmanaged
                => (EnumLiterals<E,V>)ValueCache.GetOrAdd(typeof(E), _ => LiteralSequence<E,V>());

        /// <summary>
        /// Defines an E-V parametric enum value given an E-parametric literal an a value:V
        /// </summary>
        /// <param name="literal">The source literal</param>
        /// <param name="value">The source value</param>
        /// <typeparam name="E">The enum source type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline)]
        public static EnumLiteral<E,V> evalue<E,V>(EnumLiteral<E> literal, V value)
            where E : unmanaged, Enum
            where V : unmanaged
                => new EnumLiteral<E,V>(literal,value);

        public static IEnumerable<BinaryLiteral<T>> BinaryLiterals<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
                => from f in typeof(E).LiteralFields().ToArray()
                   where f.Tagged<BinaryLiteralAttribute>()
                   let a = f.Tag<BinaryLiteralAttribute>().Require()
                   select z.literal(base2, f.Name, scalar<E,T>((E)f.GetValue(null)), a.Text);

        /// <summary>
        /// Gets the literals defined by an enumeration
        /// </summary>
        /// <param name="peek">If true, extracts the content directly, bypassing any caching</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static E[] literals<E>()
            where E : unmanaged, Enum
                => (E[])LiteralCache.GetOrAdd(typeof(E), _ => CreateLiteralArray<E>());

        public static ReadOnlySpan<E> literals<E>(int crop)
            where E : unmanaged, Enum
        {
            var literals = span(literals<E>());
            var count = literals.Length - crop;
            return literals.Slice(0,count);            
        }

        /// <summary>
        /// Constructs a arbitrarily deduplicated value-to-member index
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        /// <typeparam name="V">The numeric value type</typeparam>
        public static IDictionary<V,E> dictionary<E,V>()
            where E : unmanaged, Enum
            where V : unmanaged
        {
            var pairs = values<E,V>();
            var index = new Dictionary<V,E>();
            foreach(var pair in pairs)
                index.TryAdd(pair.NumericValue, pair.LiteralValue);
            return index;
        }
   }
}
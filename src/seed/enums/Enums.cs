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
    using static Root;

    using NK = NumericKind;
    using BK = EnumScalarKind;

    [ApiHost]
    public partial class Enums
    {
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
        /// Determines whether an enum base kind is signed
        /// </summary>
        /// <param name="base">An integral type refined by an enum</param>
        [MethodImpl(Inline)]
        public static bool signed(EnumScalarKind @base)
            => (@base & EnumScalarKind.SignMask) != 0;

        /// <summary>
        /// Determines the integral type refined by a value-identified enum type
        /// </summary>
        /// <param name="value">The enum value</typeparam>
        [MethodImpl(Inline)]
        public static EnumScalarKind @base(Enum value)
            => @base(value.GetType().GetEnumUnderlyingType().NumericKind());

        /// <summary>
        /// Determines the integral type refined by a specified enum type
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static EnumScalarKind @base(Type et)
            => @base(et.NumericKind());
        
        /// <summary>
        /// Determines the integral type refined by a parametrically-identified enum type
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static EnumScalarKind @base<E>()
            where E : unmanaged, Enum
             => @base(typeof(E).GetEnumUnderlyingType().NumericKind()); 

        public static EnumScalarKind @base(NumericKind src)
             => src switch{
                NK.U8 => BK.U8,
                NK.I8 => BK.I8,
                NK.U16 => BK.U16,
                NK.I16 => BK.I16,
                NK.U32 => BK.U32,
                NK.I32 => BK.I32,
                NK.I64 => BK.I64,
                NK.U64 => BK.U64,                
                _ => EnumScalarKind.None,
            };

        public static unsafe ulong untype<E>(E src)
            where E : unmanaged, Enum
            => typeof(E).GetEnumUnderlyingType().NumericKind() switch {
                NK.U8 => (ulong)e8u(src),
                NK.I8 => (ulong)e8i(src),
                NK.U16 => (ulong)e16u(src),
                NK.I16 => (ulong)e16i(src),
                NK.U32 => (ulong)e32u(src),
                NK.I32 => (ulong)e32i(src),
                NK.I64 => (ulong)e64i(src),
                NK.U64 => e64u(src),
                _ => 0ul,               
            };
                   
        /// <summary>
        /// Determines an enumeration's underlying kind
        /// </summary>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static EnumTypeCode typecode<E>()
            where E : unmanaged, Enum
                => (EnumTypeCode)default(E).GetTypeCode();

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

        /// <summary>
        /// Determines whether an enum value is valid
        /// </summary>
        /// <param name="v">The test value</param>
        /// <typeparam name="E">The enum source type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline)]
        public static bool defined<E>(E e)
            where E : unmanaged, Enum
                => Enum.IsDefined(typeof(E), e);

        public static IEnumerable<BinaryLiteral<T>> BinaryLiterals<E,T>()
            where E : unmanaged, Enum
            where T : unmanaged
                => from f in typeof(E).LiteralFields().ToArray()
                   where f.Tagged<BinaryLiteralAttribute>()
                   let a = f.Tag<BinaryLiteralAttribute>().Require()
                   select Literati.define(base2, f.Name, scalar<E,T>((E)f.GetValue(null)), a.Text);

        /// <summary>
        /// Gets the declaration-order indices for each named literal
        /// </summary>
        /// <param name="peek">If true, extracts the content directly, bypassing any caching</param>
        /// <typeparam name="E">The enum type</typeparam>
        public static EnumLiterals<E> index<E>()
            where E : unmanaged, Enum
                => (EnumLiterals<E>)IndexCache.GetOrAdd(typeof(E), _ => CreateIndex<E>());

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
            var literals = Root.span(Enums.literals<E>());
            var count = literals.Length - crop;
            return literals.Slice(0,count);            
        }

        [MethodImpl(Inline)]
        public static E definedOrElse<E>(E e, E alt)
            where E : unmanaged, Enum
                => defined<E>(e) ? e : alt;

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

        /// <summary>
        /// Gets the names of the (unique) enumeration literals
        /// </summary>
        /// <param name="e">An enum type representative</param>
        /// <typeparam name="E">The enum type</typeparam>
        [MethodImpl(Inline)]
        public static string[] names<E>()
            => Enum.GetNames(typeof(E));
   }
}
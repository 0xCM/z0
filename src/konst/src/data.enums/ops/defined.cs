//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial class Enums
    {
        public static EnumLiteral[] enums<E>()
            where E : unmanaged, Enum
        {
            var literals = Enums.index<E>();
            var count = literals.Length;
            var dst = new EnumLiteral[count];
            var primal = typeof(E).GetEnumUnderlyingType();
            var flags = typeof(E).Tagged<FlagsAttribute>();
            var baseTag =typeof(E).Tag<NumericBaseAttribute>();
            var @base = baseTag.MapValueOrDefault(x => x.Base, NumericBaseKind.Base10);
            var bitmax = baseTag.MapValueOrDefault(x => x.MaxDigits, (int?)null);
            var hexmax = bitmax != null ? bitmax.Value/4 : (int?)null;
            var declarer = typeof(E).Name;

            for(var i=0; i<dst.Length; i++)
            {
                var literal = literals[i];
                var description = Literals.tagged(typeof(E).Field(literal.ToString()).Require()).Text;
                if(string.IsNullOrWhiteSpace(description) && flags)
                    description = literal.LiteralValue.ToString();
                var bs = @base == NumericBaseKind.Base2 ? Formatters.value().FormatEnum(literal.LiteralValue, n2, bitmax) : EmptyString;
                var hex = Formatters.value().FormatEnum(literal.LiteralValue, n16, hexmax);
                dst[i] = new EnumLiteral(declarer, literal.Position, literal.Name, hex, bs, description);
            }

            return dst;
        }

        public static FieldValues<E,T> enums<E,T>(Type src)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var tValues = LiteralFields.values<T>(src);
            var count = tValues.Length;
            var eValueBuffer = sys.alloc<EnumFieldValue<E,T>>(count);
            var dst = span(eValueBuffer);

            for(var i=0u; i<count; i++)
            {
                ref readonly var srcVal = ref tValues[i];
                ref readonly var tVal = ref srcVal.Value;
                ref readonly var srcField = ref srcVal.Field;
                seek(dst, i) = new EnumFieldValue<E,T>(srcField, read<E,T>(tVal), tVal);
            }

            return index(eValueBuffer);
        }

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
        /// Determines whether an enum value is valid
        /// </summary>
        /// <param name="v">The test value</param>
        /// <typeparam name="E">The enum source type</typeparam>
        /// <typeparam name="V">The value type</typeparam>
        [MethodImpl(Inline)]
        public static bool defined<E>(E e)
            where E : unmanaged, Enum
                => Enum.IsDefined(typeof(E), e);

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
    }
}
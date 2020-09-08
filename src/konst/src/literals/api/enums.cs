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

    partial struct Literals
    {
        public static EnumLiteral[] enums<E>()
            where E : unmanaged, Enum
        {
            var literals = Enums.index<E>();
            var dst = new EnumLiteral[literals.Length];
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

                var description = attributed(typeof(E).Field(literal.ToString()).Require()).Text;
                if(string.IsNullOrWhiteSpace(description) && flags)
                    description = literal.LiteralValue.ToString();

                var bs = @base == NumericBaseKind.Base2 ? Formatters.value().FormatEnum(literal.LiteralValue, n2, bitmax) : string.Empty;
                var hex = Formatters.value().FormatEnum(literal.LiteralValue, n16, hexmax);
                dst[i] = new EnumLiteral(declarer, literal.Position, literal.Name, hex, bs, description);
            }

            return dst;
        }
    }
}
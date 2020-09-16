//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    using F = EnumDatasetField;

    partial class Enums
    {
        [MethodImpl(Inline), Op]
        public static string format(in EnumDatasetEntry src, char delimiter = FieldDelimiter)
        {
            var dst = text.build();
            dst.Delimit(F.Token, src.Id);
            dst.Delimit(F.Index, src.Index);
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.Scalar, src.ScalarValue);
            return dst.ToString();
        }

        [MethodImpl(Inline)]
        public static string format<E,T>(in EnumDatasetEntry<E,T> src, char delimiter = FieldDelimiter)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var dst = text.build();
            dst.Delimit(F.Token, src.Id);
            dst.Delimit(F.Index, src.Index);
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.Scalar, src.ScalarValue);
            return dst.ToString();
        }

        [MethodImpl(Inline)]
        public static string format<E,T>(in EnumLiteralInfo<E,T> src, char delimiter = FieldDelimiter)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var dst = text.build();
            dst.Delimit(F.Token, src.Id);
            dst.Delimit(F.Index, src.Position);
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.Scalar, src.Scalar);
            return dst.ToString();
        }
    }
}
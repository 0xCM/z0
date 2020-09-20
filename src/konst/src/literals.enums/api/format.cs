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

    using D = EnumDatasetField;
    using F = EnumLiteralTableField;

    partial class Enums
    {
        public static string format<E1,E2>(in EnumPair<E1,E2> src)
            where E1: unmanaged, Enum
            where E2: unmanaged, Enum
                => $"{src.Name}([{Enums.scalar<E1,ulong>(src.First)}: {typeof(E1).Name}], [{Enums.scalar<E2,ulong>(src.Second)}: {typeof(E2).Name}])";

        public static void format(in EnumLiteralRow src, TableFormatter<EnumLiteralTableField> dst, bool eol = true)
        {
            dst.Append(F.PartId, src.PartId);
            dst.Delimit(F.TypeId, src.TypeId);
            dst.Delimit(F.TypeAddress, src.TypeAddress);
            dst.Delimit(F.NameAddress, src.NameAddress);
            dst.Delimit(F.TypeName, src.TypeName);
            dst.Delimit(F.DataType, src.PrimalKind);
            dst.Delimit(F.Index, src.Index);
            dst.Delimit(F.ScalarValue, src.ScalarValue);
            dst.Delimit(F.Name, src.Name);
            if(eol)
                dst.EmitEol();
        }

        [MethodImpl(Inline), Op]
        public static string format(in EnumDatasetEntry src, char delimiter = FieldDelimiter)
        {
            var dst = text.build();
            dst.Delimit(D.Token, src.Id);
            dst.Delimit(D.Index, src.Index);
            dst.Delimit(D.Name, src.Name);
            dst.Delimit(D.Scalar, src.ScalarValue);
            return dst.ToString();
        }

        [MethodImpl(Inline)]
        public static string format<E,T>(in EnumDatasetEntry<E,T> src, char delimiter = FieldDelimiter)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var dst = text.build();
            dst.Delimit(D.Token, src.Id);
            dst.Delimit(D.Index, src.Index);
            dst.Delimit(D.Name, src.Name);
            dst.Delimit(D.Scalar, src.ScalarValue);
            return dst.ToString();
        }

        [MethodImpl(Inline)]
        public static string format<E,T>(in EnumLiteralInfo<E,T> src, char delimiter = FieldDelimiter)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var dst = text.build();
            dst.Delimit(D.Token, src.Id);
            dst.Delimit(D.Index, src.Position);
            dst.Delimit(D.Name, src.Name);
            dst.Delimit(D.Scalar, src.Scalar);
            return dst.ToString();
        }
    }
}
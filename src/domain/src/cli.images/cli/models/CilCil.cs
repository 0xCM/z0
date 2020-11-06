//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    [StructLayout(LayoutKind.Sequential), Table(TableId, FieldCount)]
    public struct CilCil
    {
        public const string TableId = "cli.cil";

        public const byte FieldCount = 5;

        public const string DataType = "il";

        public static string format(in CilCil src)
        {
            var dst = EmptyString.Build();
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(src.MethodSig.Format().PadRight(80));
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(src.MethodName.PadRight(50));
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(src.Rva.Format().PadRight(12));
            dst.Append(FieldDelimiter);
            dst.Append(Space);
            dst.Append(src.Cil.Format());
            return dst.ToString();
        }

        public static string RowHeader
            => text.concat(FieldDelimiter, Space,
                "MethodSig".PadRight(80),  FieldDelimiter,  Space,
                "MethodName".PadRight(50), FieldDelimiter,  Space,
                "Rva".PadRight(12), FieldDelimiter, Space,
                "Il");

        public BinaryCode MethodSig;

        public string MethodName;

        public Address32 Rva;

        public BinaryCode Cil;

        public ByteSize Size;
    }
}
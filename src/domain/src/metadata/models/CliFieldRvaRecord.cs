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

    [StructLayout(LayoutKind.Sequential), Table(TableName, FieldCount)]
    public struct CliFieldRvaRecord
    {
        public const string TableName = "image.fieldrva";

        public const byte FieldCount = 4;

        public Address32 Rva;

        public string TypeName;

        public string FieldName;

        public CliBlobRecord Sig;

        public BinaryCode SigData
            => Sig.Data;

        [MethodImpl(Inline)]
        public CliFieldRvaRecord(Address32 rva, string typeName, string name, CliBlobRecord sig)
        {
            Rva = rva;
            TypeName = typeName;
            FieldName = name;
            Sig = sig;
        }

        public int CompareTo(CliFieldRvaRecord src)
            => Rva.CompareTo(src.Rva);
    }
}
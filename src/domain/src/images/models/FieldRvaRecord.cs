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

    [StructLayout(LayoutKind.Sequential), Table(TableName)]
    public struct FieldRvaRecord
    {
        public const string TableName = "image.fieldrva";

        public Address32 Rva;

        public string TypeName;

        public string FieldName;

        public ImageBlobRecord Sig;

        public BinaryCode SigData
            => Sig.Data;

        [MethodImpl(Inline)]
        public FieldRvaRecord(Address32 rva, string typeName, string name, ImageBlobRecord sig)
        {
            Rva = rva;
            TypeName = typeName;
            FieldName = name;
            Sig = sig;
        }

        public int CompareTo(FieldRvaRecord src)
            => Rva.CompareTo(src.Rva);
    }
}
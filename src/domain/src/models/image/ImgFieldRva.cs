//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public enum ImgRvaField : uint
    {
        Rva = 0 | (16 << WidthOffset),

        Name = 1 | (64 << WidthOffset),

        Signature = 2 | (64 << WidthOffset),
    }

    [Table]
    public struct ImageFieldRvaRecord : IComparable<ImageFieldRvaRecord>
    {
        public Address32 Rva;

        public string TypeName;

        public string FieldName;

        public ImgBlobRecord Sig;

        public BinaryCode SigData
            => Sig.Data;

        [MethodImpl(Inline)]
        public ImageFieldRvaRecord(Address32 rva, string typeName, string name, ImgBlobRecord sig)
        {
            Rva = rva;
            TypeName = typeName;
            FieldName = name;
            Sig = sig;;
        }

        public int CompareTo(ImageFieldRvaRecord src)
            => Rva.CompareTo(src.Rva);
    }
}
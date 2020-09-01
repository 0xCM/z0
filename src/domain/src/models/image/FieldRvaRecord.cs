//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;


    [Table]
    public struct FieldRvaRecord
    {
        public Address32 Rva;

        public string TypeName;

        public string FieldName;

        public ImgBlobRecord Sig;

        public BinaryCode SigData
            => Sig.Data;

        [MethodImpl(Inline)]
        public FieldRvaRecord(Address32 rva, string typeName, string name, ImgBlobRecord sig)
        {
            Rva = rva;
            TypeName = typeName;
            FieldName = name;
            Sig = sig;;
        }

        public int CompareTo(FieldRvaRecord src)
            => Rva.CompareTo(src.Rva);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Part;

    [StructLayout(LayoutKind.Sequential), Record]
    public struct FieldRvaInfo : IRecord<FieldRvaInfo>
    {
        public Address32 Rva;

        public string TypeName;

        public string FieldName;

        public CliBlobInfo Sig;

        public BinaryCode SigData
            => Sig.Data;

        [MethodImpl(Inline)]
        public FieldRvaInfo(Address32 rva, string typeName, string name, CliBlobInfo sig)
        {
            Rva = rva;
            TypeName = typeName;
            FieldName = name;
            Sig = sig;
        }

        public int CompareTo(FieldRvaInfo src)
            => Rva.CompareTo(src.Rva);
    }
}
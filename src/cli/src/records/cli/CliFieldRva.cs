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

    [StructLayout(LayoutKind.Sequential), Record]
    public struct CliFieldRva : IRecord<CliFieldRva>
    {
        public Address32 Rva;

        public string TypeName;

        public string FieldName;

        public CliBlob Sig;

        public BinaryCode SigData
            => Sig.Data;

        [MethodImpl(Inline)]
        public CliFieldRva(Address32 rva, string typeName, string name, CliBlob sig)
        {
            Rva = rva;
            TypeName = typeName;
            FieldName = name;
            Sig = sig;
        }

        public int CompareTo(CliFieldRva src)
            => Rva.CompareTo(src.Rva);
    }
}
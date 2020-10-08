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

    public struct CilMethodData
    {
        public const string TableId = "image.cil";

        public const string DataType = "il";

        public BinaryCode Sig;

        public string Name;

        public Address32 Rva;

        public BinaryCode Cil;

        public ByteSize Size;
    }
}
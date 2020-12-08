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

    [StructLayout(LayoutKind.Sequential), Table(TableId)]
    public struct CliCil : IRecord<CliCil>
    {
        public const string TableId = "cli.cil";

        public BinaryCode MethodSig;

        public string MethodName;

        public Address32 Rva;

        public BinaryCode Cil;

        public ByteSize Size;
    }
}
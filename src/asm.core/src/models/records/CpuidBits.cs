//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    [Record(TableId), StructLayout(LayoutKind.Sequential, Pack=1)]
    public struct CpuidBits : IRecord<CpuidBits>
    {
        public const string TableId = "asm.cpuid.bits";

        [Label("eax(in)")]
        public ByteBlock47 EaxIn;

        [Label("ecx(in)")]
        public ByteBlock47 EcxIn;

        [Label("eax(out)")]
        public ByteBlock47 EaxOut;

        [Label("ebx(out)")]
        public ByteBlock47 EbxOut;

        [Label("ecx(out)")]
        public ByteBlock47 EcxOut;

        [Label("edx(out)")]
        public ByteBlock47 EdxOut;
    }
}
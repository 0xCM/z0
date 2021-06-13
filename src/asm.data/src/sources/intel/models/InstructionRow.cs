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

    public readonly partial struct IntelSdm
    {
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public ref struct InstructionRow
        {
            public ReadOnlySpan<byte> OpCode;

            public ReadOnlySpan<byte> Sig;

            public ReadOnlySpan<byte> Encoding;

            public ReadOnlySpan<byte> Mode64;

            public ReadOnlySpan<byte> LegacyMode;

            public ReadOnlySpan<byte> Description;
        }
    }
}
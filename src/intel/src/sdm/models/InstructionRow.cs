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
            public ReadOnlySpan<char> OpCode;

            public ReadOnlySpan<char> Sig;

            public ReadOnlySpan<char> Encoding;

            public ReadOnlySpan<char> Mode64;

            public ReadOnlySpan<char> LegacyMode;

            public ReadOnlySpan<char> Description;
        }
    }
}
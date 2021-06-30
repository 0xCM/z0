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

    partial struct IntelSdm
    {
        [StructLayout(LayoutKind.Sequential, Pack=1)]
        public ref struct EncodingCrossRef
        {
            public ReadOnlySpan<char> Key;

            public ReadOnlySpan<char> Operand1;

            public ReadOnlySpan<char> Operand2;

            public ReadOnlySpan<char> Operand3;

            public ReadOnlySpan<char> Operand4;
        }
    }
}
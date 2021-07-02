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
    using static core;

    using static AsmSigTokens;

    [StructLayout(LayoutKind.Sequential, Size=2)]
    public readonly struct AsmSigToken
    {
        public SigTokenKind Kind {get;}

        public byte Value {get;}

        [MethodImpl(Inline)]
        public AsmSigToken(SigTokenKind kind, byte value)
        {
            Kind = kind;
            Value = value;
        }
    }
}
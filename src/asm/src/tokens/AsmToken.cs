//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmToken
    {
        public readonly byte Index;

        public readonly AsmTokenKind Identifier;

        public readonly asci16 Value;

        [MethodImpl(Inline)]
        public AsmToken(byte index, AsmTokenKind identifier, asci16 value)
        {
            Index = index;
            Identifier = identifier;
            Value = value;
        }
    }
}
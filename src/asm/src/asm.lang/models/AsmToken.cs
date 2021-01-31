//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmToken
    {
        public byte Index {get;}

        public AsmSigSyntaxKey Identifier {get;}

        public asci16 Value {get;}

        [MethodImpl(Inline)]
        public AsmToken(byte index, AsmSigSyntaxKey identifier, asci16 value)
        {
            Index = index;
            Identifier = identifier;
            Value = value;
        }
    }
}
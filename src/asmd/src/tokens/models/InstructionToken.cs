//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Tokens;

    using static Konst;    

    public readonly struct InstructionToken
    {        
        public readonly byte Index;
        
        public readonly InstructionTokenKind Identifier;

        public readonly asci16 Value;

        [MethodImpl(Inline)]
        public InstructionToken(byte index, InstructionTokenKind identifier, asci16 value)
        {
            Index = index;
            Identifier = identifier;
            Value = value;
        }
    }
}
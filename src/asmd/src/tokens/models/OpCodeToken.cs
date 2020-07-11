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

    public readonly struct OpCodeToken
    {        
        public readonly byte Index;
        
        public readonly OpCodeTokenKind Identifier;

        public readonly StringRef Value;

        [MethodImpl(Inline)]
        public OpCodeToken(byte index, OpCodeTokenKind identifier, StringRef value)
        {
            Index = index;
            Identifier = identifier;
            Value = value;
        }

        public string Format()
            => text.concat(Identifier.ToString(), " := ", Value.Format());
    }
}
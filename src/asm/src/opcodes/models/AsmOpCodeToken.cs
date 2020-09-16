//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

    public readonly struct AsmOpCodeToken
    {        
        public readonly byte Index;
        
        public readonly AsmOpCodeTokenKind Identifier;

        public readonly StringRef Value;

        [MethodImpl(Inline)]
        public AsmOpCodeToken(byte index, AsmOpCodeTokenKind identifier, StringRef value)
        {
            Index = index;
            Identifier = identifier;
            Value = value;
        }

        public string Format()
            => text.concat(Identifier.ToString(), " := ", Value.Format());
    }
}
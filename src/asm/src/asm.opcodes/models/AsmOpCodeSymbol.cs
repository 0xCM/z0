//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmOpCodeSymbol
    {
        public string Value {get;}

        [MethodImpl(Inline)]
        public AsmOpCodeSymbol(string src)
            => Value = src;

        [MethodImpl(Inline)]
        public static implicit operator AsmOpCodeSymbol(string src)
            => new AsmOpCodeSymbol(src);
    }
}
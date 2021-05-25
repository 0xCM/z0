//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmSymbol : ITextual
    {
        readonly TextBlock Data;

        [MethodImpl(Inline)]
        public AsmSymbol(string src)
        {
            Data = src;
        }

        public string Format()
            => string.Format("({0})", Data);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator AsmSymbol(string src)
            => new AsmSymbol(src);
    }
}
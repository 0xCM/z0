//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmBitstring : ITextual
    {
        readonly string Bits;

        public AsmHexCode Code {get;}

        [MethodImpl(Inline)]
        public AsmBitstring(AsmHexCode code, string bits)
        {
            Code = code;
            Bits = bits;
        }

        public ReadOnlySpan<char> Chars
        {
            [MethodImpl(Inline)]
            get => Bits;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Bits;

        public override string ToString()
            => Format();
    }
}
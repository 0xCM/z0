//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct EscapePrefix
    {
        public Hex8 Code {get;}

        [MethodImpl(Inline)]
        public EscapePrefix(Hex8 code)
            => Code = code;

        [MethodImpl(Inline)]
        public static implicit operator EscapePrefix(Hex8 src)
            => new EscapePrefix(src);
    }
}
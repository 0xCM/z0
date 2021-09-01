//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct AsmAddressWidth
    {
        public AsmWidthCode Width {get;}

        [MethodImpl(Inline)]
        public AsmAddressWidth(AsmWidthCode code)
        {
            Width = code;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmAddressWidth(AsmWidthCode code)
            => new AsmAddressWidth(code);
    }
}
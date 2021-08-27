//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct AsmAddressWidth
    {
        const AsmWidthCode Min = AsmWidthCode.W16;

        const AsmWidthCode Max = AsmWidthCode.W64;

        public AsmWidthCode Width {get;}

        [MethodImpl(Inline)]
        public AsmAddressWidth(AsmWidthCode code)
        {
            Width = code;
            //Width =  emath.between(code,Min,Max) ? (byte)asm.width(code) : z8;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmAddressWidth(AsmWidthCode code)
            => new AsmAddressWidth(code);
    }
}
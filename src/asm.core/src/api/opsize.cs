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

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static AsmOperandSize opsize(bit w, bit opsz, bit adsz)
            => skip(OperandSizeLookup,BitNumbers.join(w, opsz, adsz));

        [MethodImpl(Inline), Op]
        public static AsmOperandSize opsize(bit w, SizeOverrides sizes)
            => opsize(w, sizes.OperandOverride, sizes.AddressOverride);
    }
}
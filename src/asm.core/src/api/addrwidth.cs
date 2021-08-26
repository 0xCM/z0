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
        // [MethodImpl(Inline), Op]
        // public static AsmAddressWidth addrwidth(bit w, bit opsz, bit adsz)
        // {
        //     var index = BitNumbers.join(w, opsz, adsz);
        //     return new AsmAddressWidth(skip(AddressSizes, index));
        // }

        // [MethodImpl(Inline), Op]
        // public static AsmAddressWidth addrwidth(bit w, SizeOverrides sizes)
        //     => addrwidth(w, sizes.OperandOverride, sizes.AddressOverride);
    }
}
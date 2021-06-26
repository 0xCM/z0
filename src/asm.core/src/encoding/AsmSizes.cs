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

    [ApiHost]
    public readonly struct AsmSizes
    {
        [MethodImpl(Inline), Op]
        public static AsmOperandSize operand(bit w, bit opsz, bit adsz)
        {
            var index = BitNumbers.join(w, opsz, adsz);
            return skip(OperandSizeLookup,index);
        }

        [MethodImpl(Inline), Op]
        public static AsmOperandSize operand(bit w, SizeOverrides sizes)
            => operand(w, sizes.OperandOverride, sizes.AddressOverride);

        [MethodImpl(Inline), Op]
        public static AsmAddressSize address(bit w, bit opsz, bit adsz)
        {
            var index = BitNumbers.join(w, opsz, adsz);
            return skip(AddressSizeLookup,index);
        }

        [MethodImpl(Inline), Op]
        public static AsmAddressSize address(bit w, SizeOverrides sizes)
            => address(w,sizes.OperandOverride,sizes.AddressOverride);

        static ReadOnlySpan<byte> OperandSizeLookup => new byte[8]{1,1,0,0,2,2,2,2};

        static ReadOnlySpan<byte> AddressSizeLookup => new byte[8]{2,1,2,1,2,1,2,1};
    }
}
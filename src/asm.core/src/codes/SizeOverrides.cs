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

    partial struct AsmCodes
    {
        public readonly struct SizeOverrides
        {
            [MethodImpl(Inline)]
            public static SizeOverrides define(bit opsz, bit adsz)
                => new SizeOverrides(opsz,adsz);

            readonly byte Code;

            [MethodImpl(Inline)]
            public SizeOverrides(bit opsz, bit adsz)
            {
                Code = (byte)((uint)opsz | ((uint)adsz) << 1);
            }

            public uint2 Join
            {
                [MethodImpl(Inline)]
                get => (uint2)((uint)OperandOverride | ((uint)AddressOverride) >> 1);
            }

            public bit OperandOverride
            {
                [MethodImpl(Inline)]
                get => Code;
            }

            public bit AddressOverride
            {
                [MethodImpl(Inline)]
                get => (bit)((uint)Code >> 1);
            }

            public ushort Sequence
            {
                [MethodImpl(Inline)]
                get => (ushort)((ushort)OperandOverride | (((ushort)AddressOverride) << 8));
            }

            [MethodImpl(Inline)]
            public ReadOnlySpan<SizeOverride> Parts()
                => slice(_Parts,Join, 2);

            static ReadOnlySpan<SizeOverride> _Parts => new SizeOverride[]{
                SizeOverride.None, SizeOverride.None,
                SizeOverride.None, SizeOverride.ADSZ,
                SizeOverride.OPSZ, SizeOverride.None,
                SizeOverride.OPSZ, SizeOverride.ADSZ,
                };
        }
    }
}
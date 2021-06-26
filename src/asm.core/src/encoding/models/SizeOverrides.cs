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
    using static AsmCodes;

    public readonly struct SizeOverrides
    {
        readonly byte Code;

        [MethodImpl(Inline)]
        public SizeOverrides(bit opsz, bit adsz)
        {
            Code = (byte)((uint)opsz | ((uint)adsz) << 1);
        }

        public byte Join
        {
            [MethodImpl(Inline)]
            get => (byte)((uint)OperandOverride | ((uint)AddressOverride) >> 1);
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
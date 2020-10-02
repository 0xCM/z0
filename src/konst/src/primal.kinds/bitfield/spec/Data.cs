//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct PrimalBitFieldSpec
    {
        public const byte TotalWidth = (byte)SegWidth.KindId + (byte)SegWidth.Width + (byte)SegWidth.Sign;

        public const byte SegCount = 3;

        public static ReadOnlySpan<SegId> Identity
        {
            [MethodImpl(Inline)]
            get => recover<SegId>(IdentityData);
        }

        public static ReadOnlySpan<SegPos> Positions
        {
            [MethodImpl(Inline)]
            get => recover<SegPos>(PositionData);
        }

        public static ReadOnlySpan<SegWidth> Widths
        {
            [MethodImpl(Inline), Op]
            get => recover<SegWidth>(WidthData);
        }

        public static ReadOnlySpan<SegMask> Masks
        {
            [MethodImpl(Inline)]
            get => recover<SegMask>(MaskData);
        }

        static ReadOnlySpan<byte> MaskData
            => new byte[SegCount]{(byte)SegMask.Size, (byte)SegMask.KindId, (byte)SegMask.Sign};

        static ReadOnlySpan<byte> PositionData
            => new byte[SegCount]{(byte)SegPos.Width, (byte)SegPos.KindId, (byte)SegPos.Sign};

        static ReadOnlySpan<byte> IdentityData
            => new byte[SegCount]{(byte)SegId.Width, (byte)SegId.KindId, (byte)SegId.Sign};

        static ReadOnlySpan<byte> WidthData
            => new byte[SegCount]{(byte)SegWidth.Width, (byte)SegWidth.KindId, (byte)SegWidth.Sign};
    }
}
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

    [ApiDataType]
    public readonly struct PrimalBitFieldSpec
    {
        public const byte TotalWidth = (byte)SegWidth.KindId + (byte)SegWidth.Width + (byte)SegWidth.Sign;

        public const byte SegCount = 3;

        /// <summary>
        /// Defines positional identifiers for each bitfield segment
        /// </summary>
        public enum SegId : byte
        {
            /// <summary>
            /// Identifies the bitfield segment that specifies a primitive width
            /// </summary>
            Width = 0,

            /// <summary>
            /// Identifies the bitfield segment that specifies a primitive kind identifier
            /// </summary>
            KindId = 1,

            /// <summary>
            /// Identifies the bitfield segment that specifies a primitive sign classifier
            /// </summary>
            Sign = 2,
        }

        /// <summary>
        /// Defines integers that correspond to the position of the first bit of each bitfield segment
        /// that implies the following segmentation: [s kkkk www] where s denotes the sign bit, k denotes
        /// a kind identity bit and w denotes a width bit expressed in log2-form
        /// </summary>
        public enum SegPos : byte
        {
            /// <summary>
            /// The starting index of the width field
            /// </summary>
            Width = 0,

            /// <summary>
            /// The starting index of the id field
            /// </summary>
            KindId = 3,

            /// <summary>
            /// The index of the sign flag
            /// </summary>
            Sign= 7,
        }

        /// <summary>
        /// Defines the widths of the primal kind bitfield segments
        /// </summary>
        public enum SegWidth : byte
        {
            /// <summary>
            /// The bit-width of the Size segment
            /// </summary>
            Width = 3,

            /// <summary>
            /// The bit-width of the KindId segment
            /// </summary>
            KindId = 4,

            /// <summary>
            /// The bit-width of the Sign segment
            /// </summary>
            Sign = 1,
        }

        public enum SegMask : byte
        {
            /// <summary>
            /// The Size field mask
            /// </summary>
            [BinaryLiteral("0b0_0000_111")]
            Size = 0b0_0000_111,

            /// <summary>
            /// The KindId field mask
            /// </summary>
            [BinaryLiteral("0b0_1111_000")]
            KindId = 0b0_1111_000,

            /// <summary>
            /// The Sign field mask
            /// </summary>
            [BinaryLiteral("0b1_0000_000")]
            Sign = 0b1_0000_000,
        }

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
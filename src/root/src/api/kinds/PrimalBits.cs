//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using W = PrimalBits.SegWidth;
    using M = PrimalBits.SegMask;
    using P = PrimalBits.SegPos;
    using I = PrimalBits.Field;

    public readonly struct PrimalBits
    {
        /// <summary>
        /// Defines positional identifiers for each bitfield segment
        /// </summary>
        public enum Field : byte
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

        public enum SegMask : byte
        {
            /// <summary>
            /// The Size field mask
            /// </summary>
            Size = 0b0_0000_111,

            /// <summary>
            /// The KindId field mask
            /// </summary>
            KindId = 0b0_1111_000,

            /// <summary>
            /// The Sign field mask
            /// </summary>
            Sign = 0b1_0000_000,
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

        /// <summary>
        /// The bitfield segment count
        /// </summary>
        public const byte SegCount = 3;

        /// <summary>
        /// The total bitfield width
        /// </summary>
        public const byte TotalWidth = (byte)W.KindId + (byte)W.Width + (byte)W.Sign;

        /// <summary>
        /// The defined fields
        /// </summary>
        public static ReadOnlySpan<I> Fields
            => new I[SegCount]{I.Width, I.KindId, I.Sign};

        /// <summary>
        /// Segment mask filters
        /// </summary>
        public static ReadOnlySpan<M> Masks
            => new M[SegCount]{M.Size, M.KindId, M.Sign};

        /// <summary>
        /// The segment starting positions
        /// </summary>
        public static ReadOnlySpan<P> Positions
            => new P[SegCount]{P.Width, P.KindId, P.Sign};

        /// <summary>
        /// Segment widths
        /// </summary>
        public static ReadOnlySpan<W> Widths
            => new W[SegCount]{W.Width, W.KindId, W.Sign};
    }
}
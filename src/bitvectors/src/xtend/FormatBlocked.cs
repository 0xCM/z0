//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XTend
    {
        public static string FormatBlocked<T>(this BitVector<T> src, int width)
            where T : unmanaged
                => FormatBits.blocked(src.Scalar, width);

        public static string FormatBlocked(this BitVector8 src, int width)
            => FormatBits.blocked(src.Scalar, width);

        public static string FormatBlocked(this BitVector16 src, int width)
            => FormatBits.blocked(src.Scalar, width);

        public static string FormatBlocked(this BitVector32 src, int width)
            => FormatBits.blocked(src.Scalar, width);

        public static string FormatBlocked(this BitVector64 src, int width)
            => FormatBits.blocked(src.Scalar, width);

        public static string FormatBlocked<T>(this BitVector<T> src, BitFormatConfig config)
            where T : unmanaged
                => FormatBits.blocked(src.Scalar, config);

        public static string FormatBlocked(this BitVector8 src, BitFormatConfig config)
            => FormatBits.blocked(src.Scalar, config);

        public static string FormatBlocked(this BitVector16 src, BitFormatConfig config)
            => FormatBits.blocked(src.Scalar, config);

        public static string FormatBlocked(this BitVector32 src, BitFormatConfig config)
            => FormatBits.blocked(src.Scalar, config);

        public static string FormatBlocked(this BitVector64 src, BitFormatConfig config)
            => FormatBits.blocked(src.Scalar, config);
    }
}
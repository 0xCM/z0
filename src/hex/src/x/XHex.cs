//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiHost]
    public static partial class XHex
    {
        const NumericKind Closure = NumericKind.UnsignedInts;
    }


    public static partial class XTend
    {
        const NumericKind Closure = NumericKind.UnsignedInts;

        public static string FormatBits(this Hex8 src, N8 n)
            => BitRender.format8(src);

        public static string FormatBits(this Hex8 src, N4 n)
            => BitRender.format8x4(src);

        public static string FormatBits(this Hex16 src, N8 n)
            => BitRender.format16x8(src);

        public static string FormatBits(this Hex32 src, N8 n)
            => BitRender.format32x8(src);

        public static string FormatBits(this Hex64 src, N8 n)
            => BitRender.format64x8(src);
    }
}

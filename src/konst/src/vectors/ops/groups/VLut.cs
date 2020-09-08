//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    [ApiHost]
    public class VLut
    {
        [MethodImpl(Inline), Init]
        public static VLut16 init(Vector128<byte> src)
            => VLut16.Define(src);

        [MethodImpl(Inline), Init]
        public static VLut16 init(ReadOnlySpan<byte> src, N16 n)
            => VLut16.Define(src);

        [MethodImpl(Inline), Init]
        public static VLut16 init(in SpanBlock128<byte> src)
            => VLut16.Define(src);

        [MethodImpl(Inline), Init]
        public static VLut32 init(Vector256<byte> src)
            => VLut32.define(src);

        [MethodImpl(Inline), Init]
        public static VLut32 init(ReadOnlySpan<byte> src, N32 n)
            => VLut32.define(src);

        [MethodImpl(Inline), Init]
        public static VLut32 init(in SpanBlock256<byte> src)
            => VLut32.define(src);

        [MethodImpl(Inline), Op]
        public static Vector128<byte> select(in VLut16 lut, Vector128<byte> items)
            => z.vshuf16x8(items, lut.Mask);

        [MethodImpl(Inline), Op]
        public static Vector256<byte> select(in VLut32 lut, Vector256<byte> items)
            => z.vshuf32x8(items, lut.Mask);
    }
}
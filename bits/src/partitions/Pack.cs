//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
    using Z0;
 
    using static zfunc;
    using static Bits;

    partial class BitParts
    {            
        [MethodImpl(Inline)]
        public static void unpack8x1(uint src, Span<byte> dst)
            => Part64.unpack8x1(src, ref head64(dst));

        [MethodImpl(Inline)]
        public static void pack16x1(ReadOnlySpan<byte> src, Span<byte> dst)
            => Part64.pack16x1(in head(src), ref head64(dst));

        [MethodImpl(Inline)]
        public static void unpack16x1(uint src, Span<byte> dst)
            => Part64.unpack16x1(src, ref head64(dst));        

        [MethodImpl(Inline)]
        public static void pack32x1(ReadOnlySpan<byte> src, Span<byte> dst)
            => Part64.pack32x1(in head(src), ref head64(dst));

        [MethodImpl(Inline)]
        public static void unpack32x1(uint src, Span<byte> dst)
            => Part64.unpack32x1(src, ref head64(dst));

        [MethodImpl(Inline)]
        public static void pack64x1(ReadOnlySpan<byte> src, Span<byte> dst)
            => Part64.pack64x1(in head(src), ref head64(dst));

        [MethodImpl(Inline)]
        public static void unpack64x1(ulong src, Span<byte> dst)
            => Part64.unpack64x1(src, ref head64(dst));

    }
}
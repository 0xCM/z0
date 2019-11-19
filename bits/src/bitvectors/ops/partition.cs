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
    using static BitParts;

    partial class BitVector
    {
        [MethodImpl(Inline)]
        public static Span<BitVector4> partition(BitVector16 src, Span<BitVector4> dst)
        {
            BitParts.part16x4(src, bytes(dst));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<BitVector8> partition(BitVector16 src, Span<BitVector8> dst)
        {
            BitParts.part16x8(src, bytes(dst));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<BitVector4> partition(BitVector32 src, Span<BitVector4> dst)
        {
            BitParts.part32x4(src, bytes(dst));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<BitVector8> partition(BitVector32 src, Span<BitVector8> dst)
        {
            BitParts.part32x8(src, bytes(dst));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<BitVector16> partition(BitVector32 src, Span<BitVector16> dst)
        {
            BitParts.part32x16(src,dst.AsUInt16());
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<BitVector8> partition(BitVector64 src, Span<BitVector8> dst)
        {            
            BitParts.part64x8(src, bytes(dst));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<BitVector32> partition(in BitVector128 src, Span<BitVector32> dst)
        {            
            ref var target = ref head(dst.AsUInt32());
            BitParts.part64x32(src.x0, ref target);
            BitParts.part64x32(src.x1, ref seek(ref target,2));
            return dst;
        }

    }
}
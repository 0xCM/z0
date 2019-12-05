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

    partial class BitVector
    {
        [MethodImpl(Inline)]
        public static Span<BitVector4> partition(BitVector16 src, Span<BitVector4> dst)
        {
            Bits.part16x4(src, bytes(dst));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<BitVector8> partition(BitVector16 src, Span<BitVector8> dst)
        {
            Bits.part16x8(src, bytes(dst));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<BitVector4> partition(BitVector32 src, Span<BitVector4> dst)
        {
            Bits.part32x4(src, bytes(dst));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<BitVector8> partition(BitVector32 src, Span<BitVector8> dst)
        {
            Bits.part32x8(src, bytes(dst));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<BitVector16> partition(BitVector32 src, Span<BitVector16> dst)
        {
            Bits.part32x16(src,dst.AsUInt16());
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<BitVector8> partition(BitVector64 src, Span<BitVector8> dst)
        {            
            Bits.part64x8(src, bytes(dst));
            return dst;
        }
    }
}
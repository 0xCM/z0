//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    using static zfunc;

    public static class BitRot
    {
        public static Span<byte> rotr(ReadOnlySpan<byte> src, int shift, Span<byte> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = Bits.rotr(src[i], shift);                            
            return dst;
        }

        public static Span<ushort> rotr(ReadOnlySpan<ushort> src, int shift, Span<ushort> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = Bits.rotr(src[i], shift);                            
            return dst;
        }

        public static Span<uint> rotr(ReadOnlySpan<uint> src, int shift, Span<uint> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = Bits.rotr(src[i], shift);                            
            return dst;
        }

        public static Span<ulong> rotr(ReadOnlySpan<ulong> src, int shift, Span<ulong> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = Bits.rotr(src[i], shift);                            
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<byte> rotr(ReadOnlySpan<byte> src, int shift)
            => rotr(src,shift,src.Replicate(true));

        [MethodImpl(Inline)]
        public static Span<ushort> rotr(ReadOnlySpan<ushort> src, int shift)
            => rotr(src,shift,src.Replicate(true));

        [MethodImpl(Inline)]
        public static Span<uint> rotr(ReadOnlySpan<uint> src, int shift)
            => rotr(src,shift,src.Replicate(true));

        [MethodImpl(Inline)]
        public static Span<ulong> rotr(ReadOnlySpan<ulong> src, int shift)
            => rotr(src,shift,src.Replicate(true));

        public static Span<byte> rotl(ReadOnlySpan<byte> src, int shift, Span<byte> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = Bits.rotl(src[i], shift);                            
            return dst;
        }

        public static Span<ushort> rotl(ReadOnlySpan<ushort> src, int shift, Span<ushort> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = Bits.rotl(src[i], shift);                            
            return dst;
        }

        public static Span<uint> rotl(ReadOnlySpan<uint> src, int shift, Span<uint> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = Bits.rotl(src[i], shift);                            
            return dst;
        }

        public static Span<ulong> rotl(ReadOnlySpan<ulong> src, int shift, Span<ulong> dst)
        {
            for(var i=0; i<src.Length; i++)
                dst[i] = Bits.rotl(src[i], shift);                            
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<byte> rotl(ReadOnlySpan<byte> src, int shift)
            => rotl(src,shift,src.Replicate(true));

        [MethodImpl(Inline)]
        public static Span<ushort>  rotl(ReadOnlySpan<ushort> src, int shift)
            => rotl(src,shift,src.Replicate(true));

        [MethodImpl(Inline)]
        public static Span<uint>  rotl(ReadOnlySpan<uint> src, int shift)
            => rotl(src,shift,src.Replicate(true));

        [MethodImpl(Inline)]
        public static Span<ulong>  rotl(ReadOnlySpan<ulong> src, int shift)
            => rotl(src,shift,src.Replicate(true));
 
    }



}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    
    partial class ginxs
    {
        [MethodImpl(Inline)]
        public static void unpackbits<T>(byte src, in Block64<T> dst, int block = 0)
            where T : unmanaged
        {
            var m = BitMask.lsb<ulong>(n8);
            ref var target = ref dst.BlockRef(block);
            seek64(ref target, 0) = dinx.scatter((ulong)(byte)src, m);
        }

        [MethodImpl(Inline)]
        public static void unpackbits<T>(ushort src, in Block128<T> dst, int block = 0)
            where T : unmanaged
        {
            var m = BitMask.lsb<ulong>(n8);
            ref var target = ref dst.BlockRef(block);
            seek64(ref target, 0) = dinx.scatter((ulong)(byte)src, m);
            seek64(ref target, 1) = dinx.scatter((ulong)((byte)(src >> 8)), m);
        }

        [MethodImpl(Inline)]
        public static void unpackbits<T>(uint src, in Block256<T> dst, int block = 0)
            where T : unmanaged
        {
            var m = BitMask.lsb<ulong>(n8);
            ref var target = ref dst.BlockRef(block);
            seek64(ref target, 0) = dinx.scatter((ulong)(byte)src, m);
            seek64(ref target, 1) = dinx.scatter((ulong)((byte)(src >> 8)), m);
            seek64(ref target, 2) = dinx.scatter((ulong)((byte)(src >> 16)), m);
            seek64(ref target, 3) = dinx.scatter((ulong)((byte)(src >> 24)), m);
        }

        [MethodImpl(Inline)]
        public static void unpackbits<T>(ulong src, in Block256<T> lo, in Block256<T> hi, int block = 0)
            where T : unmanaged
        {
            unpackbits((uint)src, lo);
            unpackbits((uint)(src >> 32), hi);
        }

    }

}
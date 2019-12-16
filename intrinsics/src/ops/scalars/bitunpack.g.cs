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
        /// <summary>
        /// Distributes 8 source bit values to the least significant bit of 8 target bytes
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void unpackbits<T>(byte src, in Block64<T> dst, int block = 0)
            where T : unmanaged
        {
            var m = BitMask.lsb<ulong>(n8);
            ref var target = ref dst.BlockRef(block);
            seek64(ref target, 0) = dinx.scatter((ulong)(byte)src, m);
        }

        /// <summary>
        /// Distributes 16 source bit values to the least significant bit of 16 target bytes
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void unpackbits<T>(ushort src, in Block128<T> dst, int block = 0)
            where T : unmanaged
        {
            var m = BitMask.lsb<ulong>(n8);
            ref var target = ref dst.BlockRef(block);
            seek64(ref target, 0) = dinx.scatter((ulong)(byte)src, m);
            seek64(ref target, 1) = dinx.scatter((ulong)((byte)(src >> 8)), m);
        }

        /// <summary>
        /// Distributes 32 source bit values to the least significant bit of 32 target bytes
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The cell type</typeparam>
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

        /// <summary>
        /// Unpacks the lo 32 source bits into the first block and the hi 32 source bits into the second
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="dst">The blocked target</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void unpackbits<T>(ulong src, in Block256<T> dst)
            where T : unmanaged
        {
            unpackbits((uint)src,dst,0);
            unpackbits((uint)(src >> 32),dst,1);
        }
    }
}
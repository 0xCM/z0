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
        public static void unpackbits<S,T>(S src, in Block64<T> dst, int block = 0)
            where S : unmanaged
            where T : unmanaged
                => unpackbits(convert<S,byte>(src), dst.Block(block));

        /// <summary>
        /// Distributes 16 source bit values to the least significant bit of 16 target bytes
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void unpackbits<S,T>(S src, in Block128<T> dst, int block = 0)
            where S : unmanaged
            where T : unmanaged
                => unpackbits(convert<S,ushort>(src), dst.Block(block));

        /// <summary>
        /// Distributes 32 source bit values to the least significant bit of 32 target bytes
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void unpackbits<S,T>(S src, in Block256<T> dst, int block = 0)
            where S : unmanaged
            where T : unmanaged
                => unpackbits(convert<S,uint>(src), dst.Block(block));

        /// <summary>
        /// Distributes 64 source bit values to the least significant bit of 64 target bytes
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static void unpackbits<S,T>(S src, in Block512<T> dst, int block = 0)        
            where S : unmanaged
            where T : unmanaged
                => unpackbits(convert<S,ulong>(src), dst.Block(block));

        [MethodImpl(Inline)]
        static void unpackbits<T>(byte src, Span<T> dst)
            where T : unmanaged
        {
            var m = BitMask.lsb<ulong>(n8);
            ref var target = ref head(dst);
            seek64(ref target, 0) = dinx.scatter((ulong)(byte)src, m);
        }

        [MethodImpl(Inline)]
        static void unpackbits<T>(ushort src, Span<T> dst)
            where T : unmanaged
        {
            var m = BitMask.lsb<ulong>(n8);
            ref var target = ref head(dst);
            seek64(ref target, 0) = dinx.scatter((ulong)(byte)src, m);
            seek64(ref target, 1) = dinx.scatter((ulong)((byte)(src >> 8)), m);
        }

        [MethodImpl(Inline)]
        static void unpackbits<T>(uint src, Span<T> dst)
            where T : unmanaged
        {
            var m = BitMask.lsb<ulong>(n8);
            ref var target = ref head(dst);
            seek64(ref target, 0) = dinx.scatter((ulong)(byte)src, m);
            seek64(ref target, 1) = dinx.scatter((ulong)((byte)(src >> 8)), m);
            seek64(ref target, 2) = dinx.scatter((ulong)((byte)(src >> 16)), m);
            seek64(ref target, 3) = dinx.scatter((ulong)((byte)(src >> 24)), m);
        }

        [MethodImpl(Inline)]
        public static void unpackbits<T>(ulong src, Span<T> dst)        
            where T : unmanaged
        {
            unpackbits((uint)src, dst.Slice(0,32));
            unpackbits((uint)(src >> 32), dst.Slice(32,32));
        }

    }
}
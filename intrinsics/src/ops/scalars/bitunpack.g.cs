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
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block64<byte> unpackbits<T>(T src, in Block64<byte> dst, int block = 0)
            where T : unmanaged
        {
            unpackbits(convert<T,byte>(src), dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Distributes 16 source bit values to the least significant bit of 16 target bytes
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block128<byte> unpackbits<T>(T src, in Block128<byte> dst, int block = 0)
            where T : unmanaged
        {
            unpackbits(convert<T,ushort>(src), dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Distributes 32 source bit values to the least significant bit of 32 target bytes
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block256<byte> unpackbits<T>(T src, in Block256<byte> dst, int block = 0)
            where T : unmanaged
        {                
            unpackbits(convert<T,uint>(src), dst.Block(block));
            return ref dst;
        }

        /// <summary>
        /// Distributes 64 source bit values to the least significant bit of 64 target bytes
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block512<byte> unpackbits<T>(T src, in Block512<byte> dst, int block = 0)        
            where T : unmanaged
        {
            unpackbits(convert<T,ulong>(src), dst.Block(block));
            return ref dst;
        }

        [MethodImpl(Inline)]
        static void unpackbits(byte src, Span<byte> dst)
        {
            var m = BitMask.lsb<ulong>(n8);
            ref var target = ref head(dst);
            seek64(ref target, 0) = dinx.scatter((ulong)(byte)src, m);
        }

        [MethodImpl(Inline)]
        static void unpackbits(ushort src, Span<byte> dst)
        {
            var m = BitMask.lsb<ulong>(n8);
            ref var target = ref head(dst);
            seek64(ref target, 0) = dinx.scatter((ulong)(byte)src, m);
            seek64(ref target, 1) = dinx.scatter((ulong)((byte)(src >> 8)), m);
        }

        [MethodImpl(Inline)]
        static void unpackbits(uint src, Span<byte> dst)
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

        public static BitSpan ToBitSpan(this byte src)
        {
            var buffer = DataBlocks.single(n64,z8);
            var target = DataBlocks.single(n256,z32);
            ginxs.unpackbits(src,buffer); 
            dinx.vloadblock(buffer,n256).StoreTo(target);
            return BitSpan.load(target.As<bit>());
        }

        // public static BitSpan ToBitSpan(this ulong src)
        // {
        //     const int blocks = 4;
        //     var buffer = DataBlocks.single(n512, z8);
        //     var target = DataBlocks.alloc(n256, blocks, z32);
        //     ginxs.unpackbits(src, buffer);
        //     for(var block=0; block<blocks; block++)
        //     {
        //         dinx.vloadblock(buffer,n256);
        //     }

        // }
    }
}
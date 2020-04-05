//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Blocks    
    {
        [MethodImpl(Inline)]
        static void store<S,T>(in S src, ref T dst)
            where S : unmanaged
            where T : unmanaged
                => Unsafe.As<T, S>(ref dst) = src;

        /// <summary>
        /// Stores the source value to the leading target cell blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Block64<byte> store(ulong src, in Block64<byte> dst)
        {         
            store(in src, ref dst.Head);
            return ref dst;
        }

        /// <summary>
        /// Stores the source value to the leading target cell blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Block32<byte> store(ulong src, in Block32<byte> dst)
        {         
            store(in src, ref dst.Head);
            return ref dst;
        }

        /// <summary>
        /// Stores the source value to the leading target cell blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Block16<byte> store(ulong src, in Block16<byte> dst)
        {         
            store(in src, ref dst.Head);
            return ref dst;
        }

        /// <summary>
        /// Stores the source value to the leading target cell blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Block64<ushort> store(ulong src, in Block64<ushort> dst)
        {         
            store(in src, ref dst.Head);
            return ref dst;
        }

        /// <summary>
        /// Stores the source value to the leading target cell blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Block64<uint> store(ulong src, in Block64<uint> dst)
        {         
            store(in src, ref dst.Head);
            return ref dst;
        }

        /// <summary>
        /// Stores the source value to the leading target cell blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Block32<byte> store(uint src, in Block32<byte> dst)
        {         
            store(in src, ref dst.Head);
            return ref dst;
        }

        /// <summary>
        /// Stores the source value to the leading target cell blocks
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Block16<byte> store(ushort src, in Block16<byte> dst)
        {
            store(in src, ref dst.Head);
            return ref dst;
        }

        /// <summary>
        /// Writes a specified number of bytes to a block beginning at a byte-relative offset
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        /// <param name="offset">The absolute number of bytes, measured from the head of the data structure, to skip</param>
        /// <param name="count">The number of to copy from the source into the target</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline), Store, Closures(Numeric32u)]
        public static void store<T>(in byte src, in Block256<T> dst, int offset, int count)
            where T : unmanaged        
        {            
            ref var target = ref Unsafe.Add(ref Unsafe.As<T,byte>(ref dst.Head), offset);            
            Unsafe.CopyBlock(ref target, ref Unsafe.AsRef(in src), (uint)count);
        }

        /// <summary>
        /// Writes a specified number of bytes to a block beginning at a byte-relative offset
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target block</param>
        /// <param name="offset">The absolute number of bytes, measured from the head of the data structure, to skip</param>
        /// <param name="count">The number of to copy from the source into the target</param>
        /// <typeparam name="T">The block cell type</typeparam>
        [MethodImpl(Inline), Store, Closures(Numeric32u)]
        public static void store<T>(in byte src, in Block512<T> dst, int offset, int count)
            where T : unmanaged        
        {            
            ref var target = ref Unsafe.Add(ref Unsafe.As<T,byte>(ref dst.Head), offset);            
            Unsafe.CopyBlock(ref target, ref Unsafe.AsRef(in src), (uint)count);
        }

    }
}
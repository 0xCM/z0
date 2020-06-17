//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
        
    using static Konst;

    [ApiHost]
    public readonly struct Seeker : IApiHost<Seeker>
    {
        /// <summary>
        /// Adds an offset to a reference, measured relative to the reference type
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="bytes">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T seek<T>(ref T src, int count)
            => ref Unsafe.Add(ref src, count);

        /// <summary>
        /// Interprets a generic element source as a uint8 element source and skips {count} elments of bit-width 8
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 8-bit elements to skip</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref byte seek8<T>(ref T src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,byte>(ref src), count);

        /// <summary>
        /// Interprets a generic element source as a uint16 element source and skips {count} elments of bit-width 16
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 16-bit elements to skip</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ushort seek16<T>(ref T src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,ushort>(ref src), count);

        /// <summary>
        /// Interprets a generic element source as a uint32 element source and skips {count} elments of bit-width 32
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 32-bit elements to skip</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref uint seek32<T>(ref T src, int count)
            => ref Unsafe.Add(ref Unsafe.As<T,uint>(ref src), count);

        /// <summary>
        /// Interprets a generic element source as a uint64 element source and skips {count} elments of bit-width 64
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 64-bit elements to skip</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ulong seek64<T>(ref T src, int count)        
            => ref Unsafe.Add(ref Unsafe.As<T,ulong>(ref src), count);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T seek<T>(ref T src, IntPtr offset)
            => ref Unsafe.Add(ref src, offset);

        /// <summary>
        /// Adds an offset to a reference, measured in bytes
        /// </summary>
        /// <param name="src">The soruce reference</param>
        /// <param name="count">The number of bytes to add</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T seekb<T>(ref T src, long count)
            => ref Unsafe.AddByteOffset(ref src, Pointed.intptr(count));
    }
}
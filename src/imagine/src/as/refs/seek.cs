//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;
    
    partial struct As
    {         
        /// <summary>
        /// Adds a T-counted offset to a T-reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T seek<T>(in T src, byte count)
            => ref Add(ref edit(src), (int)count);

        /// <summary>
        /// Adds a T-counted offset to a T-reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T seek<T>(in T src, ushort count)
            => ref Add(ref edit(src), (int)count);

        /// <summary>
        /// Adds a T-counted offset to a T-reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T seek<T>(in T src, uint count)
            => ref Add(ref edit(src), (int)count);

        /// <summary>
        /// Adds a T-counted offset to a T-reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of elements to advance</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T seek<T>(in T src, int count)
            => ref Add(ref edit(src), count);

        /// <summary>
        /// Skips a specified number of 8-bit source segments and returns a reference to the located cell
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 8-bit segments to skip</param>
        /// <typeparam name="T">The (arbitrary) source type</typeparam>
        [MethodImpl(Inline)]
        public static ref byte seek8<T>(ref T src, int count)
            => ref Add(ref As<T,byte>(ref src), count);

        /// <summary>
        /// Skips a specified number of 16-bit source segments and returns a reference to the located cell
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 16-bit segments to skip</param>
        /// <typeparam name="T">The (arbitrary) source type</typeparam>
        [MethodImpl(Inline)]
        public static ref ushort seek16<T>(ref T src, int count)
            => ref Add(ref As<T,ushort>(ref src), count);

        /// <summary>
        /// Interprets a generic element source as a uint32 element source and skips {count} elments of bit-width 32
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 32-bit segments to skip</param>
        /// <typeparam name="T">The (arbitrary) source type</typeparam>
        [MethodImpl(Inline)]
        public static ref uint seek32<T>(ref T src, int count)
            => ref Add(ref As<T,uint>(ref src), count);

        /// <summary>
        /// Interprets a generic element source as a uint64 element source and skips {count} elments of bit-width 64
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 64-bit segments to skip</param>
        /// <typeparam name="T">The (arbitrary) source type</typeparam>
        [MethodImpl(Inline)]
        public static ref ulong seek64<T>(ref T src, int count)
            => ref Add(ref As<T,ulong>(ref src), count);
    }
}
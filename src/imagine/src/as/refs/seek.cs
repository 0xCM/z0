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
        /// Interprets a generic element source as a uint8 element source and skips {count} elments of bit-width 8
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 8-bit elements to skip</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref byte seekw<T>(W8 w, ref T src, int count)
            => ref Add(ref As<T,byte>(ref src), count);

        /// <summary>
        /// Interprets a generic element source as a uint16 element source and skips {count} elments of bit-width 16
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 16-bit elements to skip</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ushort seekw<T>(W16 w, ref T src, int count)
            => ref Add(ref As<T,ushort>(ref src), count);

        /// <summary>
        /// Interprets a generic element source as a uint32 element source and skips {count} elments of bit-width 32
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 32-bit elements to skip</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref uint seekw<T>(W32 w, ref T src, int count)
            => ref Add(ref As<T,uint>(ref src), count);

        /// <summary>
        /// Interprets a generic element source as a uint64 element source and skips {count} elments of bit-width 64
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="count">The number of 64-bit elements to skip</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref ulong seekw<T>(W64 w, ref T src, int count)
            => ref Add(ref As<T,ulong>(ref src), count);
    }
}
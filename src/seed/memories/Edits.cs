//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
        
    using static Seed;

    [ApiHost]
    public readonly struct Edits : IApiHost<Edits>
    {
        /// <summary>
        /// Presents a readonly reference as mutable reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref T edit<T>(in T src)
            => ref Unsafe.AsRef(in src);

        /// <summary>
        /// Interprets a generic reference as a uint8 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref byte edit8<T>(ref T src)
            => ref Unsafe.As<T,byte>(ref src);

        /// <summary>
        /// Interprets a generic reference as a uint16 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ushort edit16<T>(ref T src)
            => ref Unsafe.As<T,ushort>(ref src);

        /// <summary>
        /// Interprets a generic reference as a uint32 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref uint edit32<T>(ref T src)
            => ref Unsafe.As<T,uint>(ref src);

        /// <summary>
        /// Interprets a generic reference as a uint64 reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref ulong edit64<T>(ref T src)
            => ref Unsafe.As<T,ulong>(ref src);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Stacked;

    partial class Stacks
    {
        /// <summary>
        /// Deposits a specified number reference-identified bytes to a storage target
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of bytes to copy</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static void store(in byte src, uint count, ref MemStack64 dst)
            => Unsafe.CopyBlockUnaligned(ref head8(ref dst), ref Control.edit(in src), count);

        /// <summary>
        /// Deposits a specified number reference-identified bytes to a storage target
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of bytes to copy</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static void store(in byte src, uint count, ref MemStack128 dst)
            => Unsafe.CopyBlockUnaligned(ref head8(ref dst), ref Control.edit(in src), count);

        /// <summary>
        /// Deposits a specified number reference-identified bytes to a storage target
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of bytes to copy</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static void store(in byte src, uint count, ref MemStack256 dst)
            => Unsafe.CopyBlockUnaligned(ref head8(ref dst), ref Control.edit(in src), count);

        /// <summary>
        /// Deposits a specified number reference-identified bytes to a storage target
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of bytes to copy</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static void store(in byte src, uint count, ref MemStack512 dst)
            => Unsafe.CopyBlockUnaligned(ref head8(ref dst), ref Control.edit(in src), count);

        /// <summary>
        /// Deposits a specified number reference-identified bytes to a storage target
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of bytes to copy</param>
        /// <param name="dst">The storage target</param>
        [MethodImpl(Inline), Op]
        public static void store(in byte src, uint count, ref MemStack1024 dst)
            => Unsafe.CopyBlockUnaligned(ref head8(ref dst), ref Control.edit(in src), count); 
    }
}
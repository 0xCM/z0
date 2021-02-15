//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct PermSymbolic
    {
        /// <summary>
        /// Attempts to extract an index-identified permutation symbol
        /// </summary>
        /// <param name="src">The permutation spec</param>
        /// <param name="index">The symbol index</param>
        /// <param name="dst">The symbol, if successful</param>
        /// <returns>True if symbol was successfully extracted, false otherwise</returns>
        [MethodImpl(Inline), Op]
        public static bool symbol(Perm4L src, int index, out Perm4L dst)
        {
            const byte SegWidth = 2;
            var first = (byte)(index * SegWidth);
            var last = (byte)(first + SegWidth - 1);
            dst = (Perm4L)BitMasks.extract((byte)src, first, last);
            return test(dst);
        }

        /// <summary>
        /// Attempts to extract an index-identified permutation symbol
        /// </summary>
        /// <param name="src">The permutation spec</param>
        /// <param name="index">The symbol index</param>
        /// <param name="dst">The symbol, if successful</param>
        /// <returns>True if symbol was successfully extracted, false otherwise</returns>
        [MethodImpl(Inline), Op]
        public static bool symbol(Perm8L src, int index, out Perm8L dst)
        {
            const byte Segwidth = 3;
            var first = (byte)(index * Segwidth);
            var last = (byte)(first + Segwidth - 1);
            dst = (Perm8L)BitMasks.extract((uint)src, first, last);
            return test(dst);
        }

        /// <summary>
        /// Attempts to extract an index-identified permutation symbol
        /// </summary>
        /// <param name="src">The permutation spec</param>
        /// <param name="index">The symbol index</param>
        /// <param name="dst">The symbol, if successful</param>
        /// <returns>True if symbol was successfully extracted, false otherwise</returns>
        [MethodImpl(Inline), Op]
        public static bool symbol(Perm16L src, int index, out Perm16L dst)
        {
            const byte Segwidth = 4;
            var first = (byte)(index * Segwidth);
            var last = (byte)(first + Segwidth - 1);
            dst = (Perm16L)BitMasks.extract((ulong)src, first, last);
            return test(dst);
        }
    }
}
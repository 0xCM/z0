//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Control;

    partial class Symbolic
    {
        /// <summary>
        /// Attempts to extract an index-identified permutation symbol
        /// </summary>
        /// <param name="src">The permutation spec</param>
        /// <param name="index">The symbol index</param>
        /// <param name="dst">The symbol, if successful</param>
        /// <returns>True if symbol was successfully extracted, false otherwise</returns>
        [MethodImpl(Inline), Op]
        public static bool literal(Perm4L src, int index, out Perm4L dst)
        {
            const int segwidth = 2;             
            var first = (byte)(index * segwidth);
            var last = (byte)(first + segwidth - 1);

            dst = (Perm4L)SymBits.extract((byte)src, first, last);
            return SymTest.IsSymbol(dst);
        }

        /// <summary>
        /// Attempts to extract an index-identified permutation symbol
        /// </summary>
        /// <param name="src">The permutation spec</param>
        /// <param name="index">The symbol index</param>
        /// <param name="dst">The symbol, if successful</param>
        /// <returns>True if symbol was successfully extracted, false otherwise</returns>
        [MethodImpl(Inline), Op]
        public static bool literal(Perm8L src, int index, out Perm8L dst)
        {
            const int segwidth = 3; 
            var first = (byte)(index * segwidth);
            var last = (byte)(first + segwidth - 1);

            dst = (Perm8L)SymBits.extract((uint)src, first, last);
            return SymTest.IsSymbol(dst);
        }

        /// <summary>
        /// Attempts to extract an index-identified permutation symbol
        /// </summary>
        /// <param name="src">The permutation spec</param>
        /// <param name="index">The symbol index</param>
        /// <param name="dst">The symbol, if successful</param>
        /// <returns>True if symbol was successfully extracted, false otherwise</returns>
        [MethodImpl(Inline), Op]
        public static bool literal(Perm16L src, int index, out Perm16L dst)
        {
            const int segwidth = 4;     
            var first = (byte)(index * segwidth);
            var last = (byte)(first + segwidth - 1);

            dst = (Perm16L)SymBits.extract((ulong)src, first, last);
            return SymTest.IsSymbol(dst);
        }        
    }
}
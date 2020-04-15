//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    partial class Permute
    {
        /// <summary>
        /// Attempts to extract an index-identified permutation symbol
        /// </summary>
        /// <param name="src">The permutation spec</param>
        /// <param name="index">The symbol index</param>
        /// <param name="dst">The symbol, if successful</param>
        /// <returns>True if symbol was successfully extracted, false otherwise</returns>
        [MethodImpl(Inline), Op]
        public static bit literal(Perm4L src, int index, out Perm4L dst)
        {
            const int segwidth = 2;             
            var first = (byte)(index * segwidth);
            var last = (byte)(first + segwidth - 1);

            dst = (Perm4L)gbits.between((byte)src, first, last);
            return dst.IsSymbol();
        }

        /// <summary>
        /// Attempts to extract an index-identified permutation symbol
        /// </summary>
        /// <param name="src">The permutation spec</param>
        /// <param name="index">The symbol index</param>
        /// <param name="dst">The symbol, if successful</param>
        /// <returns>True if symbol was successfully extracted, false otherwise</returns>
        [MethodImpl(Inline), Op]
        public static bit literal(Perm8L src, int index, out Perm8L dst)
        {
            const int segwidth = 3; 
            var first = (byte)(index * segwidth);
            var last = (byte)(first + segwidth - 1);

            dst = (Perm8L)gbits.between((uint)src, first, last);
            return dst.IsSymbol();
        }

        /// <summary>
        /// Attempts to extract an index-identified permutation symbol
        /// </summary>
        /// <param name="src">The permutation spec</param>
        /// <param name="index">The symbol index</param>
        /// <param name="dst">The symbol, if successful</param>
        /// <returns>True if symbol was successfully extracted, false otherwise</returns>
        [MethodImpl(Inline), Op]
        public static bit literal(Perm16L src, int index, out Perm16L dst)
        {
            const int segwidth = 4;     
            var first = (byte)(index * segwidth);
            var last = (byte)(first + segwidth - 1);

            dst = (Perm16L)gbits.between((ulong)src, first, last);
            return dst.IsSymbol();
        }

        /// <summary>
        /// Distills a natural permutation on 4 symbols to its canonical literal specification
        /// </summary>
        /// <param name="src">The source permutation</param>
        [MethodImpl(Inline)]
        public static Perm4L literal(NatPerm<N4> src)
        {
            const int segwidth = 2;
            const int length = 4;            

            var dst = 0u;            
            for(int i=0, offset = 0; i< length; i++, offset +=segwidth)
                dst |= (uint)src[i] << offset;                        
            return (Perm4L)dst;
        }

        /// <summary>
        /// Distills a natural permutation on 8 symbols to its canonical literal specification
        /// </summary>
        /// <param name="src">The source permutation</param>
        [MethodImpl(Inline)]
        public static Perm8L literal(NatPerm<N8> src)
        {
            const int segwidth = 3;
            const int length = 8;

            var dst = 0u;          
            for(int i=0, offset = 0; i< length; i++, offset +=segwidth)
                dst |= (uint)src[i] << offset;                        
            return (Perm8L)dst;
        }

        /// <summary>
        /// Distills a natural permutation on 16 symbols to its canonical literal specification
        /// </summary>
        /// <param name="src">The source permutation</param>
        [MethodImpl(Inline)]
        public static Perm16L literal(NatPerm<N16> src)
        {
            const int segwidth = 4;
            const int length = 16;
            
            var dst = 0ul;                        
            for(int i=0, offset = 0; i< length; i++, offset +=segwidth)
                dst |= (ulong)src[i] << offset;                        
            return (Perm16L)dst;
        }
    }
}
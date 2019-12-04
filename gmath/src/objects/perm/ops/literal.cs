//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    partial class Perm
    {

        /// <summary>
        /// Attempts to extract an index-identified permutation symbol
        /// </summary>
        /// <param name="src">The permutation spec</param>
        /// <param name="index">The symbol index</param>
        /// <param name="dst">The symbol, if successful</param>
        /// <returns>True if symbol was successfully extracted, false otherwise</returns>
        [MethodImpl(Inline)]
        public static bit literal(Perm4 src, int index, out Perm4 dst)
        {
            const int segwidth = 2;             
            var first = index * segwidth;
            var last = first + segwidth - 1;

            dst = (Perm4)BitMask.between((byte)src, first, last);
            return dst.IsSymbol();
        }

        /// <summary>
        /// Attempts to extract an index-identified permutation symbol
        /// </summary>
        /// <param name="src">The permutation spec</param>
        /// <param name="index">The symbol index</param>
        /// <param name="dst">The symbol, if successful</param>
        /// <returns>True if symbol was successfully extracted, false otherwise</returns>
        [MethodImpl(Inline)]
        public static bit literal(Perm8 src, int index, out Perm8 dst)
        {
            const int segwidth = 3; 
            var first = index * segwidth;
            var last = first + segwidth - 1;

            dst = (Perm8)BitMask.between((uint)src, first, last);
            return dst.IsSymbol();
        }

        /// <summary>
        /// Attempts to extract an index-identified permutation symbol
        /// </summary>
        /// <param name="src">The permutation spec</param>
        /// <param name="index">The symbol index</param>
        /// <param name="dst">The symbol, if successful</param>
        /// <returns>True if symbol was successfully extracted, false otherwise</returns>
        [MethodImpl(Inline)]
        public static bit literal(Perm16 src, int index, out Perm16 dst)
        {
            const int segwidth = 4;     
            var first = index * segwidth;
            var last = first + segwidth - 1;

            dst = (Perm16)BitMask.between((ulong)src, first, last);
            return dst.IsSymbol();
        }

        /// <summary>
        /// Distills a natural permutation on 4 symbols to its canonical literal specification
        /// </summary>
        /// <param name="src">The source permutation</param>
        public static Perm4 literal(NatPerm<N4> src)
        {
            const int segwidth = 2;
            const int length = 4;            

            var dst = 0u;            
            for(int i=0, offset = 0; i< length; i++, offset +=segwidth)
                dst |= (uint)src[i] << offset;                        
            return (Perm4)dst;
        }

        /// <summary>
        /// Distills a natural permutation on 8 symbols to its canonical literal specification
        /// </summary>
        /// <param name="src">The source permutation</param>
        public static Perm8 literal(NatPerm<N8> src)
        {
            const int segwidth = 3;
            const int length = 8;

            var dst = 0u;          
            for(int i=0, offset = 0; i< length; i++, offset +=segwidth)
                dst |= (uint)src[i] << offset;                        
            return (Perm8)dst;
        }

        /// <summary>
        /// Distills a natural permutation on 16 symbols to its canonical literal specification
        /// </summary>
        /// <param name="src">The source permutation</param>
        public static Perm16 literal(NatPerm<N16> src)
        {
            const int segwidth = 4;
            const int length = 16;
            
            var dst = 0ul;                        
            for(int i=0, offset = 0; i< length; i++, offset +=segwidth)
                dst |= (ulong)src[i] << offset;                        
            return (Perm16)dst;
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
        
    partial class Blocks
    {
        [MethodImpl(Inline)]
        public static int blockcount<T>(W8 w, int cellcount)
            where T : unmanaged
                => cellcount/length<T>(w);

        [MethodImpl(Inline)]
        public static int blockcount<T>(W16 w, int cellcount)
            where T : unmanaged
                => cellcount/length<T>(w);

        [MethodImpl(Inline)]
        public static int blockcount<T>(W32 w, int cellcount)
            where T : unmanaged
                => cellcount/length<T>(w);

        [MethodImpl(Inline)]
        public static int blockcount<T>(W64 w, int cellcount)
            where T : unmanaged
                => cellcount/length<T>(w);

        [MethodImpl(Inline)]
        public static int blockcount<T>(W128 w, int cellcount)
            where T : unmanaged
                => cellcount/length<T>(w);

        [MethodImpl(Inline)]
        public static int blockcount<T>(W256 w, int cellcount)
            where T : unmanaged
                => cellcount/length<T>(w);

        [MethodImpl(Inline)]
        public static int blockcount<T>(W512 w, int cellcount)
            where T : unmanaged
                => cellcount/length<T>(w);

        [MethodImpl(Inline)]
        public static int blockcount<T>(W8 w, int length, out int uncovered)
            where T : unmanaged   
        {       
            uncovered = length % length<T>(w);
            return length/length<T>(w);
        }

        [MethodImpl(Inline)]
        public static int blockcount<T>(W16 w, int length, out int uncovered)
            where T : unmanaged   
        {       
            uncovered = length % length<T>(w);
            return length/length<T>(w);
        }

        [MethodImpl(Inline)]
        public static int blockcount<T>(W32 w, int length, out int uncovered)
            where T : unmanaged   
        {       
            uncovered = length % length<T>(w);
            return length/length<T>(w);
        }

        [MethodImpl(Inline)]
        public static int blockcount<T>(W64 w, int length, out int uncovered)
            where T : unmanaged   
        {       
            uncovered = length % length<T>(w);
            return length/length<T>(w);
        }

        [MethodImpl(Inline)]
        public static int blockcount<T>(W128 w, int length, out int uncovered)
            where T : unmanaged          
        {       
            uncovered = length % length<T>(w);
            return length/length<T>(w);
        }

        [MethodImpl(Inline)]
        public static int blockcount<T>(W256 w, int length, out int uncovered)
            where T : unmanaged          
        {       
            uncovered = length % length<T>(w);
            return length/length<T>(w);
        }

        [MethodImpl(Inline)]
        public static int blockcount<T>(W512 w, int length, out int uncovered)
            where T : unmanaged          
        {       
            uncovered = length % length<T>(w);
            return length/length<T>(w);
        }

        /// <summary>
        /// Computes the minimum number of 256-bit blocks that can hold a table of data
        /// </summary>
        /// <param name="srclen">The length of the source data</param>
        /// <typeparam name="M">The row type </typeparam>
        /// <typeparam name="N">The column type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static int blockcount<M,N,T>(N256 w)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged        
        {
            var srclen = NatMath.mul<M,N>();
            var bz = blockcount<T>(w,srclen, out int remainder);
            return remainder == 0 ? bz : bz + 1;
        }

        /// <summary>
        /// Computes the minimum number of 512-bit blocks that can hold a table of data
        /// </summary>
        /// <param name="srclen">The length of the source data</param>
        /// <typeparam name="M">The row type </typeparam>
        /// <typeparam name="N">The column type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static int blockcount<M,N,T>(W512 w)
            where M : unmanaged, ITypeWidth
            where N : unmanaged, ITypeWidth
            where T : unmanaged        
        {
            var srclen = ((int)default(M).TypeWidth) * ((int)default(N).TypeWidth);            
            var bz = blockcount<T>(w,srclen, out int remainder);
            return remainder == 0 ? bz : bz + 1;
        }

    }
}
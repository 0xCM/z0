//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static Root;

    partial class Blocks
    {
        [MethodImpl(Inline)]
        public static int blockcount<T>(N8 n, int cellcount)
            where T : unmanaged
                => cellcount/length<T>(n);

        [MethodImpl(Inline)]
        public static int blockcount<T>(N16 n, int cellcount)
            where T : unmanaged
                => cellcount/length<T>(n);

        [MethodImpl(Inline)]
        public static int blockcount<T>(N32 n, int cellcount)
            where T : unmanaged
                => cellcount/length<T>(n);

        [MethodImpl(Inline)]
        public static int blockcount<T>(N64 n, int cellcount)
            where T : unmanaged
                => cellcount/length<T>(n);

        [MethodImpl(Inline)]
        public static int blockcount<T>(N128 n, int cellcount)
            where T : unmanaged
                => cellcount/length<T>(n);

        [MethodImpl(Inline)]
        public static int blockcount<T>(N256 n, int cellcount)
            where T : unmanaged
                => cellcount/length<T>(n);

        [MethodImpl(Inline)]
        public static int blockcount<T>(N512 n, int cellcount)
            where T : unmanaged
                => cellcount/length<T>(n);

        [MethodImpl(Inline)]
        public static int blockcount<T>(N8 n, int length, out int uncovered)
            where T : unmanaged   
        {       
            uncovered = length % length<T>(n);
            return length/length<T>(n);
        }

        [MethodImpl(Inline)]
        public static int blockcount<T>(N16 n, int length, out int uncovered)
            where T : unmanaged   
        {       
            uncovered = length % length<T>(n);
            return length/length<T>(n);
        }

        [MethodImpl(Inline)]
        public static int blockcount<T>(N32 n, int length, out int uncovered)
            where T : unmanaged   
        {       
            uncovered = length % length<T>(n);
            return length/length<T>(n);
        }

        [MethodImpl(Inline)]
        public static int blockcount<T>(N64 n, int length, out int uncovered)
            where T : unmanaged   
        {       
            uncovered = length % length<T>(n);
            return length/length<T>(n);
        }

        [MethodImpl(Inline)]
        public static int blockcount<T>(N128 n, int length, out int uncovered)
            where T : unmanaged          
        {       
            uncovered = length % length<T>(n);
            return length/length<T>(n);
        }

        [MethodImpl(Inline)]
        public static int blockcount<T>(N256 n, int length, out int uncovered)
            where T : unmanaged          
        {       
            uncovered = length % length<T>(n);
            return length/length<T>(n);
        }

        [MethodImpl(Inline)]
        public static int blockcount<T>(N512 n, int length, out int uncovered)
            where T : unmanaged          
        {       
            uncovered = length % length<T>(n);
            return length/length<T>(n);
        }

        /// <summary>
        /// Computes the minimum number of 256-bit blocks that can hold a table of data
        /// </summary>
        /// <param name="srclen">The length of the source data</param>
        /// <typeparam name="M">The row type </typeparam>
        /// <typeparam name="N">The column type</typeparam>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static int blockcount<M,N,T>(N256 n)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged        
        {
            var srclen = NatMath.mul<M,N>();
            var bz = blockcount<T>(n,srclen, out int remainder);
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
        public static int blockcount<M,N,T>(N512 n)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged        
        {
            var srclen = NatMath.mul<M,N>();
            var bz = blockcount<T>(n,srclen, out int remainder);
            return remainder == 0 ? bz : bz + 1;
        }

    }
}
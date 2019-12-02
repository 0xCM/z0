//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static zfunc;

    partial class DataBlocks
    {
        [MethodImpl(Inline)]
        public static int blockcount<T>(N8 n, int cellcount)
            where T : unmanaged
                => cellcount/blocklen<T>(n);

        [MethodImpl(Inline)]
        public static int blockcount<T>(N16 n, int cellcount)
            where T : unmanaged
                => cellcount/blocklen<T>(n);

        [MethodImpl(Inline)]
        public static int blockcount<T>(N32 n, int cellcount)
            where T : unmanaged
                => cellcount/blocklen<T>(n);

        [MethodImpl(Inline)]
        public static int blockcount<T>(N64 n, int cellcount)
            where T : unmanaged
                => cellcount/blocklen<T>(n);

        [MethodImpl(Inline)]
        public static int blockcount<T>(N128 n, int cellcount)
            where T : unmanaged
                => cellcount/blocklen<T>(n);

        [MethodImpl(Inline)]
        public static int blockcount<T>(N256 n, int cellcount)
            where T : unmanaged
                => cellcount/blocklen<T>(n);

        [MethodImpl(Inline)]
        public static int blockcount<T>(N8 n, int length, out int uncovered)
            where T : unmanaged   
        {       
            uncovered = length % blocklen<T>(n);
            return length/blocklen<T>(n);
        }

        [MethodImpl(Inline)]
        public static int blockcount<T>(N16 n, int length, out int uncovered)
            where T : unmanaged   
        {       
            uncovered = length % blocklen<T>(n);
            return length/blocklen<T>(n);
        }

        [MethodImpl(Inline)]
        public static int blockcount<T>(N32 n, int length, out int uncovered)
            where T : unmanaged   
        {       
            uncovered = length % blocklen<T>(n);
            return length/blocklen<T>(n);
        }

        [MethodImpl(Inline)]
        public static int blockcount<T>(N64 n, int length, out int uncovered)
            where T : unmanaged   
        {       
            uncovered = length % blocklen<T>(n);
            return length/blocklen<T>(n);
        }

        [MethodImpl(Inline)]
        public static int blockcount<T>(N128 n, int length, out int uncovered)
            where T : unmanaged          
        {       
            uncovered = length % blocklen<T>(n);
            return length/blocklen<T>(n);
        }

        [MethodImpl(Inline)]
        public static int blockcount<T>(N256 n, int length, out int uncovered)
            where T : unmanaged          
        {       
            uncovered = length % blocklen<T>(n);
            return length/blocklen<T>(n);
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
        /// Returns the block count of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left source</param>
        /// <param name="rhs">The right source</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]   
        public static int blockcount<S,T>(in Block64<S> lhs, in Block64<T> rhs)
            where T : unmanaged
            where S : unmanaged
                => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount : badsize<int>(lhs.BlockCount,rhs.BlockCount);

        /// <summary>
        /// Returns the block count of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left source</param>
        /// <param name="rhs">The right source</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]   
        public static int blockcount<S,T>(in Block128<S> lhs, in Block128<T> rhs)
            where T : unmanaged
            where S : unmanaged
                => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount : badsize<int>(lhs.BlockCount,rhs.BlockCount);

        /// <summary>
        /// Returns the block count of spans of equal length; otherwise raises an error
        /// </summary>
        /// <param name="lhs">The left source</param>
        /// <param name="rhs">The right source</param>
        /// <typeparam name="T">The span element type</typeparam>
        [MethodImpl(Inline)]   
        public static int blockcount<S,T>(in Block256<S> lhs, in Block256<T> rhs)
            where T : unmanaged
            where S : unmanaged
                => lhs.BlockCount == rhs.BlockCount ? lhs.BlockCount : badsize<int>(lhs.BlockCount,rhs.BlockCount);
    }
}
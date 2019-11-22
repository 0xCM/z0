//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;
    using static DataBlocks;

    public static class BlockExtend    
    {
        /// <summary>
        /// Reverses a blocked span in-place
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void Reverse<T>(this in Block64<T> src)
            where T : unmanaged
        {
            src.Data.Reverse();
        }

        /// <summary>
        /// Reverses a blocked span in-place
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void Reverse<T>(this in Block128<T> src)
            where T : unmanaged
        {
            src.Data.Reverse();
        }

        /// <summary>
        /// Reverses a blocked span in-place
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void Reverse<T>(this in Block256<T> src)
            where T : unmanaged
        {
            src.Data.Reverse();
        }

        /// <summary>
        /// Zero-fills the block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void Clear<T>(this in Block64<T> src)
            where T : unmanaged
                => src.Data.Clear();

        /// <summary>
        /// Zero-fills the block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void Clear<T>(this in Block128<T> src)
            where T : unmanaged
                => src.Data.Clear();

        /// <summary>
        /// Zero-fills the block
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static void Clear<T>(this in Block256<T> src)
            where T : unmanaged
                => src.Data.Clear();


        /// <summary>
        /// Constructs a 128-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> ToBlock64<T>(this Span<T> src, N64 n = default)
             where T : unmanaged
                => DataBlocks.safeload(n,src);

        /// <summary>
        /// Constructs a 128-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> ToBlock128<T>(this Span<T> src, N128 n = default)
             where T : unmanaged
                => DataBlocks.safeload(n,src);

        /// <summary>
        /// Constructs a 128-bit blocked span from an unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> ToBlock256<T>(this Span<T> src, N256 n = default)
             where T : unmanaged
                => DataBlocks.safeload(n,src);

        /// <summary>
        /// Clones a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Replicate<T>(this in Block256<T> src, bool structureOnly = false)
            where T : unmanaged
        {
            Span<T> dst = new T[src.Length];
            if(!structureOnly)
                src.CopyTo(dst);
            return new Block256<T>(dst);
        }

        /// <summary>
        /// Clones a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> Replicate<T>(this in ConstBlock256<T> src, bool structureOnly = false)
            where T : unmanaged
        {
            Span<T> dst = new T[src.Length];
            if(!structureOnly)
                src.CopyTo(dst);
            return new Block256<T>(dst);
        }

        [MethodImpl(Inline)]
        public static Block64<T> Block<T>(this Block64<T> src, int blockIndex, N64 n = default)
            where T : unmanaged
            => new Block64<T>(src.Slice(blockIndex * blocklen<T>(n), blocklen<T>(n)));
        
        [MethodImpl(Inline)]
        public static Block64<T> Blocks<T>(this Block64<T> src, int blockIndex, int blockCount, N64 n = default)
            where T : unmanaged
                => new Block64<T>(src.Slice(blockIndex * blocklen<T>(n), blockCount * blocklen<T>(n)));

        [MethodImpl(Inline)]
        public static Block128<T> Block<T>(this Block128<T> src, int blockIndex, N128 n = default)
            where T : unmanaged
                => new Block128<T>(src.Slice(blockIndex * blocklen<T>(n), blocklen<T>(n)));
        
        [MethodImpl(Inline)]
        public static Block128<T> Blocks<T>(this Block128<T> src, int blockIndex, int blockCount, N128 n = default)
            where T : unmanaged
                => new Block128<T>(src.Slice(blockIndex * blocklen<T>(n), blockCount * blocklen<T>(n)));

        [MethodImpl(Inline)]
        public static ConstBlock128<T> Block<T>(this ConstBlock128<T> src, int blockIndex, N128 n = default)
            where T : unmanaged
            => new ConstBlock128<T>(src.Data.Slice(blockIndex * blocklen<T>(n), blocklen<T>(n)));

        [MethodImpl(Inline)]
        public static ConstBlock128<T> Blocks<T>(this ConstBlock128<T> src,int blockIndex, int blockCount, N128 n = default)
            where T : unmanaged
                => new ConstBlock128<T>(src.Data.Slice(blockIndex * blocklen<T>(n), blockCount * blocklen<T>(n)));

        [MethodImpl(Inline)]
        public static Block256<T> Block<T>(this Block256<T> src, int blockIndex, N256 n = default)
            where T : unmanaged
            => new Block256<T>(src.Slice(blockIndex * blocklen<T>(n), blocklen<T>(n)));
            
        [MethodImpl(Inline)]
        public static Block256<T> Blocks<T>(this Block256<T> src, int blockIndex, int blockCount, N256 n = default)
            where T : unmanaged
                => new Block256<T>(src.Slice(blockIndex *  blocklen<T>(n) , blockCount * blocklen<T>(n)));

        [MethodImpl(Inline)]
        public static ConstBlock256<T> Block<T>(this ConstBlock256<T> src, int blockIndex, N256 n = default)
            where T : unmanaged
            => new ConstBlock256<T>(src.Data.Slice(blockIndex * blocklen<T>(n), blocklen<T>(n)));

        [MethodImpl(Inline)]
        public static ConstBlock256<T> Blocks<T>(this ConstBlock256<T> src,int blockIndex, int blockCount, N256 n = default)
            where T : unmanaged
                => new ConstBlock256<T>(src.Data.Slice(blockIndex * blocklen<T>(n), blockCount * blocklen<T>(n)));

    
        /// <summary>
        /// Presents the allocated data as a blocked read-only span
        /// </summary>
        [MethodImpl(Inline)]
        public static ConstBlock64<T> ReadOnly<T>(this Block64<T> src)
            where T : unmanaged
                => new ConstBlock64<T>(src);

        /// <summary>
        /// Presents the allocated data as a blocked read-only span
        /// </summary>
        [MethodImpl(Inline)]
        public static ConstBlock128<T> ReadOnly<T>(this Block128<T> src)
            where T : unmanaged
                => new ConstBlock128<T>(src);

        /// <summary>
        /// Presents the allocated data as a blocked read-only span
        /// </summary>
        [MethodImpl(Inline)]
        public static ConstBlock256<T> ReadOnly<T>(this Block256<T> src)
            where T : unmanaged
                => new ConstBlock256<T>(src);

        /// <summary>
        /// Presents an unsized span as one of natural length
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The target size</param>
        /// <typeparam name="N">The target type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]        
        public static NatBlock<N,T> NatLoad<N,T>(this Span<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => DataBlocks.natload(n,src);

        /// <summary>
        /// Fills a tabular span of natural dimensions with streamed elements
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The column dimension type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static void StreamTo<M,N,T>(this IEnumerable<T> src, in NatGrid<M,N,T> dst)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Take(NatMath.mul<M,N>()).StreamTo(dst.Data);

        public static Span<T> Map<M,N,S,T>(this in NatGrid<M,N,S> src, Func<S, T> f)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where S : unmanaged
            where T : unmanaged
        {
            var dst = DataBlocks.gridalloc<M,N,T>();
            var m = nfunc.nati<M>();
            var n = nfunc.nati<N>();
            for(var i=0; i < m; i++)
            for(var j=0; j < n; j++)
                dst[i,j] = f(src[i,j]);
            return dst;
        }

        public static T Reduce<M,N,T>(this in NatGrid<M,N,T> src, Func<T,T,T> f)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.ReadOnly().Reduce(f);        

    }
}

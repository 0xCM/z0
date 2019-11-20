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

    partial class MemBlocks
    {
        /// <summary>
        /// Creates 64-bit blocked span from a parameter array and raises an error if the data source is not block-aligned
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> load<T>(N64 n, params T[] src)
            where T : unmanaged        
                => Block64<T>.Load(src);

        /// <summary>
        /// Loads an unsized 64-bit blocked span from a natural unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> load<N,T>(N64 n, in Span<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat<N>, INatDivisible<N,N64>
                => load(n, src.Unsized);

        [MethodImpl(Inline)]
        public static Block64<T> load<T>(N64 n, Span<T> src, int offset = 0)
            where T : unmanaged
        {
            if(!aligned<T>(n,src.Length - offset))
                badsize(n, src.Length - offset);      

            return new Block64<T>(offset == 0 ? src : src.Slice(offset));
        }

        [MethodImpl(Inline)]
        public static unsafe Block64<T> load<T>(N64 n, T* src, int length)
            where T : unmanaged
        {
            if(!aligned<T>(n,length))
                badsize(n,length);

            return new Block64<T>(src,length);
        }


        /// <summary>
        /// Creates 128-bit blocked span from a parameter array and raises an error if the
        /// data source is improperly blocked
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span128<T> load<T>(N128 n, params T[] src)
            where T : unmanaged        
                => Span128<T>.Load(src);

        /// <summary>
        /// Creates 256-bit blocked span from a parameter array and raises an error if the
        /// data source is improperly blocked
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="src">The source data</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> load<T>(N256 n, params T[] src)
            where T : unmanaged        
                => Span256<T>.Load(src);


        [MethodImpl(Inline)]
        public static unsafe Span128<T> load<T>(N128 n, void* src, int length)
            where T : unmanaged
        {
            if(!aligned<T>(n,length))
                badsize(n,length);
            
            return new Span128<T>(src,length);
        }

        [MethodImpl(Inline)]
        public static unsafe Span256<T> load<T>(N256 n, void* src, int length)
            where T : unmanaged
        {
            if(!aligned<T>(n,length))
                badsize(n,length);

            return new Span256<T>(src,length);
        }

        /// <summary>
        /// Loads 128-bit blocked span from an unblocked span, reallocating if the source span isn't properly blocked
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        /// <remarks>The use of this method is discouraged</remarks>
        [MethodImpl(NotInline)]
        public static Block64<T> loadu<T>(N64 n, Span<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(n, src.Length, out int remainder);
            if(remainder == 0)
                return Block64<T>.TransferUnsafe(src);
            else
            {
                var dst = alloc<T>(n, bz + 1);
                src.CopyTo(dst);
                return dst;
            }
        }

        /// <summary>
        /// Loads 128-bit blocked span from an unblocked span, reallocating if the source span isn't properly blocked
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        /// <remarks>The use of this method is discouraged</remarks>
        [MethodImpl(NotInline)]
        public static Span128<T> loadu<T>(N128 n, Span<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(n, src.Length, out int remainder);
            if(remainder == 0)
                return Span128<T>.TransferUnsafe(src);
            else
            {
                var dst = alloc<T>(n, bz + 1);
                src.CopyTo(dst);
                return dst;
            }
        }

        /// <summary>
        /// Loads 256-bit blocked span from an unblocked span, reallocating if the source span isn't properly blocked
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        /// <remarks>The use of this method is discouranged unless absolutely necessary</remarks>
        [MethodImpl(NotInline)]
        public static Span256<T> loadu<T>(N256 n, Span<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(n, src.Length, out int remainder);
            if(remainder == 0)
                return Span256<T>.TransferUnsafe(src);
            else
            {
                var dst = alloc<T>(n, bz + 1);
                src.CopyTo(dst);
                return dst;
            }
        }
    }

}
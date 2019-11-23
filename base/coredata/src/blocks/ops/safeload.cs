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
        /// <summary>
        /// Loads 128-bit blocked span from an unblocked span, reallocating if the source span isn't properly blocked
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        /// <remarks>The use of this method is discouraged</remarks>
        [MethodImpl(NotInline)]
        public static Block64<T> safeload<T>(N64 n, Span<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(n, src.Length, out int remainder);
            if(remainder == 0)
                return new Block64<T>(src);
            else
            {
                var dst = alloc<T>(n, bz + 1);
                src.CopyTo(dst);
                return dst;
            }
        }

        /// <summary>
        /// Loads an unsized 64-bit blocked span from a natural unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block64<T> safeload<N,T>(N64 n, in NatSpan<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat<N>, INatDivisible<N,N64>
                => safeload(n, src.Unsized);

        /// <summary>
        /// Loads 128-bit blocked span from an unblocked span, reallocating if the source span isn't properly blocked
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        /// <remarks>The use of this method is discouraged</remarks>
        [MethodImpl(NotInline)]
        public static Block128<T> safeload<T>(N128 n, Span<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(n, src.Length, out int remainder);
            if(remainder == 0)
                return new Block128<T>(src);
            else
            {
                var dst = alloc<T>(n, bz + 1);
                src.CopyTo(dst);
                return dst;
            }
        }
        /// <summary>
        /// Loads an unsized 64-bit blocked span from a natural unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block128<T> safeload<N,T>(N128 n, in NatSpan<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat<N>, INatDivisible<N,N64>
                => safeload(n, src.Unsized);

        /// <summary>
        /// Loads 256-bit blocked span from an unblocked span, reallocating if the source span isn't properly blocked
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        /// <remarks>The use of this method is discouranged unless absolutely necessary</remarks>
        [MethodImpl(NotInline)]
        public static Block256<T> safeload<T>(N256 n, Span<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(n, src.Length, out int remainder);
            if(remainder == 0)
                return new Block256<T>(src);
            else
            {
                var dst = alloc<T>(n, bz + 1);
                src.CopyTo(dst);
                return dst;
            }
        }

        /// <summary>
        /// Loads an unsized 256-bit blocked span from a sized unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<T> safeload<N,T>(N256 n, in NatSpan<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => safeload(n,src.Unsized);
    }
}
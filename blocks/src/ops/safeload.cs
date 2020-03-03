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
        /// <summary>
        /// Loads 32-bit blocked span from an unblocked span, reallocating if the source span isn't properly blocked
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        /// <remarks>The use of this method is discouraged</remarks>
        [MethodImpl(NotInline)]
        public static Block16<T> safeload<T>(N16 n, Span<T> src)
            where T : unmanaged
        {                    
            var bz = blockcount<T>(n, src.Length, out int remainder);
            if(remainder == 0)
                return new Block16<T>(src);
            else
            {
                var dst = alloc<T>(n, bz + 1);
                src.CopyTo(dst);
                return dst;
            }
        }

        /// <summary>
        /// Loads 32-bit blocked span from an unblocked span, reallocating if the source span isn't properly blocked
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        /// <remarks>The use of this method is discouraged</remarks>
        [MethodImpl(NotInline)]
        public static Block32<T> safeload<T>(N32 n, Span<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(n, src.Length, out int remainder);
            if(remainder == 0)
                return new Block32<T>(src);
            else
            {
                var dst = alloc<T>(n, bz + 1);
                src.CopyTo(dst);
                return dst;
            }
        }

        /// <summary>
        /// Loads 64-bit blocked span from an unblocked span, reallocating if the source span isn't properly blocked
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

        [MethodImpl(Inline)]
        public static Block16<T> literals<T>(N16 n, params T[] src)
            where T : unmanaged
                => safeload(n,src.ToSpan());        

        [MethodImpl(Inline)]
        public static Block32<T> literals<T>(N32 n, params T[] src)
            where T : unmanaged
                => safeload(n,src.ToSpan());        

        [MethodImpl(Inline)]
        public static Block64<T> literals<T>(N64 n, params T[] src)
            where T : unmanaged
                => safeload(n,src.ToSpan());        

        [MethodImpl(Inline)]
        public static Block256<T> literals<T>(N256 n, params T[] src)
            where T : unmanaged
                => safeload(n,src.ToSpan());        

        /// <summary>
        /// Loads 512-bit blocked span from an unblocked span, reallocating if the source span isn't properly blocked
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        /// <remarks>The use of this method is discouranged unless absolutely necessary</remarks>
        [MethodImpl(NotInline)]
        public static Block512<T> safeload<T>(N512 n, Span<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(n, src.Length, out int remainder);
            if(remainder == 0)
                return new Block512<T>(src);
            else
            {
                var dst = alloc<T>(n, bz + 1);
                src.CopyTo(dst.Data);
                return dst;
            }
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct SpanBlocks
    {
        /// <summary>
        /// Loads a sequence of 16-bit blocks from an unblocked span, reallocating if the source span isn't properly blocked
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        /// <remarks>The use of this method is discouraged</remarks>
        public static SpanBlock8<T> safeload<T>(W8 w, Span<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(w, src.Length, out int remainder);
            if(remainder == 0)
                return new SpanBlock8<T>(src);
            else
            {
                var dst = alloc<T>(w, bz + 1);
                src.CopyTo(dst);
                return dst;
            }
        }

        /// <summary>
        /// Loads a sequence of 16-bit blocks from an unblocked span, reallocating if the source span isn't properly blocked
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        /// <remarks>The use of this method is discouraged</remarks>
        public static SpanBlock16<T> safeload<T>(W16 w, Span<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(w, src.Length, out int remainder);
            if(remainder == 0)
                return new SpanBlock16<T>(src);
            else
            {
                var dst = alloc<T>(w, bz + 1);
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
        public static SpanBlock32<T> safeload<T>(W32 w, Span<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(w, src.Length, out int remainder);
            if(remainder == 0)
                return new SpanBlock32<T>(src);
            else
            {
                var dst = alloc<T>(w, bz + 1);
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
        public static SpanBlock64<T> safeload<T>(W64 w, Span<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(w, src.Length, out int remainder);
            if(remainder == 0)
                return new SpanBlock64<T>(src);
            else
            {
                var dst = alloc<T>(w, bz + 1);
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
        public static SpanBlock128<T> safeload<T>(W128 w, Span<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(w, src.Length, out int remainder);
            if(remainder == 0)
                return new SpanBlock128<T>(src);
            else
            {
                var dst = alloc<T>(w, bz + 1);
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
        public static SpanBlock256<T> safeload<T>(W256 w, Span<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(w, src.Length, out int remainder);
            if(remainder == 0)
                return new SpanBlock256<T>(src);
            else
            {
                var dst = alloc<T>(w, bz + 1);
                src.CopyTo(dst);
                return dst;
            }
        }

        [MethodImpl(Inline)]
        public static SpanBlock16<T> literals<T>(W16 w, params T[] src)
            where T : unmanaged
                => safeload(w,src.ToSpan());

        [MethodImpl(Inline)]
        public static SpanBlock32<T> literals<T>(W32 w, params T[] src)
            where T : unmanaged
                => safeload(w,src.ToSpan());

        [MethodImpl(Inline)]
        public static SpanBlock64<T> literals<T>(W64 w, params T[] src)
            where T : unmanaged
                => safeload(w,src.ToSpan());

        [MethodImpl(Inline)]
        public static SpanBlock256<T> literals<T>(W256 w, params T[] src)
            where T : unmanaged
                => safeload(w,src.ToSpan());

        /// <summary>
        /// Loads 512-bit blocked span from an unblocked span, reallocating if the source span isn't properly blocked
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The data type</typeparam>
        /// <remarks>The use of this method is discouranged unless absolutely necessary</remarks>
        public static SpanBlock512<T> safeload<T>(W512 w, Span<T> src)
            where T : unmanaged
        {
            var bz = blockcount<T>(w, src.Length, out int remainder);
            if(remainder == 0)
                return new SpanBlock512<T>(src);
            else
            {
                var dst = alloc<T>(w, bz + 1);
                src.CopyTo(dst.Data);
                return dst;
            }
        }
    }
}
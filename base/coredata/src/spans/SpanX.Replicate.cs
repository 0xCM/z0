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
    using static nfunc;

    partial class MemBlockExtend
    {
        /// <summary>
        /// Clones the source span into a new span
        /// </summary>
        /// <param name="src">The span to replicate</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <returns>Returns the replicated span</returns>
        [MethodImpl(Inline)]
        public static Span<T> Replicate<T>(this ReadOnlySpan<T> src, bool structureOnly = false)
        {
            Span<T> dst = new T[src.Length];
            if(!structureOnly)
                src.CopyTo(dst);
            return dst;
        }

        /// <summary>
        /// Clones the source span into a new span
        /// </summary>
        /// <param name="src">The span to replicate</param>
        /// <typeparam name="T">The element type</typeparam>
        /// <returns>Returns the replicated span</returns>
        [MethodImpl(Inline)]
        public static Span<T> Replicate<T>(this Span<T> src, bool structureOnly = false)
            => src.ReadOnly().Replicate(structureOnly);

        /// <summary>
        /// Clones a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> Replicate<T>(this Span256<T> src, bool structureOnly = false)
            where T : unmanaged
        {
            Span<T> dst = new T[src.Length];
            if(!structureOnly)
                src.CopyTo(dst);
            return Z0.Span256<T>.LoadAligned(dst);
        }

        /// <summary>
        /// Clones a blocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Span256<T> Replicate<T>(this ConstBlock256<T> src, bool structureOnly = false)
            where T : unmanaged
        {
            Span<T> dst = new T[src.Length];
            if(!structureOnly)
                src.CopyTo(dst);
            return Z0.Span256<T>.LoadAligned(dst);
        }

        /// <summary>
        /// Creates a copy of the source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<N,T> Replicate<N,T>(this ConstBlock<N,T> src)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new Span<N,T>(src);
    }
}
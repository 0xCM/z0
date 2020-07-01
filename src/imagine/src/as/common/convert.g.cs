//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    partial struct As
    {
        /// <summary>
        /// Applies the unconditional numeric conversion S -> T for each source element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static ref readonly Span<T> convert<S,T>(in ReadOnlySpan<S> src, in Span<T> dst)
        {
            for(var i=0u; i<src.Length; i++)
                seek(dst,i) = As<S,T>(ref edit(skip(src,i)));
            return ref dst;
        }

        /// <summary>
        /// Applies the unconditional conversion S -> T for each source element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<T> convert<S,T>(Span<S> src)
        {
            var dst = alloc<T>(src.Length).ToSpan();
            convert<S,T>(src,dst);
            return dst;
        }

        /// <summary>
        /// Converts values in the source to values of the target type
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> convert<S,T>(ReadOnlySpan<S> src)
        {
            var dst = alloc<T>(src.Length);
            convert<S,T>(src,dst);
            return dst;
        }
    }
}
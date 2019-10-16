//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    partial class mathspan
    {
        /// <summary>
        /// Multiplies corresponding elements in left/right primal source spans and writes
        /// the result to a caller-supplied target span
        /// </summary>
        /// <param name="lhs">The left primal span</param>
        /// <param name="rhs">The right primal span</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="T">The span element type</typeparam>
        public static Span<T> mul<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            var len = length(lhs,rhs);
            for(var i = 0; i< len; i++)
                dst[i] = gmath.mul(lhs[i], rhs[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<T> mul<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => mul(lhs,rhs,lhs);

        [MethodImpl(Inline)]
        public static Span<T> mul<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => mul(lhs,rhs,lhs.Replicate(true));


    }

}
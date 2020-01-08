//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    

    partial class mathspan
    {

        [MethodImpl(Inline)]
        public static Span<T> fmod<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            var count = length(lhs,rhs);
            for(var i = 0; i< count; i++)
                lhs[i] = gfp.mod(lhs[i], rhs[i]);
            return lhs;
        }

        [MethodImpl(Inline)]
        public static Span<T> fmod<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            var count = length(lhs,rhs);
            for(var i = 0; i< count; i++)
                dst[i] = gfp.mod(lhs[i], rhs[i]);
            return dst;
        }
    }
}
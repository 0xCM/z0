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
        public static Span<T> xor<T>(Span<T> lhs, T rhs)
            where T : unmanaged
        {
            for(var i=0; i< lhs.Length; i++)
                lhs[i] = gmath.xor(lhs[i], rhs);
            return lhs;
        }

        public static Span<T> xor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< length(lhs,rhs); i++)
                dst[i] = gmath.xor(lhs[i], rhs[i]);
           return dst;        
        }

        [MethodImpl(Inline)]
        public static Span<T> xor<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => xor(lhs,rhs, lhs);


        [MethodImpl(Inline)]
        public static Span<T> xor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
                => xor(lhs,rhs,lhs.Replicate(true));


    }
}
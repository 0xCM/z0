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
        public static Span<T> xor<T>(ReadOnlySpan<T> lhs, ReadOnlySpan<T> rhs, Span<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< length(lhs,rhs); i++)
                dst[i] = gmath.xor(lhs[i], rhs[i]);
           return dst;        
        }

        public static Span<T> xor<T>(Span<T> lhs, ReadOnlySpan<T> rhs)
            where T : unmanaged
        {
            for(var i=0; i< length(lhs,rhs); i++)
                gmath.xor(ref lhs[i], rhs[i]);
           return lhs;
        }

        public static Span<T> xor<T>(Span<T> lhs, T rhs)
            where T : unmanaged
        {
            for(var i=0; i< lhs.Length; i++)
                gmath.xor(ref lhs[i],rhs);
            return lhs;
        }
    }
}
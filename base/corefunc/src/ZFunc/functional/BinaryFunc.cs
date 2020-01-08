//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public static class BinaryFunc
    {
        [MethodImpl(Inline)]
        public static Span<T2> apply<F,T0,T1,T2>(F f, ReadOnlySpan<T0> lhs, ReadOnlySpan<T1> rhs, Span<T2> dst)
            where F : IBinaryFunc<T0,T1,T2>
        {
            var count = dst.Length;
            ref readonly var lSrc = ref head(lhs);
            ref readonly var rSrc = ref head(rhs);
            ref var target = ref head(dst);

            for(var i=0; i<count; i++)
                seek(ref target, i) = f.Invoke(skip(in lSrc, i), skip(in rSrc, i));
            return dst;
        }        
    }

}
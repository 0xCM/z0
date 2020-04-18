//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    partial class XTend
    {

        [MethodImpl(Inline)]
        public static void CopyTo<N,T>(this in NatSpan<N,T> src,Span<T> dst)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data.CopyTo(dst);

        public static int Count<T>(this ReadOnlySpan<T> src, Func<T,bool> predicate)
        {
            var len = src.Length;
            var count = 0;
            for(var i=0; i<len; i++)
                if(predicate(skip(src,i)))
                    count++;                    
            return count;
        }        
        
        [MethodImpl(Inline)]
        public static int Count<T>(this Span<T> src, Func<T,bool> predicate)
            => src.ReadOnly().Count(predicate);
    }
}
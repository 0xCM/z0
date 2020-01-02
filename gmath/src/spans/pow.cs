//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    
    public static partial class mathspan
    {    
        public static Span<T> pow<T>(ReadOnlySpan<T> src, uint exp, Span<T> dst)
            where T : unmanaged
        {
            var len =  length(src,dst);
            for(var i = 0; i<len; i++) 
                dst[i] = gmath.pow(src[i], exp);
            return dst;
        }

        public static Span<T> pow<T>(Span<T> src, ReadOnlySpan<uint> exp)
            where T : unmanaged
        {
            var len =  src.Length;
            for(var i = 0; i<len; i++) 
                src[i] = gmath.pow(src[i], exp[i]);
            return src;
        }

        public static Span<T> pow<T>(Span<T> src, uint exp)
            where T : unmanaged
                => pow(src.ReadOnly(), exp, src);


        [MethodImpl(Inline)]
        public static Span<T> sqrt<T>(Span<T> src)
            where T : unmanaged
        {
            for(var i=0; i< src.Length; i++)
                gfp.sqrt(ref src[i]);
            return src;
        }

    }
}
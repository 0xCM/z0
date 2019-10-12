//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    
    public static partial class mathspan
    {    
        public static Span<T> pow<T>(Span<T> b, ReadOnlySpan<uint> exp)
            where T : unmanaged
        {
            var len =  b.Length;
            for(var i = 0; i<len; i++) 
                b[i] = gmath.pow(b[i], exp[i]);
            return b;
        }

        public static Span<T> pow<T>(Span<T> b, uint exp)
            where T : unmanaged
        {
            var len =  b.Length;
            for(var i = 0; i<len; i++) 
                b[i] = gmath.pow(b[i], exp);
            return b;
        }


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
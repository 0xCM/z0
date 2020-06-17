//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;

    partial class SBlock
    {
        [MethodImpl(Inline)]
        public static Span<bit> zip<F,T>(in Block128<T> a, Block128<T> b, Span<bit> dst, F f)
            where T : unmanaged
            where F : IBinaryPred128<T>
        {
            var blocks = a.BlockCount;            
            ref var result = ref refs.head(dst);
            for(var block = 0; block < blocks; block++)
                refs.seek(ref result, block) = f.Invoke(a.LoadVector(block), b.LoadVector(block));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<bit> zip<F,T>(in Block256<T> a, in Block256<T> b, Span<bit> dst, F f)
            where T : unmanaged
            where F : IBinaryPred256<T>
        {
            var blocks = a.BlockCount;            
            ref var result = ref refs.head(dst);
            for(var block = 0; block < blocks; block++)
                refs.seek(ref result, block) = f.Invoke(a.LoadVector(block), b.LoadVector(block));
            return dst;
        }         
    }
}
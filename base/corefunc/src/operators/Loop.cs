//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public static class Loop
    {
        [MethodImpl(Inline)]
        public static void run<F,T>(F f, ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
            where F : IUnaryOp<T>
        {
            var end = dst.Length;
            ref readonly var input = ref head(src);
            ref var output = ref head(dst);
            for(var i=0; i<end; i++)
                seek(ref output, i) = f.Invoke(skip(input, i));                
        }

        [MethodImpl(Inline)]
        public static void run<F,T>(F f, in T src, ref T dst, int count)
            where F : IUnaryOp<T>
        {                        
            for(var i=0; i<count; i++)
                seek(ref dst, i) = f.Invoke(skip(src, i));                
        }

        [MethodImpl(Inline)]
        public static void run<F>(F f, int count)
            where F : IAction<int>
        {                        
            for(var i=0; i<count; i++)
                f.Invoke(i);
        }

        [MethodImpl(Inline)]
        public static void run<F,T>(F f, ArrayExchange<T> src, ArrayExchange<T> dst)
            where F : IUnaryOp<T>
                => run(f, in src.Head, ref dst.Head, dst.Count);
    }
}
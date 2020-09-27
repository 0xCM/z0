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
        public static ref readonly SpanBlock128<T> map<F,T>(in SpanBlock128<T> src, in SpanBlock128<T> dst, F f)
            where T : unmanaged
            where F : IUnaryOp128<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(src.LoadVector(block)).StoreTo(dst, block);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly SpanBlock256<T> map<F,T>(in SpanBlock256<T> src, in SpanBlock256<T> dst, F f)
            where T : unmanaged
            where F : IUnaryOp256<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(src.LoadVector(block)).StoreTo(dst, block);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static Span<Bit32> map<F,T>(in SpanBlock128<T> src, in Span<Bit32> dst, F f)
            where T : unmanaged
            where F : IUnaryPred128<T>
        {
            var blocks = src.BlockCount;
            ref var result = ref z.first(dst);
            for(var block = 0; block < blocks; block++)
                z.seek(result, block) = f.Invoke(src.LoadVector(block));
            return dst;
        }

        [MethodImpl(Inline)]
        public static Span<Bit32> map<F,T>(in SpanBlock256<T> src, Span<Bit32> dst, F f)
            where T : unmanaged
            where F : IUnaryPred256<T>
        {
            var blocks = src.BlockCount;
            ref var result = ref z.first(dst);
            for(var block = 0; block < blocks; block++)
                z.seek(result, block) = f.Invoke(src.LoadVector(block));
            return dst;
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct SFx
    {
        [MethodImpl(Inline)]
        public static ref readonly SpanBlock16<T> zip<F,T>(in SpanBlock16<T> a, in SpanBlock16<T> b, in SpanBlock16<T> dst, F f)
            where T : unmanaged
            where F : IBinarySpanOp<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block<blocks; block++)
                f.Invoke(a.CellBlock(block), b.CellBlock(block), dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly SpanBlock32<T> zip<F,T>(in SpanBlock32<T> a, in SpanBlock32<T> b, in SpanBlock32<T> dst, F f)
            where T : unmanaged
            where F : IBinarySpanOp<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block<blocks; block++)
                f.Invoke(a.CellBlock(block), b.CellBlock(block), dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly SpanBlock64<T> zip<F,T>(in SpanBlock64<T> a, in SpanBlock64<T> b, in SpanBlock64<T> dst, F f)
            where T : unmanaged
            where F : IBinarySpanOp<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block<blocks; block++)
                f.Invoke(a.CellBlock(block), b.CellBlock(block), dst);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly SpanBlock128<T> zip<F,T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst, F f)
            where T : unmanaged
            where F : IBinaryOp128<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block<blocks; block++)
                f.Invoke(a.LoadVector(block), b.LoadVector(block)).StoreTo(dst, block);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly SpanBlock256<T> zip<F,T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst, F f)
            where T : unmanaged
            where F : IBinaryOp256<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block<blocks; block++)
                f.Invoke(a.LoadVector(block), b.LoadVector(block)).StoreTo(dst, block);
            return ref dst;
        }
    }
}
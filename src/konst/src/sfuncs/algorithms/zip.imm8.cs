//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct SFx
    {
        [MethodImpl(Inline)]
        public static ref readonly SpanBlock128<T> zip<F,T>(in SpanBlock128<T> src, byte imm8, in SpanBlock128<T> dst, F f)
            where T : unmanaged
            where F : IShiftOp128<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(src.LoadVector(block),imm8).StoreTo(dst, block);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref readonly SpanBlock256<T> zip<F,T>(in SpanBlock256<T> src, byte imm8, in SpanBlock256<T> dst, F f)
            where T : unmanaged
            where F : IShiftOp256<T>
        {
            var blocks = dst.BlockCount;
            for(var block = 0; block < blocks; block++)
                f.Invoke(src.LoadVector(block),imm8).StoreTo(dst, block);
            return ref dst;
        }
    }
}
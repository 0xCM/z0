//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public readonly struct SpanBlockDelegates
    {
        [Free]
        public delegate ref readonly SpanBlock8<T> BinaryOp8<T>(in SpanBlock8<T> a, in SpanBlock8<T> b, in SpanBlock8<T> dst)
            where T : unmanaged;

        [Free]
        public delegate ref readonly SpanBlock16<T> BinaryOp16<T>(in SpanBlock16<T> a, in SpanBlock16<T> b, in SpanBlock16<T> dst)
            where T : unmanaged;

        [Free]
        public delegate ref readonly SpanBlock32<T> BinaryOp32<T>(in SpanBlock32<T> a, in SpanBlock32<T> b, in SpanBlock32<T> dst)
            where T : unmanaged;

        [Free]
        public delegate ref readonly SpanBlock64<T> BinaryOp64<T>(in SpanBlock64<T> a, in SpanBlock64<T> b, in SpanBlock64<T> dst)
            where T : unmanaged;

        [Free]
        public delegate ref readonly SpanBlock128<T> BinaryOp128<T>(in SpanBlock128<T> a, in SpanBlock128<T> b, in SpanBlock128<T> dst)
            where T : unmanaged;

        [Free]
        public delegate ref readonly SpanBlock256<T> BinaryOp256<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, in SpanBlock256<T> dst)
            where T : unmanaged;

        [Free]
        public delegate ref readonly SpanBlock512<T> BinaryOp512<T>(in SpanBlock512<T> a, in SpanBlock512<T> b, in SpanBlock512<T> dst)
            where T : unmanaged;

        [Free]
        public delegate ref readonly SpanBlock128<T> UnaryOp128Imm8<T>(in SpanBlock128<T> src, byte imm8, in SpanBlock128<T> dst)
            where T : unmanaged;

        [Free]
        public delegate ref readonly SpanBlock256<T> UnaryOp256Imm8<T>(in SpanBlock256<T> src, byte imm8, in SpanBlock256<T> dst)
            where T : unmanaged;
    }

}
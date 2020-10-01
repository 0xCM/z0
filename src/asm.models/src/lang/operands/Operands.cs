//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct AsmLang
    {
        [ApiHost(ApiNames.AsmOperands, true)]
        public readonly partial struct Operands
        {
            const NumericKind Closure = UnsignedInts;

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static ImmOp<T> imm<T>(T src)
                where T : unmanaged
                    => src;

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static MemOp<T> mem<T>(T src)
                where T : unmanaged
                    => src;

            [MethodImpl(Inline), Op, Closures(Closure)]
            public static RegOp<T> reg<T>(T src)
                where T : unmanaged
                    => src;

            [MethodImpl(Inline)]
            public static ReadOnlySpan<byte> data<H,T>(in H src)
                where H : struct, IOperand<H,T>
                where T : unmanaged
                    => z.bytes(src);
        }
    }
}
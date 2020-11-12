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

            /// <summary>
            /// Creates an immediate operand
            /// </summary>
            /// <param name="src">The defining source value</param>
            /// <typeparam name="T">The operand type</typeparam>
            [MethodImpl(Inline)]
            public static ImmOp<T> imm<T>(T src)
                where T : unmanaged
                    => src;

            /// <summary>
            /// Creates a memory operand
            /// </summary>
            /// <param name="src">The defining source value</param>
            /// <typeparam name="T">The operand type</typeparam>
            [MethodImpl(Inline)]
            public static MemOp<T> mem<T>(T src)
                where T : unmanaged
                    => src;

            /// <summary>
            /// Creates a register operand
            /// </summary>
            /// <param name="src">The defining source value</param>
            /// <typeparam name="T">The operand type</typeparam>
            [MethodImpl(Inline)]
            public static RegOp<T> reg<T>(T src)
                where T : unmanaged, IRegister<T>
                    => src;

            [MethodImpl(Inline)]
            public static ref byte edit<T>(in RegOp<T> src)
                where T : unmanaged, IRegister<T>
                    => ref bytes<RegOp<T>,T>(src);

            [MethodImpl(Inline)]
            public static ref byte edit<T>(in ImmOp<T> src)
                where T : unmanaged
                    => ref bytes<ImmOp<T>,T>(src);

            [MethodImpl(Inline)]
            public static ref byte edit<T>(in MemOp<T> src)
                where T : unmanaged
                    => ref bytes<MemOp<T>,T>(src);

            [MethodImpl(Inline)]
            static ref byte bytes<H,T>(in H src)
                where H : struct, IOperand<T>
                where T : unmanaged
                    => ref z.@as<H,byte>(src);

            [MethodImpl(Inline)]
            public static ReadOnlySpan<byte> data<H,T>(in H src)
                where H : struct, IOperand<H,T>
                where T : unmanaged
                    => z.bytes(src);

            [MethodImpl(Inline)]
            public static Operand<T> unify<T>(T src)
                where T : unmanaged, IOperand<T>
                    => src;
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmMnemonicCode;
    using static AsmMem;

    partial struct AsmInstructions
    {
        public readonly struct Movzx : IAsmInstruction<Movzx>
        {
            public AsmMnemonicCode Mnemonic => MOVZX;

            public static implicit operator AsmMnemonicCode(Movzx src) => src.Mnemonic;
        }

        /// <summary>
        /// MOVZX
        /// </summary>
        [Op]
        public static Movzx movzx()
            => default;

        /// <summary>
        /// | 0F B6 / r | MOVZX r16, r8 | Move byte to word with zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        public static AsmStatement<R16<T>,R8<S>> movzx<T,S>(R16<T> dst, R8<S> src)
            where T : unmanaged, IRegOp16
            where S : unmanaged, IRegOp8
                => asm.statement(movzx(), dst, src);

        /// <summary>
        /// | 0F B6 / r | MOVZX r16, r8 | Move byte to word with zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<R16,R8> movzx(R16 dst, R8 src)
            => asm.statement(movzx(), dst, src);

        /// <summary>
        /// | 0F B6 / r | MOVZX r16, m8 | Move byte to word with zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The memory source</param>
        /// <typeparam name="T">The target register type</typeparam>
        public static AsmStatement<R16<T>,m8> movzx<T>(R16<T> dst, m8 src)
            where T : unmanaged, IRegOp16
                => asm.statement(movzx(), dst, src);

        /// <summary>
        /// | 0F B6 / r | MOVZX r16, m8 | Move byte to word with zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The memory source</param>
        /// <typeparam name="T">The target register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<R16,m8> movzx(R16 dst, m8 src)
            => asm.statement(movzx(), dst, src);

        /// <summary>
        /// 0F B6 / r | MOVZX r32, r8 | Move byte to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        public static AsmStatement<R32<T>,R8<S>> movzx<T,S>(R32<T> dst, R8<S> src)
            where T : unmanaged, IRegOp32
            where S : unmanaged, IRegOp8
                => asm.statement(movzx(), dst, src);

        /// <summary>
        /// 0F B6 / r | MOVZX r32, r8 | Move byte to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<R32,R8> movzx(R32 dst, R8 src)
            => asm.statement(movzx(), dst, src);

        /// <summary>
        /// 0F B6 / r | MOVZX r32, m8 | Move byte to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        public static AsmStatement<R32<T>,m8> movzx<T>(R32<T> dst, m8 src)
            where T : unmanaged, IRegOp32
                => asm.statement(movzx(), dst, src);

        /// <summary>
        /// 0F B6 / r | MOVZX r32, m8 | Move byte to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<R32,m8> movzx(R32 dst, m8 src)
            => asm.statement(movzx(), dst, src);

        /// <summary>
        /// REX.W + 0F B6 / r | MOVZX r64, r8 | Move byte to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        public static AsmStatement<R64<T>,R8<S>> movzx<T,S>(R64<T> dst, R8<S> src)
            where T : unmanaged, IRegOp64
            where S : unmanaged, IRegOp8
                => asm.statement(movzx(), dst, src);

        /// <summary>
        /// REX.W + 0F B6 / r | MOVZX r64, r8 | Move byte to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<R64,R8> movzx(R64 dst, R8 src)
            => asm.statement(movzx(), dst, src);

        /// <summary>
        /// REX.W + 0F B6 / r | MOVZX r64, m8 | Move byte to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        public static AsmStatement<R64<T>,m8> movzx<T>(R64<T> dst, m8 src)
            where T : unmanaged, IRegOp64
                => asm.statement(movzx(), dst, src);

        /// <summary>
        /// REX.W + 0F B6 / r | MOVZX r64, m8 | Move byte to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<R64,m8> movzx<T>(R64 dst, m8 src)
            => asm.statement(movzx(), dst, src);

        /// <summary>
        /// 0F B7 / r | MOVZX r32, r16 | Move word to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        public static AsmStatement<R32<T>,R16<S>> movzx<T,S>(R32<T> dst, R16<S> src)
            where T : unmanaged, IRegOp32
            where S : unmanaged, IRegOp16
                => asm.statement(movzx(), dst, src);

        /// <summary>
        /// 0F B7 / r | MOVZX r32, r16 | Move word to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<R32,R16> movzx(R32 dst, R16 src)
            => asm.statement(movzx(), dst, src);

        /// <summary>
        /// 0F B7 / r | MOVZX r32, m16 | Move word to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        public static AsmStatement<R32<T>,m16> movzx<T>(R32<T> dst, m16 src)
            where T : unmanaged, IRegOp32
                => asm.statement(movzx(), dst, src);

        /// <summary>
        /// 0F B7 / r | MOVZX r32, m16 | Move word to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<R32,m16> movzx(R32 dst, m16 src)
            => asm.statement(movzx(), dst, src);

        /// <summary>
        /// REX.W + 0F B7 / r | MOVZX r64, r16 | Move word to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        public static AsmStatement<R64<T>,R16<S>> movzx<T,S>(R64<T> dst, R16<S> src)
            where T : unmanaged, IRegOp64
            where S : unmanaged, IRegOp16
                => asm.statement(movzx(), dst, src);

        /// <summary>
        /// REX.W + 0F B7 / r | MOVZX r64, r16 | Move word to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<R64,R16> movzx<T,S>(R64 dst, R16 src)
            => asm.statement(movzx(), dst, src);

        /// <summary>
        /// REX.W + 0F B7 / r | MOVZX r64, m16 | Move word to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        public static AsmStatement<R64<T>,m16> movzx<T>(R64<T> dst, m16 src)
            where T : unmanaged, IRegOp64
                => asm.statement(movzx(), dst, src);

        /// <summary>
        /// REX.W + 0F B7 / r | MOVZX r64, m16 | Move word to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<R64,m16> movzx(R64 dst, m16 src)
            => asm.statement(movzx(), dst, src);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmRegs;
    using static AsmMem;

    using I = AsmInstructions;

    partial struct Asmstatements
    {
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
                => asm.statement(I.movzx(), dst, src);

        /// <summary>
        /// | 0F B6 / r | MOVZX r16, r8 | Move byte to word with zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<r16,r8> movzx(r16 dst, r8 src)
            => asm.statement(I.movzx(), dst, src);

        /// <summary>
        /// | 0F B6 / r | MOVZX r16, m8 | Move byte to word with zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The memory source</param>
        /// <typeparam name="T">The target register type</typeparam>
        public static AsmStatement<R16<T>,m8> movzx<T>(R16<T> dst, m8 src)
            where T : unmanaged, IRegOp16
                => asm.statement(I.movzx(), dst, src);

        /// <summary>
        /// | 0F B6 / r | MOVZX r16, m8 | Move byte to word with zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The memory source</param>
        /// <typeparam name="T">The target register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<r16,m8> movzx(r16 dst, m8 src)
            => asm.statement(I.movzx(), dst, src);

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
                => asm.statement(I.movzx(), dst, src);

        /// <summary>
        /// 0F B6 / r | MOVZX r32, r8 | Move byte to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<r32,r8> movzx(r32 dst, r8 src)
            => asm.statement(I.movzx(), dst, src);

        /// <summary>
        /// 0F B6 / r | MOVZX r32, m8 | Move byte to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        public static AsmStatement<R32<T>,m8> movzx<T>(R32<T> dst, m8 src)
            where T : unmanaged, IRegOp32
                => asm.statement(I.movzx(), dst, src);

        /// <summary>
        /// 0F B6 / r | MOVZX r32, m8 | Move byte to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<r32,m8> movzx(r32 dst, m8 src)
            => asm.statement(I.movzx(), dst, src);

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
                => asm.statement(I.movzx(), dst, src);

        /// <summary>
        /// REX.W + 0F B6 / r | MOVZX r64, r8 | Move byte to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<r64,r8> movzx(r64 dst, r8 src)
            => asm.statement(I.movzx(), dst, src);

        /// <summary>
        /// REX.W + 0F B6 / r | MOVZX r64, m8 | Move byte to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        public static AsmStatement<R64<T>,m8> movzx<T>(R64<T> dst, m8 src)
            where T : unmanaged, IRegOp64
                => asm.statement(I.movzx(), dst, src);

        /// <summary>
        /// REX.W + 0F B6 / r | MOVZX r64, m8 | Move byte to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<r64,m8> movzx<T>(r64 dst, m8 src)
            => asm.statement(I.movzx(), dst, src);

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
                => asm.statement(I.movzx(), dst, src);

        /// <summary>
        /// 0F B7 / r | MOVZX r32, r16 | Move word to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<r32,r16> movzx(r32 dst, r16 src)
            => asm.statement(I.movzx(), dst, src);

        /// <summary>
        /// 0F B7 / r | MOVZX r32, m16 | Move word to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        public static AsmStatement<R32<T>,m16> movzx<T>(R32<T> dst, m16 src)
            where T : unmanaged, IRegOp32
                => asm.statement(I.movzx(), dst, src);

        /// <summary>
        /// 0F B7 / r | MOVZX r32, m16 | Move word to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<r32,m16> movzx(r32 dst, m16 src)
            => asm.statement(I.movzx(), dst, src);

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
                => asm.statement(I.movzx(), dst, src);

        /// <summary>
        /// REX.W + 0F B7 / r | MOVZX r64, r16 | Move word to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<r64,r16> movzx<T,S>(r64 dst, r16 src)
            => asm.statement(I.movzx(), dst, src);

        /// <summary>
        /// REX.W + 0F B7 / r | MOVZX r64, m16 | Move word to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        public static AsmStatement<R64<T>,m16> movzx<T>(R64<T> dst, m16 src)
            where T : unmanaged, IRegOp64
                => asm.statement(I.movzx(), dst, src);

        /// <summary>
        /// REX.W + 0F B7 / r | MOVZX r64, m16 | Move word to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        [MethodImpl(Inline), Op]
        public static AsmStatement<r64,m16> movzx(r64 dst, m16 src)
            => asm.statement(I.movzx(), dst, src);
    }
}
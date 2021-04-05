//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmInstructions;
    using static Hex8Seq;
    using static AsmRegOps;
    using static AsmMemOps;


    partial struct AsmStatement
    {
        /// <summary>
        /// | 0F B6 /r | MOVZX r16, r8 | Move byte to word with zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public Movzx movzx(r16 dst, r8 src)
            => Builder.movzx();

        /// <summary>
        /// | 0F B6 /r | MOVZX r16, m8 | Move byte to word with zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The memory source</param>
        /// <typeparam name="T">The target register type</typeparam>
        public Movzx movzx(r16 dst, m8 src)
            => Builder.movzx();

        /// <summary>
        /// 0F B6 /r | MOVZX r32, r8 | Move byte to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public Movzx movzx(r32 dst, r8 src)
            => Builder.movzx();

        /// <summary>
        /// 0F B6 /r | MOVZX r32, m8 | Move byte to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        public Movzx movzx(r32 dst, m8 src)
            => Builder.movzx();

        /// <summary>
        /// REX.W + 0F B6 /r | MOVZX r64, r8 | Move byte to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public Movzx movzx(r64 dst, r8 src)
            => Builder.movzx();

        /// <summary>
        /// REX.W + 0F B6 /r | MOVZX r64, m8 | Move byte to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        public Movzx movzx(r64 dst, m8 src)
            => Builder.movzx();

        /// <summary>
        /// 0F B7 /r | MOVZX r32, r16 | Move word to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        /// <typeparam name="S">The source register type</typeparam>
        [MethodImpl(Inline), Op]
        public Movzx movzx(r32 dst, r16 src)
            => Builder.movzx();

        /// <summary>
        /// 0F B7 /r | MOVZX r32, m16 | Move word to doubleword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        [MethodImpl(Inline), Op]
        public Movzx movzx(r32 dst, m16 src)
            => Builder.movzx();

        /// <summary>
        /// REX.W + 0F B7 /r | MOVZX r64, m16 | Move word to quadword, zero-extension.
        /// </summary>
        /// <param name="dst">The target register</param>
        /// <param name="src">The source register</param>
        /// <typeparam name="T">The target register type</typeparam>
        [MethodImpl(Inline), Op]
        public Movzx movzx(r64 dst, m16 src)
            => Builder.movzx();
    }
}
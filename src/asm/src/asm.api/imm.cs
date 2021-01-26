//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct asm
    {
        /// <summary>
        /// Creates an immediate operand
        /// </summary>
        /// <param name="src">The defining source value</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static ImmOp<T> imm<T>(byte pos, T src)
            where T : unmanaged, IImmediate<T>
                => new ImmOp<T>(pos, src);

        [MethodImpl(Inline), Op]
        public Imm8Op imm8(byte pos, Imm8 value)
            => new Imm8Op(pos, value);

        [MethodImpl(Inline), Op]
        public Imm16Op imm16(byte pos, Imm16 value)
            => new Imm16Op(pos, value);

        [MethodImpl(Inline), Op]
        public Imm32Op imm32(byte pos, Imm32 value)
            => new Imm32Op(pos, value);

        [MethodImpl(Inline), Op]
        public Imm64Op imm64(byte pos, Imm64 value)
            => new Imm64Op(pos,value);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmImm;

    partial struct asm
    {
        [MethodImpl(Inline)]
        public static AsmInstruction generalize<T>(T src)
            where T : unmanaged, ITypedInstruction<T>
                => new AsmInstruction(AsmBytes.hexcode(src));

        /// <summary>
        /// Creates an immediate operand
        /// </summary>
        /// <param name="src">The defining source value</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static imm<T> imm<T>(T src)
            where T : unmanaged, IImmediate<T>
                => new imm<T>(src);

        [MethodImpl(Inline), Op]
        public static imm8 imm8(Cell8 value)
            => new imm8(value);

        [MethodImpl(Inline), Op]
        public static imm16 imm16(Cell16 value)
            => new imm16(value);

        [MethodImpl(Inline), Op]
        public static imm32 imm32(Cell32 value)
            => new imm32(value);

        [MethodImpl(Inline), Op]
        public static imm64 imm64(Cell64 value)
            => new imm64(value);
    }
}
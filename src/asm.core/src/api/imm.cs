//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct asm
    {
        /// <summary>
        /// Defines an 8-bit immediate operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Imm8 imm8(byte src)
            => new Imm8(src);

        /// <summary>
        /// Defines a 16-bit immediate operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Imm16 imm16(ushort src)
            => new Imm16(src);

        /// <summary>
        /// Defines a 32-bit immediate operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Imm32 imm32(uint src)
            => new Imm32(src);

        /// <summary>
        /// Defines a 64-bit immediate operand
        /// </summary>
        /// <param name="src">The source value</param>
        [MethodImpl(Inline), Op]
        public static Imm64 imm64(uint src)
            => new Imm64(src);

        /// <summary>
        /// Defines a T-parametric 8-bit immediate operand
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The storage type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static Imm8<T> imm8<T>(T src)
            where T : unmanaged
                => new Imm8<T>(src);

        /// <summary>
        /// Defines a T-parametric 16-bit immediate operand
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The storage type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt8k | UInt16k)]
        public static Imm16<T> imm16<T>(T src)
            where T : unmanaged
                => new Imm16<T>(src);

        /// <summary>
        /// Defines a T-parametric 32-bit immediate operand
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The storage type</typeparam>
        [MethodImpl(Inline), Op, Closures(UInt8k | UInt16k | UInt32k)]
        public static Imm32<T> imm32<T>(T src)
            where T : unmanaged
                => new Imm32<T>(src);

        /// <summary>
        /// Defines a T-parametric 64-bit immediate operand
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The storage type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Imm64<T> imm64<T>(T src)
            where T : unmanaged
                => new Imm64<T>(src);
    }
}
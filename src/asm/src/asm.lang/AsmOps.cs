//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost(ApiNames.AsmOperands, true)]
    public readonly struct AsmOps
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Creates an immediate operand
        /// </summary>
        /// <param name="src">The defining source value</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ImmOp<T> imm<T>(byte pos, T src)
            where T : unmanaged, IImmediate<T>
                => new ImmOp<T>(pos, src);

        /// <summary>
        /// Creates a memory operand
        /// </summary>
        /// <param name="src">The defining source value</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static MemOp<T> mem<T>(byte pos, T src)
            where T : unmanaged, IMemOp
                => new MemOp<T>(pos, src);

        /// <summary>
        /// Creates a register operand
        /// </summary>
        /// <param name="src">The defining source value</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static RegOp<T> reg<T>(byte pos, T src)
            where T : unmanaged, IRegister
                => new RegOp<T>(pos, src);

        [MethodImpl(Inline)]
        public static AsmOp<T> unify<T>(T src)
            where T : unmanaged, IAsmOperand<T>
                => new AsmOp<T>(src.Position, src);
    }
}
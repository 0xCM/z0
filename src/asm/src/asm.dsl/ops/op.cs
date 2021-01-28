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
        /// Generalizes a <see cref='IAsmOperand{T}'/> reification
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static AsmOp<T> op<T>(T src)
            where T : unmanaged, IAsmOperand<T>
                => new AsmOp<T>(src.Position, src);
    }
}
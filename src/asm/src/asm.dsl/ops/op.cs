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
        /// Generalizes a <see cref='IAsmOp{T}'/> reification
        /// </summary>
        /// <param name="src">The source operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static AsmOp<T> op<T>(AsmOpKind kind, T content)
            where T : struct, IAsmOpContent
                => new AsmOp<T>(kind, content);
    }
}
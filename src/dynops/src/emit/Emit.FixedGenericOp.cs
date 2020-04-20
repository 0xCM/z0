//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Dynop
    {
        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary operator over the buffer
        /// </summary>
        /// <param name="buffer">The target buffer</param>
        /// <param name="src">The executable source</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        public static FixedUnaryOp<F> EmitFixedUnaryOp<F>(this IBufferToken dst, in IdentifiedCode src)
            => (FixedUnaryOp<F>)dst.Handle.EmitFixed(src.Id,  typeof(FixedUnaryOp<F>), typeof(F), typeof(F));

        /// <summary>
        /// Loads source into a token-identifed buffer and covers it with a fixed binary operator
        /// </summary>
        /// <param name="buffer">The target buffer</param>
        /// <param name="src">The code to load</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        public static FixedBinaryOp<F> EmitFixedBinaryOp<F>(this IBufferToken buffer, in IdentifiedCode src)
            => (FixedBinaryOp<F>)buffer.Load(src.BinaryCode).EmitFixedBinaryOp(src.Id, typeof(FixedBinaryOp<F>), typeof(F));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary operator over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        public static FixedTernaryOp<F> EmitFixedTernaryOp<F>(this IBufferToken dst, in IdentifiedCode src)
            => (FixedTernaryOp<F>)dst.Handle.EmitFixed(src.Id, typeof(FixedTernaryOp<F>), typeof(F), typeof(F), typeof(F), typeof(F));
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class Dynop
    {
        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary operator over the buffer
        /// </summary>
        /// <param name="buffer">The target buffer</param>
        /// <param name="src">The executable source</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        public static FixedUnaryOp<F> EmitFixedUnaryOp<F>(this BufferToken dst, ApiHex src)
            => (FixedUnaryOp<F>)dst.Handle.EmitFixed(src.Id,  typeof(FixedUnaryOp<F>), typeof(F), typeof(F));

        /// <summary>
        /// Loads source into a token-identified buffer and covers it with a fixed binary operator
        /// </summary>
        /// <param name="buffer">The target buffer</param>
        /// <param name="src">The code to load</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        public static FixedBinaryOp<F> EmitFixedBinaryOp<F>(this BufferToken buffer, ApiHex src)
            => (FixedBinaryOp<F>)buffer.Load(src.Encoded).EmitFixedBinaryOp(src.Id, typeof(FixedBinaryOp<F>), typeof(F));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary operator over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        public static FixedTernaryOp<F> EmitFixedTernaryOp<F>(this BufferToken dst, ApiHex src)
            => (FixedTernaryOp<F>)dst.Handle.EmitFixed(src.Id, typeof(FixedTernaryOp<F>), typeof(F), typeof(F), typeof(F), typeof(F));
    }
}
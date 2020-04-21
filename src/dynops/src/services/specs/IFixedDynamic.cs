//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IFixedDynamic : IService
    {
        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary operator over the buffer
        /// </summary>
        /// <param name="buffer">The target buffer</param>
        /// <param name="src">The executable source</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        FixedUnaryOp<F> EmitFixedUnary<F>(IBufferToken dst, in IdentifiedCode src);

        /// <summary>
        /// Loads source into a token-identifed buffer and covers it with a fixed binary operator
        /// </summary>
        /// <param name="buffer">The target buffer</param>
        /// <param name="src">The code to load</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        FixedBinaryOp<F> EmitFixedBinary<F>(IBufferToken buffer, in IdentifiedCode src);

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary operator over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        FixedTernaryOp<F> EmitFixedTernary<F>(IBufferToken dst, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 8-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        UnaryOp8 EmitFixedUnary(IBufferToken dst, W8 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 16-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        UnaryOp16 EmitFixedUnary(IBufferToken dst, W16 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 32-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        UnaryOp32 EmitFixedUnary(IBufferToken dst, W32 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 64-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        UnaryOp64 EmitFixedUnary(IBufferToken dst, W64 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 128-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        UnaryOp128 EmitFixedUnary(IBufferToken dst, W128 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 256-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        UnaryOp256 EmitFixedUnary(IBufferToken dst, W256 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 8-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        BinaryOp8 EmitFixedBinary(IBufferToken dst, W8 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        BinaryOp16 EmitFixedBinary(IBufferToken dst, W16 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        BinaryOp32 EmitFixedBinary(IBufferToken dst, W32 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        BinaryOp64 EmitFixedBinary(IBufferToken dst, W64 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 128-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        BinaryOp128 EmitFixedBinary(IBufferToken dst, W128 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        BinaryOp256 EmitFixedBinary(IBufferToken dst, W256 w, in IdentifiedCode src);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using U = Kinds.UnaryOpClass;
    using B = Kinds.BinaryOpClass;
    using T = Kinds.TernaryOpClass;

    public interface IFixedDynamic : IService
    {
        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary operator over the buffer
        /// </summary>
        /// <param name="buffer">The target buffer</param>
        /// <param name="src">The executable source</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        FixedUnaryOp<F> Emit<F>(IBufferToken dst, U op, in IdentifiedCode src);

        /// <summary>
        /// Loads source into a token-identifed buffer and covers it with a fixed binary operator
        /// </summary>
        /// <param name="buffer">The target buffer</param>
        /// <param name="src">The code to load</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        FixedBinaryOp<F> Emit<F>(IBufferToken buffer, B op, in IdentifiedCode src);

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary operator over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        FixedTernaryOp<F> Emit<F>(IBufferToken dst, T op, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 8-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        UnaryOp8 Emit(IBufferToken dst, U op, W8 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 16-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        UnaryOp16 Emit(IBufferToken dst, U op, W16 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 32-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        UnaryOp32 Emit(IBufferToken dst, U op, W32 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 64-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        UnaryOp64 Emit(IBufferToken dst, U op, W64 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 128-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        UnaryOp128 Emit(IBufferToken dst, U op, W128 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 256-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        UnaryOp256 Emit(IBufferToken dst, U op, W256 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 8-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        BinaryOp8 Emit(IBufferToken dst, B op, W8 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        BinaryOp16 Emit(IBufferToken dst, B op, W16 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        BinaryOp32 Emit(IBufferToken dst, B op, W32 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        BinaryOp64 Emit(IBufferToken dst, B op, W64 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 128-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        BinaryOp128 Emit(IBufferToken dst, B op, W128 w, in IdentifiedCode src);

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        BinaryOp256 Emit(IBufferToken dst, B op, W256 w, in IdentifiedCode src);
    }
}
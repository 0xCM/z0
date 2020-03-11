//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class Dynop
    {
        /// <summary>
        /// Forms a unary operator over an identified buffer
        /// </summary>
        /// <param name="buffer">The target buffer</param>
        /// <param name="id">The operation identifier</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryOp<T> AsUnaryOp<T>(this IBufferToken buffer, OpIdentity id)
            where T : unmanaged
                => (UnaryOp<T>)buffer.AsFixedUnaryOp(id,typeof(UnaryOp<T>), typeof(T));

        /// <summary>
        /// Forms a binary operator over an identified buffer
        /// </summary>
        /// <param name="buffer">The target buffer</param>
        /// <param name="id">The operation identifier</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryOp<T> AsBinaryOp<T>(this IBufferToken buffer, OpIdentity id)
            where T : unmanaged
                => (BinaryOp<T>)buffer.AsFixedBinaryOp(id,typeof(BinaryOp<T>), typeof(T));

        /// <summary>
        /// Forms a ternary operator over an identified buffer
        /// </summary>
        /// <param name="buffer">The target buffer</param>
        /// <param name="id">The operation identifier</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static TernaryOp<T> AsTernaryOp<T>(this IBufferToken buffer, OpIdentity id)
            where T : unmanaged
                => (TernaryOp<T>)buffer.AsFixedTernaryOp(id,typeof(TernaryOp<T>), typeof(T));
    }
}
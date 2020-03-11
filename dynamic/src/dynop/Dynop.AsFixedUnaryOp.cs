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
        [MethodImpl(Inline)]
        static FixedDelegate AsFixedUnaryOp(this IBufferToken buffer, OpIdentity id, Type operatorType, Type operandType)        
            => buffer.Handle.EmitFixedAdapter(id, functype: operatorType, result: operandType, args: operandType);

        /// <summary>
        /// Presents an identified buffer as a 8-bit fixed unary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp8 AsFixedUnaryOp(this IBufferToken buffer, N8 w, OpIdentity id)
            => (UnaryOp8)buffer.AsFixedUnaryOp(id, typeof(UnaryOp8), typeof(Fixed8));

        /// <summary>
        /// Presents an identified buffer as a 16-bit fixed unary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp16 AsFixedUnaryOp(this IBufferToken buffer, N16 w, OpIdentity id)
            => (UnaryOp16)buffer.AsFixedUnaryOp(id, typeof(UnaryOp16), typeof(Fixed16));

        /// <summary>
        /// Presents an identified buffer as a 32-bit fixed unary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp32 AsFixedUnaryOp(this IBufferToken buffer, N32 w, OpIdentity id)
            => (UnaryOp32)buffer.AsFixedUnaryOp(id, typeof(UnaryOp32), typeof(Fixed32));

        /// <summary>
        /// Presents an identified buffer as a 64-bit fixed unary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp64 AsFixedUnaryOp(this IBufferToken buffer, N64 w, OpIdentity id)
            => (UnaryOp64)buffer.AsFixedUnaryOp(id, typeof(UnaryOp64), typeof(Fixed64));

        /// <summary>
        /// Presents an identified buffer as a 128-bit fixed unary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp128 AsFixedUnaryOp(this IBufferToken buffer, N128 w, OpIdentity id)
            => (UnaryOp128)buffer.AsFixedUnaryOp(id, typeof(UnaryOp128), typeof(Fixed128));

        /// <summary>
        /// Presents an identified buffer as a 256-bit fixed unary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp256 AsFixedUnaryOp(this IBufferToken buffer, N256 w, OpIdentity id)
            => (UnaryOp256)buffer.AsFixedUnaryOp(id, typeof(UnaryOp256), typeof(Fixed256));
    }
}
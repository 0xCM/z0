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
        static FixedDelegate AsFixedBinaryOp(this IBufferToken buffer, OpIdentity id, Type operatorType, Type operandType)        
            => buffer.Handle.EmitFixedAdapter(id,functype:operatorType, result:operandType, args: array(operandType, operandType));

        /// <summary>
        /// Presents an identified buffer as an 8-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp8 AsFixedBinaryOp(this IBufferToken buffer, N8 w,OpIdentity id)
            => (BinaryOp8)buffer.AsFixedBinaryOp(id, typeof(BinaryOp8), typeof(Fixed8));

        /// <summary>
        /// Presents an identified buffer as a 16-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp16 AsFixedBinaryOp(this IBufferToken buffer, N16 w, OpIdentity id)
            => (BinaryOp16)buffer.AsFixedBinaryOp(id, typeof(BinaryOp16), typeof(Fixed16));

        /// <summary>
        /// Presents an identified buffer as a 32-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp32 AsFixedBinaryOp(this IBufferToken buffer,N32 w, OpIdentity id)
            => (BinaryOp32)buffer.AsFixedBinaryOp(id, typeof(BinaryOp32), typeof(Fixed32));

        /// <summary>
        /// Presents an identified buffer as a 64-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp64 AsFixedBinaryOp(this IBufferToken buffer, N64 w, OpIdentity id)
            => (BinaryOp64)buffer.AsFixedBinaryOp(id, typeof(BinaryOp64), typeof(Fixed64));

        /// <summary>
        /// Presents an identified buffer as a 128-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp128 AsFixedBinaryOp(this IBufferToken buffer, N128 w, OpIdentity id)
            => (BinaryOp128)buffer.AsFixedBinaryOp(id, typeof(BinaryOp128), typeof(Fixed128));

        /// <summary>
        /// Presents an identified buffer as a 256-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp256 AsFixedBinaryOp(this IBufferToken buffer, N256 w, OpIdentity id)
            => (BinaryOp256)buffer.AsFixedBinaryOp(id, typeof(BinaryOp256), typeof(Fixed256));
    }
}
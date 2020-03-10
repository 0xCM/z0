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
        /// Presents an identified buffer as a 8-bit fixed unary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp8 AsFixedUnaryOp(this BufferToken buffer, N8 w, OpIdentity id)
            => (UnaryOp8)buffer.FixedUnaryAdapter(id, typeof(UnaryOp8), typeof(Fixed8));

        /// <summary>
        /// Presents an identified buffer as a 16-bit fixed unary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp16 AsFixedUnaryOp(this BufferToken buffer, N16 w, OpIdentity id)
            => (UnaryOp16)buffer.FixedUnaryAdapter(id, typeof(UnaryOp16), typeof(Fixed16));

        /// <summary>
        /// Presents an identified buffer as a 32-bit fixed unary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp32 AsFixedUnaryOp(this BufferToken buffer, N32 w, OpIdentity id)
            => (UnaryOp32)buffer.FixedUnaryAdapter(id, typeof(UnaryOp32), typeof(Fixed32));

        /// <summary>
        /// Presents an identified buffer as a 64-bit fixed unary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp64 AsFixedUnaryOp(this BufferToken buffer, N64 w, OpIdentity id)
            => (UnaryOp64)buffer.FixedUnaryAdapter(id, typeof(UnaryOp64), typeof(Fixed64));

        /// <summary>
        /// Presents an identified buffer as a 128-bit fixed unary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp128 AsFixedUnaryOp(this BufferToken buffer, N128 w, OpIdentity id)
            => (UnaryOp128)buffer.FixedUnaryAdapter(id, typeof(UnaryOp128), typeof(Fixed128));

        /// <summary>
        /// Presents an identified buffer as a 256-bit fixed unary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp256 AsFixedUnaryOp(this BufferToken buffer, N256 w, OpIdentity id)
            => (UnaryOp256)buffer.FixedUnaryAdapter(id, typeof(UnaryOp256), typeof(Fixed256));

        /// <summary>
        /// Presents an identified buffer as an 8-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp8 AsFixedBinaryOp(this BufferToken buffer, N8 w,OpIdentity id)
            => (BinaryOp8)buffer.FixedBinaryAdapter(id, typeof(BinaryOp8), typeof(Fixed8));

        /// <summary>
        /// Presents an identified buffer as a 16-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp16 AsFixedBinaryOp(this BufferToken buffer, N16 w, OpIdentity id)
            => (BinaryOp16)buffer.FixedBinaryAdapter(id, typeof(BinaryOp16), typeof(Fixed16));

        /// <summary>
        /// Presents an identified buffer as a 32-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp32 AsFixedBinaryOp(this BufferToken buffer,N32 w, OpIdentity id)
            => (BinaryOp32)buffer.FixedBinaryAdapter(id, typeof(BinaryOp32), typeof(Fixed32));

        /// <summary>
        /// Presents an identified buffer as a 64-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp64 AsFixedBinaryOp(this BufferToken buffer, N64 w, OpIdentity id)
            => (BinaryOp64)buffer.FixedBinaryAdapter(id, typeof(BinaryOp64), typeof(Fixed64));

        /// <summary>
        /// Presents an identified buffer as a 128-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp128 AsFixedBinaryOp(this BufferToken buffer, N128 w, OpIdentity id)
            => (BinaryOp128)buffer.FixedBinaryAdapter(id, typeof(BinaryOp128), typeof(Fixed128));

        /// <summary>
        /// Presents an identified buffer as a 256-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp256 AsFixedBinaryOp(this BufferToken buffer, N256 w, OpIdentity id)
            => (BinaryOp256)buffer.FixedBinaryAdapter(id, typeof(BinaryOp256), typeof(Fixed256));
    }
}
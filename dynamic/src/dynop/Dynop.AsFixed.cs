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
        public static FixedUnaryOp8 AsFixedUnaryOp(this BufferToken buffer, N8 w, OpIdentity id)
            => (FixedUnaryOp8)buffer.FixedUnaryAdapter(id, typeof(FixedUnaryOp8), typeof(Fixed8));

        /// <summary>
        /// Presents an identified buffer as a 16-bit fixed unary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static FixedUnaryOp16 AsFixedUnaryOp(this BufferToken buffer, N16 w, OpIdentity id)
            => (FixedUnaryOp16)buffer.FixedUnaryAdapter(id, typeof(FixedUnaryOp16), typeof(Fixed16));

        /// <summary>
        /// Presents an identified buffer as a 32-bit fixed unary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static FixedUnaryOp32 AsFixedUnaryOp(this BufferToken buffer, N32 w, OpIdentity id)
            => (FixedUnaryOp32)buffer.FixedUnaryAdapter(id, typeof(FixedUnaryOp32), typeof(Fixed32));

        /// <summary>
        /// Presents an identified buffer as a 64-bit fixed unary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static FixedUnaryOp64 AsFixedUnaryOp(this BufferToken buffer, N64 w, OpIdentity id)
            => (FixedUnaryOp64)buffer.FixedUnaryAdapter(id, typeof(FixedUnaryOp64), typeof(Fixed64));

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
        public static FixedUnaryOp256 AsFixedUnaryOp(this BufferToken buffer, N256 w, OpIdentity id)
            => (FixedUnaryOp256)buffer.FixedUnaryAdapter(id, typeof(FixedUnaryOp256), typeof(Fixed256));

        /// <summary>
        /// Presents an identified buffer as an 8-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static FixedBinaryOp8 AsFixedBinaryOp(this BufferToken buffer, N8 w,OpIdentity id)
            => (FixedBinaryOp8)buffer.FixedBinaryAdapter(id, typeof(FixedBinaryOp8), typeof(Fixed8));

        /// <summary>
        /// Presents an identified buffer as a 16-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static FixedBinaryOp16 AsFixedBinaryOp(this BufferToken buffer, N16 w, OpIdentity id)
            => (FixedBinaryOp16)buffer.FixedBinaryAdapter(id, typeof(FixedBinaryOp16), typeof(Fixed16));

        /// <summary>
        /// Presents an identified buffer as a 32-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static FixedBinaryOp32 AsFixedBinaryOp(this BufferToken buffer,N32 w, OpIdentity id)
            => (FixedBinaryOp32)buffer.FixedBinaryAdapter(id, typeof(FixedBinaryOp32), typeof(Fixed32));

        /// <summary>
        /// Presents an identified buffer as a 64-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static FixedBinaryOp64 AsFixedBinaryOp(this BufferToken buffer, N64 w, OpIdentity id)
            => (FixedBinaryOp64)buffer.FixedBinaryAdapter(id, typeof(FixedBinaryOp64), typeof(Fixed64));

        /// <summary>
        /// Presents an identified buffer as a 128-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static FixedBinaryOp128 AsFixedBinaryOp(this BufferToken buffer, N128 w, OpIdentity id)
            => (FixedBinaryOp128)buffer.FixedBinaryAdapter(id, typeof(FixedBinaryOp128), typeof(Fixed128));

        /// <summary>
        /// Presents an identified buffer as a 256-bit fixed binary operator
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="id">The identity to bestow upon the operator</param>
        [MethodImpl(Inline)]
        public static FixedBinaryOp256 AsFixedBinaryOp(this BufferToken buffer, N256 w, OpIdentity id)
            => (FixedBinaryOp256)buffer.FixedBinaryAdapter(id, typeof(FixedBinaryOp256), typeof(Fixed256));
    }
}
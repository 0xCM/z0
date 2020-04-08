//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;

    partial class Dynop
    {
        /// <summary>
        /// Creates a fixed 8-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp8 EmitFixedBinaryOp(this IBufferToken buffer, N8 w, in IdentifiedCode src)
            => buffer.Load(src.BinaryCode).EmitFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp16 EmitFixedBinaryOp(this IBufferToken buffer, N16 w, in IdentifiedCode src)
            => buffer.Load(src.BinaryCode).EmitFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp32 EmitFixedBinaryOp(this IBufferToken buffer, N32 w, in IdentifiedCode src)
            => buffer.Load(src.BinaryCode).EmitFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp64 EmitFixedBinaryOp(this IBufferToken buffer, N64 w, in IdentifiedCode src)
            => buffer.Load(src.BinaryCode).EmitFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 128-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp128 EmitFixedBinaryOp(this IBufferToken buffer, N128 w, in IdentifiedCode src)
            => buffer.Load(src.BinaryCode).EmitFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp256 EmitFixedBinaryOp(this IBufferToken buffer, N256 w, in IdentifiedCode src)
            => buffer.Load(src.BinaryCode).EmitFixedBinaryOp(w, src.Id);  
    }
}
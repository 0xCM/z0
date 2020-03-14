//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static FKT;
    using static Nats;

    partial class Dynop
    {
        /// <summary>
        /// Creates a fixed 8-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UnaryOp8 EmitFixedUnaryOp(this IBufferToken dst, N8 w, in ApiCode src)
            => dst.Load(src).EmitFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 16-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UnaryOp16 EmitFixedUnaryOp(this IBufferToken dst, N16 w, in ApiCode src)               
            => dst.Load(src.BinaryCode).EmitFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 32-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UnaryOp32 EmitFixedUnaryOp(this IBufferToken dst, N32 w, in ApiCode src)
            => dst.Load(src.BinaryCode).EmitFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 64-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UnaryOp64 EmitFixedUnaryOp(this IBufferToken dst, N64 w, in ApiCode src)
            => dst.Load(src.BinaryCode).EmitFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 128-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UnaryOp128 EmitFixedUnaryOp(this IBufferToken dst, N128 w, in ApiCode src)
            => dst.Load(src.BinaryCode).EmitFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 256-bit unary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static UnaryOp256 EmitFixedUnaryOp(this IBufferToken dst, N256 w, in ApiCode src)
            => dst.Load(src.BinaryCode).EmitFixedUnaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 8-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp8 EmitFixedBinaryOp(this IBufferToken buffer, N8 w, in ApiCode src)
            => buffer.Load(src.BinaryCode).EmitFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp16 EmitFixedBinaryOp(this IBufferToken buffer, N16 w, in ApiCode src)
            => buffer.Load(src.BinaryCode).EmitFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Loads source into the identifed buffer and covers it with a fixed binary operator
        /// </summary>
        /// <param name="buffer">The target buffer</param>
        /// <param name="src">The soruce to load</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        [MethodImpl(Inline)]
        public static FixedBinaryOp<F> EmitFixedBinaryOp<F>(this IBufferToken buffer, in ApiCode src)
            where F : unmanaged, IFixed
                => (FixedBinaryOp<F>)buffer.Load(src.BinaryCode).EmitFixedBinaryOp(src.Id, typeof(FixedBinaryOp<F>), typeof(F));

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp32 EmitFixedBinaryOp(this IBufferToken buffer, N32 w, in ApiCode src)
            => buffer.Load(src.BinaryCode).EmitFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp64 EmitFixedBinaryOp(this IBufferToken buffer, N64 w, in ApiCode src)
            => buffer.Load(src.BinaryCode).EmitFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 128-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp128 EmitFixedBinaryOp(this IBufferToken buffer, N128 w, in ApiCode src)
            => buffer.Load(src.BinaryCode).EmitFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp256 EmitFixedBinaryOp(this IBufferToken buffer, N256 w, in ApiCode src)
            => buffer.Load(src.BinaryCode).EmitFixedBinaryOp(w, src.Id);  
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Dynop
    {
        /// <summary>
        /// Creates a fixed 8-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp8 EmitFixedBinaryOp(this BufferToken buffer, N8 w, ApiCodeBlock src)
            => buffer.Load(src.Encoded).EmitFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp16 EmitFixedBinaryOp(this BufferToken buffer, N16 w, ApiCodeBlock src)
            => buffer.Load(src.Encoded).EmitFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp32 EmitFixedBinaryOp(this BufferToken buffer, N32 w, ApiCodeBlock src)
            => buffer.Load(src.Encoded).EmitFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp64 EmitFixedBinaryOp(this BufferToken buffer, N64 w, ApiCodeBlock src)
            => buffer.Load(src.Encoded).EmitFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 128-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp128 EmitFixedBinaryOp(this BufferToken buffer, N128 w, ApiCodeBlock src)
            => buffer.Load(src.Encoded).EmitFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="buffer">Identifies the target buffer</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp256 EmitFixedBinaryOp(this BufferToken buffer, N256 w, ApiCodeBlock src)
            => buffer.Load(src.Encoded).EmitFixedBinaryOp(w, src.Id);

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary function over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        public static FixedFunc<X0,R> EmitFixedFunc<X0,R>(this BufferToken dst, ApiCodeBlock src)
            => (FixedFunc<X0,R>)dst.Handle.EmitFixed(src.Id, typeof(FixedFunc<X0,R>), typeof(R), typeof(X0));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed binary function over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        public static FixedFunc<X0,X1,R> EmitFixedFunc<X0,X1,R>(this BufferToken dst, ApiCodeBlock src)
            => (FixedFunc<X0,X1,R>)dst.Handle.EmitFixed(src.Id, typeof(FixedFunc<X0,X1,R>), typeof(R), typeof(X0), typeof(X1));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed binary function over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        public static FixedFunc<X0,X1,X2,R> EmitFixedFunc<X0,X1,X2,R>(this BufferToken dst, ApiCodeBlock src)
            => (FixedFunc<X0,X1,X2,R>)dst.Handle.EmitFixed(src.Id, typeof(FixedFunc<X0,X1,X2,R>), typeof(R), typeof(X0), typeof(X1), typeof(X2));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary operator over the buffer
        /// </summary>
        /// <param name="buffer">The target buffer</param>
        /// <param name="src">The executable source</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        public static FixedUnaryOp<F> EmitFixedUnaryOp<F>(this BufferToken dst, ApiCodeBlock src)
            => (FixedUnaryOp<F>)dst.Handle.EmitFixed(src.Id,  typeof(FixedUnaryOp<F>), typeof(F), typeof(F));

        /// <summary>
        /// Loads source into a token-identified buffer and covers it with a fixed binary operator
        /// </summary>
        /// <param name="buffer">The target buffer</param>
        /// <param name="src">The code to load</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        public static FixedBinaryOp<F> EmitFixedBinaryOp<F>(this BufferToken buffer, ApiCodeBlock src)
            => (FixedBinaryOp<F>)buffer.Load(src.Encoded).EmitFixedBinaryOp(src.Id, typeof(FixedBinaryOp<F>), typeof(F));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary operator over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        public static FixedTernaryOp<F> EmitFixedTernaryOp<F>(this BufferToken dst, ApiCodeBlock src)
            => (FixedTernaryOp<F>)dst.Handle.EmitFixed(src.Id, typeof(FixedTernaryOp<F>), typeof(F), typeof(F), typeof(F), typeof(F));

        /// <summary>
        /// Loads executable code into a token-identified buffer and covers it with a parametric unary operator
        /// </summary>
        /// <param name="buffer">The buffer token</param>
        /// <param name="src">The code to load</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static UnaryOp<T> EmitUnaryOp<T>(this BufferToken buffer, ApiCodeBlock src)
            where T : unmanaged
                => buffer.Load(src.Encoded).EmitUnaryOp<T>(src.Id);

        /// <summary>
        /// Loads executable code into a token-identified buffer and covers it with a parametric binary operator
        /// </summary>
        /// <param name="buffer">The buffer token</param>
        /// <param name="src">The code to load</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static BinaryOp<T> EmitBinaryOp<T>(this BufferToken buffer, ApiCodeBlock src)
            where T : unmanaged
                => buffer.Load(src.Encoded).EmitBinaryOp<T>(src.Id);

        /// <summary>
        /// Loads executable code into a token-identified buffer and covers it with a parametric ternary operator
        /// </summary>
        /// <param name="dst">The buffer token</param>
        /// <param name="src">The code to load</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static TernaryOp<T> EmitTernaryOp<T>(this BufferToken dst, ApiCodeBlock src)
            where T : unmanaged
                => dst.Load(src.Encoded).EmitTernaryOp<T>(src.Id);
    }
}
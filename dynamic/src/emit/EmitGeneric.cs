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

        public static UnaryOp<T> EmitUnaryOp<T>(this IBufferToken buffer, in ApiCode src)
            where T : unmanaged
                => buffer.Load(src.BinaryCode).EmitUnaryOp<T>(src.Id);

        public static BinaryOp<T> EmitBinaryOp<T>(this IBufferToken buffer, in ApiCode src)
            where T : unmanaged
                => buffer.Load(src.BinaryCode).EmitBinaryOp<T>(src.Id);

        public static TernaryOp<T> EmitTernaryOp<T>(this IBufferToken buffer, in ApiCode src)
            where T : unmanaged
                => buffer.Load(src.BinaryCode).EmitTernaryOp<T>(src.Id);

        /// <summary>
        /// Loads source into a token-identifed buffer and covers it with a fixed binary operator
        /// </summary>
        /// <param name="buffer">The target buffer</param>
        /// <param name="src">The code to load</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        public static FixedBinaryOp<F> EmitFixedBinaryOp<F>(this IBufferToken buffer, in ApiCode src)
            where F : unmanaged, IFixed
                => (FixedBinaryOp<F>)buffer.Load(src.BinaryCode).EmitFixedBinaryOp(src.Id, typeof(FixedBinaryOp<F>), typeof(F));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary operator over the buffer
        /// </summary>
        /// <param name="buffer">The target buffer</param>
        /// <param name="src">The executable source</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        public static FixedUnaryOp<F> EmitFixedUnaryOp<F>(this IBufferToken dst, in ApiCode src)
            where F : unmanaged, IFixed
               => (FixedUnaryOp<F>)dst.Handle.EmitFixed(src.Id,  typeof(FixedUnaryOp<F>), typeof(F), typeof(F));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary operator over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        public static FixedTernaryOp<F> EmitFixedTernaryOp<F>(this IBufferToken dst, in ApiCode src)
            where F : unmanaged, IFixed
                => (FixedTernaryOp<F>)dst.Handle.EmitFixed(src.Id, typeof(FixedTernaryOp<F>), typeof(F), typeof(F), typeof(F), typeof(F));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary function over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        public static FixedFunc<X0,R> EmitFixedFunc<X0,R>(this IBufferToken dst, in ApiCode src)
            where X0 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => (FixedFunc<X0,R>)dst.Handle.EmitFixed(src.Id, typeof(FixedFunc<X0,R>), typeof(R), typeof(X0));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed binary function over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        public static FixedFunc<X0,X1,R> EmitFixedFunc<X0,X1,R>(this IBufferToken dst, in ApiCode src)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => (FixedFunc<X0,X1,R>)dst.Handle.EmitFixed(src.Id, typeof(FixedFunc<X0,X1,R>), typeof(R), typeof(X0), typeof(X1));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed binary function over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        public static FixedFunc<X0,X1,X2,R> EmitFixedFunc<X0,X1,X2,R>(this IBufferToken dst, in ApiCode src)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where X2 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => (FixedFunc<X0,X1,X2,R>)dst.Handle.EmitFixed(src.Id, typeof(FixedFunc<X0,X1,X2,R>), typeof(R), typeof(X0), typeof(X1), typeof(X2));
    }
}
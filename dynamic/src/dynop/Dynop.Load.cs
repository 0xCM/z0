//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class Dynop
    {
        /// <summary>
        /// Loads the identifed buffer with the supplied source
        /// </summary>
        /// <param name="dst">The target buffer identifier</param>
        /// <param name="src">The executable source</param>
        /// <typeparam name="T">The concrete token type</typeparam>
        [MethodImpl(Inline)]
        public static T Load<T>(this T dst, in BinaryCode src)
            where T : IBufferToken
        {
            dst.Fill(src.Bytes);
            return dst;
        }

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary operator over the buffer
        /// </summary>
        /// <param name="buffer">The target buffer</param>
        /// <param name="src">The executable source</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        [MethodImpl(Inline)]
        public static FixedUnaryOp<F> LoadFixedUnaryOp<F>(this IBufferToken dst, in AsmCode src)
            where F : unmanaged, IFixed
               => (FixedUnaryOp<F>)dst.Handle.EmitFixedAdapter(src.Id,  typeof(FixedUnaryOp<F>), typeof(F), typeof(F));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary operator over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        [MethodImpl(Inline)]
        public static FixedBinaryOp<F> LoadFixedBinaryOp<F>(this IBufferToken dst, in AsmCode src)
            where F : unmanaged, IFixed
                => (FixedBinaryOp<F>)dst.Handle.EmitFixedAdapter(src.Id, typeof(FixedBinaryOp<F>), typeof(F), typeof(F), typeof(F));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary operator over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        [MethodImpl(Inline)]
        public static FixedTernaryOp<F> LoadFixedTernaryOp<F>(this IBufferToken dst, in ApiCode src)
            where F : unmanaged, IFixed
                => (FixedTernaryOp<F>)dst.Handle.EmitFixedAdapter(src.Id,  typeof(FixedTernaryOp<F>), typeof(F), typeof(F), typeof(F), typeof(F));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary function over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        [MethodImpl(Inline)]
        public static FixedFunc<X0,R> LoadFixedFunc<X0,R>(this IBufferToken dst, in ApiCode src)
            where X0 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => (FixedFunc<X0,R>)dst.Handle.EmitFixedAdapter(src.Id, typeof(FixedFunc<X0,R>), typeof(R), typeof(X0));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed binary function over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        [MethodImpl(Inline)]
        public static FixedFunc<X0,X1,R> LoadFixedFunc<X0,X1,R>(this IBufferToken dst, in ApiCode src)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => (FixedFunc<X0,X1,R>)dst.Handle.EmitFixedAdapter(src.Id, typeof(FixedFunc<X0,X1,R>), typeof(R), typeof(X0), typeof(X1));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed binary function over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        [MethodImpl(Inline)]
        public static FixedFunc<X0,X1,X2,R> LoadFixedFunc<X0,X1,X2,R>(this IBufferToken dst, in ApiCode src)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where X2 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => (FixedFunc<X0,X1,X2,R>)dst.Handle.EmitFixedAdapter(src.Id, typeof(FixedFunc<X0,X1,X2,R>), 
                        typeof(R), typeof(X0), typeof(X1), typeof(X2));
    }
}
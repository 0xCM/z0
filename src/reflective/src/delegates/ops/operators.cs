//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Delegates
    {
        /// <summary>
        /// Creates an emitter from a method
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="host">The host instance if not static</param>
        /// <typeparam name="T">The emission type</typeparam>
        [MethodImpl(Inline)]
        public static Emitter<T> emitter<T>(MethodInfo src, object host = null)
            where T : unmanaged
                => create<Emitter<T>>(src, host);

        /// <summary>
        /// Creates a receiver from a method
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="host">The host instance if not static</param>
        /// <typeparam name="T">The reception type</typeparam>
        [MethodImpl(Inline)]
        public static Receiver<T> receiver<T>(MethodInfo src, object host = null)
            where T : unmanaged
                => create<Receiver<T>>(src, host);

        /// <summary>
        /// Creates a unary operator from a method
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="host">The host instance if not static</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryOp<T> unary<T>(MethodInfo src, object host = null)
            where T : unmanaged
                => create<UnaryOp<T>>(src, host);

        /// <summary>
        /// Creates a binary operator from a method
        /// </summary>
        /// <param name="src">The source method</param>
        /// <param name="host">The host instance if not static</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryOp<T> binary<T>(MethodInfo src, object host = null)
            where T : unmanaged
                => create<BinaryOp<T>>(src, host);

        /// <summary>
        /// Creates a ternary operator from a method
        /// </summary>
        /// <param name="src">The source method</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static TernaryOp<T> ternary<T>(MethodInfo src, object host = null)
            where T : unmanaged
             => create<TernaryOp<T>>(src, host);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class Dynop
    {
       /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary function over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        public static FixedFunc<X0,R> EmitFixedFunc<X0,R>(this IBufferToken dst, in ApiCode src)
            => (FixedFunc<X0,R>)dst.Handle.EmitFixed(src.Id, typeof(FixedFunc<X0,R>), typeof(R), typeof(X0));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed binary function over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        public static FixedFunc<X0,X1,R> EmitFixedFunc<X0,X1,R>(this IBufferToken dst, in ApiCode src)
            => (FixedFunc<X0,X1,R>)dst.Handle.EmitFixed(src.Id, typeof(FixedFunc<X0,X1,R>), typeof(R), typeof(X0), typeof(X1));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed binary function over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        public static FixedFunc<X0,X1,X2,R> EmitFixedFunc<X0,X1,X2,R>(this IBufferToken dst, in ApiCode src)
            => (FixedFunc<X0,X1,X2,R>)dst.Handle.EmitFixed(src.Id, typeof(FixedFunc<X0,X1,X2,R>), typeof(R), typeof(X0), typeof(X1), typeof(X2));

    }
}
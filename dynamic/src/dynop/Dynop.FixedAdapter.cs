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
        [MethodImpl(Inline)]
        public static FixedDelegate FixedUnaryAdapter(this BufferToken buffer, OpIdentity id, Type operatorType, Type operandType)        
            => buffer.Handle.EmitFixedAdapter(id, functype: operatorType, result: operandType, args: operandType);

        [MethodImpl(Inline)]
        public static UnaryOp<T> FixedUnaryAdapter<T>(this BufferToken buffer, OpIdentity id)
            where T : unmanaged
                => (UnaryOp<T>)buffer.FixedUnaryAdapter(id,typeof(UnaryOp<T>), typeof(T));

        [MethodImpl(Inline)]
        public static FixedDelegate FixedBinaryAdapter(this BufferToken buffer, OpIdentity id, Type operatorType, Type operandType)        
            => buffer.Handle.EmitFixedAdapter(id,functype:operatorType, result:operandType, args: array(operandType, operandType));

        [MethodImpl(Inline)]
        public static FixedDelegate FixedTernaryAdapter(this BufferToken buffer, OpIdentity id, Type operatorType, Type operandType)        
            => buffer.Handle.EmitFixedAdapter(id, functype:operatorType, result:operandType, args: array(operandType, operandType,operandType));

        /// <summary>
        /// Manufactures a fixed unary function with a native body
        /// </summary>
        /// <param name="id">The identity that will be conferred on the produced function</param>
        /// <param name="src">A pointer to executable memory loaded with the native function body</param>
        /// <typeparam name="X0">The first argument type</typeparam>
        /// <typeparam name="R">The return type</typeparam>
        [MethodImpl(Inline)]
        public static FixedFunc<X0,R> FixedAdapter<X0,R>(this BufferToken buffer, OpIdentity id )
            where X0 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => (FixedFunc<X0,R>)buffer.Handle.EmitFixedAdapter(id, 
                        typeof(FixedFunc<X0,R>), typeof(R), typeof(X0));

        /// <summary>
        /// Manufactures a fixed binary function with a native body
        /// </summary>
        /// <param name="id">The identity that will be conferred on the produced function</param>
        /// <param name="src">A pointer to executable memory loaded with the native function body</param>
        /// <typeparam name="X0">The first argument type</typeparam>
        /// <typeparam name="X1">The second argument type</typeparam>
        /// <typeparam name="R">The return type</typeparam>
        [MethodImpl(Inline)]
        public static FixedFunc<X0,X1,R> FixedAdapter<X0,X1,R>(this BufferToken buffer, OpIdentity id)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => (FixedFunc<X0,X1,R>)buffer.Handle.EmitFixedAdapter(id, 
                        typeof(FixedFunc<X0,X1,R>), typeof(R), typeof(X0), typeof(X1));
        
        /// <summary>
        /// Manufactures a fixed ternary function with a native body
        /// </summary>
        /// <param name="id">The identity that will be conferred on the produced function</param>
        /// <param name="src">A pointer to executable memory loaded with the native function body</param>
        /// <typeparam name="X0">The first argument type</typeparam>
        /// <typeparam name="X1">The second argument type</typeparam>
        /// <typeparam name="X2">The third argument type</typeparam>
        /// <typeparam name="R">The return type</typeparam>
        [MethodImpl(Inline)]
        public static FixedFunc<X0,X1,X2,R> FixedAdapter<X0,X1,X2,R>(this BufferToken buffer, OpIdentity id)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where X2 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => (FixedFunc<X0,X1,X2,R>)buffer.Handle.EmitFixedAdapter(id,  
                        typeof(FixedFunc<X0,X1,X2,R>), typeof(R), typeof(X0), typeof(X1), typeof(X2));

        /// <summary>
        /// Manufactures a fixed 4-argument function with a native body
        /// </summary>
        /// <param name="id">The identity that will be conferred on the produced function</param>
        /// <param name="src">A pointer to executable memory loaded with the native function body</param>
        /// <typeparam name="X0">The first argument type</typeparam>
        /// <typeparam name="X1">The second argument type</typeparam>
        /// <typeparam name="X2">The third argument type</typeparam>
        /// <typeparam name="X3">The fourth argument type</typeparam>
        /// <typeparam name="R">The return type</typeparam>
        [MethodImpl(Inline)]
        public static FixedFunc<X0,X1,X2,X3,R> FixedAdapter<X0,X1,X2,X3,R>(this BufferToken buffer, OpIdentity id)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where X2 : unmanaged, IFixed
            where X3 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => (FixedFunc<X0,X1,X2,X3,R>)buffer.Handle.EmitFixedAdapter(id, 
                        typeof(FixedFunc<X0,X1,X2,X3,R>), typeof(R), typeof(X0), typeof(X1), typeof(X2), typeof(X3));
    }
}

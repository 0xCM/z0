//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Linq.Expressions;

    using static Seed;
    
    using K = OpClass;

    public static class Delegates
    {
        [MethodImpl(Inline)]
        public static Action action(MethodInfo src)
            => create<Action>(src);

        [MethodImpl(Inline)]
        public static Emitter<T> create<T>(MethodInfo src, K.Emitter<T> k)
            where T : unmanaged
                => create<Emitter<T>>(src);

        [MethodImpl(Inline)]
        public static Receiver<T> create<T>(MethodInfo src, K.Receiver<T> k)
            where T : unmanaged
                => create<Receiver<T>>(src);

        [MethodImpl(Inline)]
        public static UnaryOp<T> create<T>(MethodInfo src, K.UnaryOp<T> k)
            where T : unmanaged
                => create<UnaryOp<T>>(src);

        [MethodImpl(Inline)]
        public static BinaryOp<T> create<T>(MethodInfo src, K.BinaryOp<T> K)
            where T : unmanaged
                => create<BinaryOp<T>>(src);

        [MethodImpl(Inline)]
        public static TernaryOp<T> create<T>(MethodInfo src, K.TernaryOp<T> k)
            where T : unmanaged
             => create<TernaryOp<T>>(src);

        [MethodImpl(Inline)]
        public static Func<X0> func<X0>(MethodInfo src, X0 x0 = default)
                => create<Func<X0>>(src);

        [MethodImpl(Inline)]
        public static Func<X0,X1> func<X0,X1>(MethodInfo src, X0 x0 = default, X1 x1= default)
            => create<Func<X0,X1>>(src);

        [MethodImpl(Inline)]
        public static Func<X0,X1,X2> func<X0,X1,X2>(MethodInfo src, X0 x0 = default, X1 x1= default, X2 x2= default)
            => create<Func<X0,X1,X2>>(src);

        [MethodImpl(Inline)]
        public static Func<X0,X1,X2,X3> func<X0,X1,X2,X3>(MethodInfo src, X0 x0 = default, X1 x1= default, X2 x2= default, X3 x3 = default)
            => create<Func<X0,X1,X2,X3>>(src);

        /// <summary>
        /// Creates an untyped delegate for a static method
        /// </summary>
        /// <typeparam name="D">The type of the constructed delegate</typeparam>
        /// <param name="m">The method that will be invoked when delegate is activated</param>
        public static Delegate create(MethodInfo m, Type tDelegate)
        {
            var argTypes = m.ParameterTypes().ToArray();
            var dType
                = m.IsAction()
                ? Expression.GetActionType(argTypes)
                : Expression.GetFuncType(argTypes.Concat(Arrays.from(m.ReturnType)).ToArray());
            return Delegate.CreateDelegate(tDelegate, null, m);
        }

        /// <summary>
        /// Creates a generic delegate for a static method
        /// </summary>
        /// <typeparam name="D">The type of the constructed delegate</typeparam>
        /// <param name="m">The method that will be invoked when delegate is activated</param>
        public static D create<D>(MethodInfo m)
            where D : Delegate
        {
            var argTypes = m.ParameterTypes().ToArray();
            var dType
                = m.IsAction()
                ? Expression.GetActionType(argTypes)
                : Expression.GetFuncType(argTypes.Concat(Arrays.from(m.ReturnType)).ToArray());
            return (D)Delegate.CreateDelegate(typeof(D), null, m);
        }
    }
}
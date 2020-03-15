//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Security;
    
    using static Root;

    public interface ISurrogate<T>
    {
        /// <summary>
        /// The construct over which the surrogate is defined
        /// </summary>
        T Subject {get;}
        
    }
    
    public interface ISurrogate<S,T> : ISurrogate<T>
        where S : struct, ISurrogate<S,T>
    {
    }

    /// <summary>
    /// Characterizes a function surrogate which, by definition, is a value type that encloses/adapts a delegate, 
    /// a *surrogated delegate*, to facilitate treating delagates and an interface-contracted types uniformly. 
    /// So, given a surrogated delegate, it can be invoked as a function directly or via an interface
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    /// <typeparam name="D">The surrogated delegate type</typeparam>
    [SuppressUnmanagedCodeSecurity]
    public interface IFunctionSurrogate<S,D> : ISurrogate<S,D>, IFunc
        where S : struct, IFunctionSurrogate<S,D>
        where D : Delegate
    {

    }

    partial class Surrogates
    {
        [SuppressUnmanagedCodeSecurity]
        public interface IFunction<S,D> : Z0.IFunctionSurrogate<S,D>
            where S : struct, IFunction<S,D>        
            where D : Delegate
        {

        }

        public interface IFunc<F>
            where F : struct, IFunc<F>
    
        {

        }

        [SuppressUnmanagedCodeSecurity]
        public interface IFunc<S,R> : IFunc<S>, IFunction<S, System.Func<R>>, Z0.IFunc<R>
            where S : struct, IFunc<S,R>
        {


        }

        [SuppressUnmanagedCodeSecurity]
        public interface IFunc<S,X0,R> : IFunc<S>, IFunction<S, System.Func<X0,R>>, Z0.IFunc<X0,R>
            where S : struct, IFunc<S,X0,R>
        {

        }

        [SuppressUnmanagedCodeSecurity]
        public interface IFunc<S,X0,X1,R> : IFunc<S>, IFunction<S, System.Func<X0,X1,R>>, Z0.IFunc<X0,X1,R>
            where S : struct, IFunc<S,X0,X1,R>
        {

        }

        [SuppressUnmanagedCodeSecurity]
        public interface IFunc<S,X0,X1,X2,R> : IFunc<S>, IFunction<S, System.Func<X0,X1,X2,R>>, Z0.IFunc<X0,X1,X2,R>
            where S : struct, IFunc<S,X0,X1,X2,R>
        {

        }

        
        [SuppressUnmanagedCodeSecurity]
        public interface IEmitter<S,T> : IFunction<S, Z0.Emitter<T>>, Z0.IEmitter<T>, IFunctional<Func<T>>
            where S : struct, IEmitter<S,T>            
        {

        }

        [SuppressUnmanagedCodeSecurity]
        public interface IEmitter<S,T,C> : IFunction<S, Z0.Emitter<T,C>>, Z0.IEmitter<T,C>, IFunctional<Func<T>>
            where S : struct, IEmitter<S,T,C>
            where T : unmanaged
            where C : unmanaged
        {
            
        }

        [SuppressUnmanagedCodeSecurity]
        public interface IFunctional<F>
            where F : struct, IFunc<F>
        {
            F AsFunc();
        }

        [SuppressUnmanagedCodeSecurity]
        public interface IBinaryOp<S,T> : IFunction<S, Z0.BinaryOp<T>>, Z0.IBinaryOp<T>, IFunctional<Func<T,T,T>>
            where S : struct, IBinaryOp<S,T>
        {

        }

        [SuppressUnmanagedCodeSecurity]
        public interface IUnaryOp<S,T> : IFunction<S, Z0.UnaryOp<T>>, Z0.IUnaryOp<T>, IFunctional<Func<T,T>>
            where S : struct, IUnaryOp<S,T>
        {

        }

        [SuppressUnmanagedCodeSecurity]
        public interface ISpanEmitter<S,R> : IFunction<S, Z0.SpanEmitter<R>>, Z0.ISpanEmitter<R>
            where S : struct, ISpanEmitter<S,R>
        {


        }

        [SuppressUnmanagedCodeSecurity]
        public interface IUnaryPredicate<S,T> : IFunction<S, Z0.UnaryPredicate<T>>, Z0.IUnaryPredicate<T>, IFunctional<Func<T,bit>>
            where S : struct, IUnaryPredicate<S,T> 
        {

        }

    }
}
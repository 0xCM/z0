//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Identifies a service that carries no state
    /// </summary>
    public interface IStateless : IService
    {

    }
    
    public interface IStateless<F> : IStateless
        where F : IStateless<F>
    {
        [MethodImpl(Inline)]
        F Create<S>()                
            where S : unmanaged, F
                => default(S);
    }

    public interface IStatelessFactory<F> : IServiceFactory
        where F : unmanaged, IStatelessFactory<F>
    {
        
    }

    /// <summary>
    /// Characterizes a stateless service specification
    /// </summary>
    /// <typeparam name="S">The reification type</typeparam>
    /// <typeparam name="I">The service contract</typeparam>
    public interface IStateless<S,I> : IStateless<I>
        where S : unmanaged, I
        where I : IStateless<S,I>
    {
        I Create()
            => Stateless<I>.Empty.Create<S>();
        
        [MethodImpl(Inline)]
        static I Service()
            => Stateless<I>.Empty.Create<S>();
    }

    readonly struct Stateless<I> : IStateless<I>
        where I : IStateless<I>
    {
        public static IStateless<I> Empty => default(Stateless<I>);
    }
}
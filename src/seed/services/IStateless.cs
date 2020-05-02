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

    public interface IStatelessFactory<F,I> : IStateless<F,I>, IServiceFactory
        where F : unmanaged, I
        where I : IStateless<F,I>
    {
        
    }

    /// <summary>
    /// Characterizes an F-bound polymorphick stateless reification
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="I">The service contract</typeparam>
    public interface IStateless<F,I> : IStateless<I>
        where F : unmanaged, I
        where I : IStateless<F,I>
    {
        I Create()
            => Stateless<I>.Empty.Create<F>();
        
        [MethodImpl(Inline)]
        static I Service()
            => Stateless<I>.Empty.Create<F>();
    }

    readonly struct Stateless<I> : IStateless<I>
        where I : IStateless<I>
    {
        public static IStateless<I> Empty => default(Stateless<I>);
    }
}
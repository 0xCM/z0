//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public interface IStateless<F>
    {
        [MethodImpl(Inline)]
        F Create<S>()                
            where S : F, new()
                => new S();
    }

    public readonly struct Stateless
    {
        [MethodImpl(Inline)]
        public static Stateless<F> Create<F>()
            => new Stateless<F>();
            
        [MethodImpl(Inline)]
        public static Stateless<F,I> Create<F,I>()
            where F : I, new()
                => new Stateless<F,I>();

        [MethodImpl(Inline)]
        public static I Service<F,I>()
            where F : I, new()
                => Create<F,I>().Service();
    }

    public readonly struct Stateless<F> : IStateless<F>
    {
        [MethodImpl(Inline)]
        public F Create<S>()
            where S : F, new()
                => new S();
    }

    public readonly struct Stateless<F,I> : IStateless<F,I>
        where F : I, new()
    {
        [MethodImpl(Inline)]
        public I Service()
            => new F();        
    }

    /// <summary>
    /// Characterizes an F-bound polymorphick stateless reification
    /// </summary>
    /// <typeparam name="F">The reification type</typeparam>
    /// <typeparam name="I">The service contract</typeparam>
    public interface IStateless<F,I> : IStateless<I>
        where F : I, new()
    {
        I Create()
            => new F();
        
        [MethodImpl(Inline)]
        static I Service()
            => new F();
    }
}
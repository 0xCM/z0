//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;    
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IServiceFactory
    {
        static IServiceFactory Default => DefaultServiceFactory.Default;

        IContext Context => DefaultContext.Default;
    }

    public interface IServiceFactory<C> : IServiceFactory   
        where C : IContext
    {
        new C Context {get;}

        IContext IServiceFactory.Context => Context;
    }

    readonly struct DefaultServiceFactory : IServiceFactory
    {
        public static IServiceFactory Default => new DefaultServiceFactory(default(DefaultContext));

        [MethodImpl(Inline)]
        DefaultServiceFactory(IContext context)
        {
            this.Context = context;
        }

        public IContext Context {get;}
    }
}
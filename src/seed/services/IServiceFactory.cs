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
        
    }

    public interface IServiceFactory<C> : IServiceFactory   
        where C : IContext
    {
        C Context {get;}
        
    }

    readonly struct DefaultServiceFactory : IServiceFactory
    {
        public static IServiceFactory Default => default(DefaultServiceFactory);
    }
}
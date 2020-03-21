//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    public interface IConsoleApp : IApiComposition, IAppContext
    {        
        void RunApp(params string[] args);                
    }

    public interface IConsoleApp<A> : IConsoleApp, IApiComposition<A>
        where A : IConsoleApp<A>
    {
        
    }

    public interface IConsoleApp<A,C> : IConsoleApp<A>, IContextual<C>
        where A : IConsoleApp<A,C>
        where C : IAppContext
    {
        
    }    
}
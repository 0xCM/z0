//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    
    public interface IConsoleApp : IAssemblyComposition, IContext
    {
        void RunApp(params string[] args);                
    }

    public interface IConsoleApp<A> : IConsoleApp, IAssemblyComposition<A>
        where A : IConsoleApp<A>
    {
        
    }

    public interface IConsoleApp<A,C> : IConsoleApp<A>, IContextual<C>
        where A : IConsoleApp<A,C>
        where C : IContext
    {
        
    }    
}
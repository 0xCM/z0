//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface IConsoleApp<A> : IShell, IApiComposition<A>, IAppContext
        where A : IConsoleApp<A>, new()
    {
        
    }
}
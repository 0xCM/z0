// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IAppShell : IShell, IAppMsgContext,  IApiComposition
    {
    
    }

    /// <summary>
    /// Characterizes a shell with api composition support
    /// </summary>
    /// <typeparam name="A">The reification type</typeparam>
    public interface IAppShell<A> : IAppShell, IShell<A>
        where A : IAppShell<A>, new()
    {

    }    

}
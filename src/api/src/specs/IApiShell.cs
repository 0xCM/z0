// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public interface IApiShell : IShell, IAppMsgSink,  IApiComposition
    {
    }

    /// <summary>
    /// Characterizes a shell with api composition support
    /// </summary>
    /// <typeparam name="A">The reification type</typeparam>
    public interface IApiShell<A> : IApiShell, IShell<A>
        where A : IApiShell<A>, new()
    {

    }    

}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    public interface IWfShell<C> : IWfShell
        where C : IWfContext<C>
    {
        new C Context {get;}

        IWfContext IWfShell.Context
            => Context;
    }
}
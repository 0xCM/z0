//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Linq;
    using System.Collections.Generic;

    /// <summary>
    /// Charaterizes a component that maintains access to a context
    /// </summary>
    public interface IContextual
    {
        IContext Context {get;}
    }

    /// <summary>
    /// Charaterizes a component that maintains access to a context of a specific type
    /// </summary>
    public interface IContextual<C> : IContextual
        where C : IContext
    {
        new C Context {get;}

        IContext IContextual.Context
            => Context;
    }    

}
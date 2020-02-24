//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    using static zfunc;

    /// <summary>
    /// Charaterizes a type that supports execution within a context
    /// </summary>
    public interface IContextual
    {
        IRngContext Context {get;}
    }

    /// <summary>
    /// Charaterizes a type that supports execution within a parametric context
    /// </summary>
    public interface IContextual<C> : IContextual
        where C : IRngContext
    {
        new C Context {get;}

        IRngContext IContextual.Context
            => Context;
    }
}
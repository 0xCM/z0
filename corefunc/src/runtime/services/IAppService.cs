//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Characterizes a set of capabilities that execute within a context
    /// </summary>
    public interface IAppService : IContextual
    {


    }

    /// <summary>
    /// Characterizes a set of capabilities that execute within a parametric context
    /// </summary>
    public interface IAppService<C> : IAppService, IContextual<C>
        where C : IRngContext
    {


    }
}
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
    /// A context that carries an RNG state
    /// </summary>
    public interface IRngContext : IMsgContext, IRngProvider, IContext<IPolyrand>
    {

    }


    public interface IRngContext<C> : IRngContext
        where C : IRngContext
    {

    }
}
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
    /// A context that supports application message capture/disbursement
    /// </summary>
    public interface IMsgContext : IMsgExchange, IContext
    {
    
    }

    public interface IMsgContext<S> : IMsgContext, IContext<S>
    {

        
    }
}
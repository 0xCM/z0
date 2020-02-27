//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;

    /// <summary>
    /// A context that supports application message capture/disbursement
    /// </summary>
    public interface IMsgContext : IAppMsgExchange, IContext
    {
    
    }


}
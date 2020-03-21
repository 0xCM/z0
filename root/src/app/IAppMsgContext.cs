//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    using static Root;


    /// <summary>
    /// A context that supports application message capture/disbursement
    /// </summary>
    public interface IAppMsgContext : IAppMsgExchange, IAppContext
    {
    
    }    

}
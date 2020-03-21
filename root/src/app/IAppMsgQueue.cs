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

    public interface IAppMsgQueue : IAppMsgSink
    {

        IReadOnlyList<AppMsg> Flush();        

        IReadOnlyList<AppMsg> Flush(Exception e);

        void Flush(FilePath dst);
    }

    /// <summary>
    /// Characterizes a stateful thing that functions as an exchange for application messages
    /// </summary>
    public interface IAppMsgExchange : IAppMsgQueue
    {        
        void Flush(Exception exception, IAppMsgLog target);                       
    }

}
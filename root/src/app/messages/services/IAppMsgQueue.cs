//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IAppMsgQueue : IAppMsgSink, IMessageQueue<AppMsg>
    {
        IReadOnlyList<AppMsg> Flush(Exception e);

    }
}
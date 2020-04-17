//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    public interface IAppMsgQueue : IAppMsgSink, ICallbackSouce<IAppMsg>
    {
        IReadOnlyList<IAppMsg> Dequeue();       

        void Emit(FilePath dst);         

        IReadOnlyList<IAppMsg> Flush(Exception e);
    }
}
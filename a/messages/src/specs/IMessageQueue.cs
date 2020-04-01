//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;
    using System.Security;

    public interface IMessageQueue<M> : IMessageSink<M>, ICallbackSouce<M>
        where M : IAppMsg
    {
        IReadOnlyList<M> Dequeue();       

        void Emit(FilePath dst);         
    }
}
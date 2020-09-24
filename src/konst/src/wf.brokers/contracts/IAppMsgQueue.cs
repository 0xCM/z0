//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public interface IAppMsgQueue : IAppMsgSink, ICallbackSource<IAppMsg>
    {
        IReadOnlyList<IAppMsg> Dequeue();

        void Emit(FilePath dst);

        IReadOnlyList<IAppMsg> Flush(Exception e);

        void Flush(Exception e, IAppMsgSink target)
            => target.Deposit(Flush(e));
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    
    using static Seed;

    public interface ITestQueueControl
    {
        IReadOnlyList<IAppMsg> Dequeue();

        IReadOnlyList<IAppMsg> Flush(Exception e);

        void Flush(Exception e, IAppMsgSink target);

        void Emit(FilePath dst);
    }

}
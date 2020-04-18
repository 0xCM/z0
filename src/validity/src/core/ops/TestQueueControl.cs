//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    partial class TestContext<U>
    {
        public IReadOnlyList<IAppMsg> Dequeue()
            => Messages.Dequeue();

        public IReadOnlyList<IAppMsg> Flush(Exception e)
            => Messages.Flush(e);
            
        public void Flush(Exception e, IAppMsgSink target)
            => Messages.Flush(e, target);

        public void Emit(FilePath dst) 
            => Messages.Emit(dst);        

        public void Notify(string msg, AppMsgKind? severity = null)
            => Messages.Notify(msg, severity);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    public interface IHostCaptureWorkflow : IAsmService
    {
        void ExecuteWorkflow(FolderPath dst); 
        
        void WithReceiver<E>(Action<E> receiver, E model = default)
            where E : IAppEvent;       

        void WithSink<S,E>(S sink, E model = default)
            where E : IAppEvent
            where S : IAppEventSink<E>;
        
    }

}
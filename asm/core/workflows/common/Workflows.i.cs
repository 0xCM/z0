//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Root;



    public interface IWorkflowRunner<B,C> : IWorkflowRunner
        where B : IWorkflowEventBroker
    {
        void Run(C config);

        B EventBroker {get;}
    }

}
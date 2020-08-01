//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static z;

    public readonly struct WorkflowContext<T> : IWorkflowContext<T>
    {
        public IAppContext ContextRoot {get;}

        public T ContextData {get;}
             
        [MethodImpl(Inline)]
        public WorkflowContext(IAppContext root, T data)
        {
            ContextRoot = root;
            ContextData = data;
        }
    }
}
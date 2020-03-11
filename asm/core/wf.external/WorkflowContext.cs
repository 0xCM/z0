//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public readonly struct WorkflowContext : IWorkflowContext
    {
        public static IWorkflowContext<C> Create<C>(C context, IAppMsgSink sink, IPolyrand random)    
            where C : IComposedContext<C>
                => new WorkflowContext<C>(context.Compostion, sink, random);

        public static IWorkflowContext Create(IAssemblyComposition composition, IAppMsgSink sink, IPolyrand random)    
            => new WorkflowContext(composition, sink, random);

        WorkflowContext(IAssemblyComposition composition, IAppMsgSink sink, IPolyrand random)
        {
            this.Compostion = composition;
            this.MsgSink = sink;
            this.Random = random;
        }

        public IAppMsgSink MsgSink {get;}

        public IPolyrand Random {get;}

        public IAssemblyComposition Compostion {get;}
    }

    public readonly struct WorkflowContext<C> : IWorkflowContext<C>
        where C : IComposedContext<C>
    {
        
        internal WorkflowContext(IAssemblyComposition composition, IAppMsgSink sink, IPolyrand random)
        {
            this.Compostion = composition;
            this.MsgSink = sink;
            this.Random = random;
        }

        public IAppMsgSink MsgSink {get;}

        public IPolyrand Random {get;}

        public IAssemblyComposition Compostion {get;}
    }
}
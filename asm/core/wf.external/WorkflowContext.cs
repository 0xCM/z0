//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    public readonly struct WorkflowContext : IWorkflowContext
    {
        public static IWorkflowContext<C> Create<C>(C context, IAppMsgSink sink, IPolyrand random)    
            where C : IComposedApiContext<C>
                => new WorkflowContext<C>(context.Compostion, sink, random);

        public static IWorkflowContext Create(IApiComposition composition, IAppMsgSink sink, IPolyrand random)    
            => new WorkflowContext(composition, sink, random);

        WorkflowContext(IApiComposition composition, IAppMsgSink sink, IPolyrand random)
        {
            this.Compostion = composition;
            this.MsgSink = sink;
            this.Random = random;
        }

        public IAppMsgSink MsgSink {get;}

        public IPolyrand Random {get;}

        public IApiComposition Compostion {get;}
    }

    public readonly struct WorkflowContext<C> : IWorkflowContext<C>
        where C : IComposedApiContext<C>
    {
        
        internal WorkflowContext(IApiComposition composition, IAppMsgSink sink, IPolyrand random)
        {
            this.Compostion = composition;
            this.MsgSink = sink;
            this.Random = random;
        }

        public IAppMsgSink MsgSink {get;}

        public IPolyrand Random {get;}

        public IApiComposition Compostion {get;}
    }
}
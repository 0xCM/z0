//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolProcessor<T,F>
        where T : struct, ITool<T,F>
        where F : unmanaged, Enum
    {
        public const string ActorName = nameof(ToolProcessor<T,F>);

        public IWfContext Wf {get;}
        
        readonly Action<IToolFile<T,F>> Handler;
        
        [MethodImpl(Inline)]
        public ToolProcessor(IWfContext wf, Action<IToolFile<T,F>> handler)
        {
            Wf = wf;
            Handler = handler;
            Wf.Created(ActorName);
        }

        [MethodImpl(Inline)]
        public void Process(IToolFile<T,F> src)
        {
            Wf.Running(ActorName);            
            
            Handler(src);
            
            Wf.Ran(ActorName);            
        }

        public void Dispose()
        {
            Wf.Finished(ActorName);            
        }
    }
}
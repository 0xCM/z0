//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolProcessor<T,F> : IToolProcessor<T,F>
        where T : struct, ITool<T,F>
        where F : unmanaged, Enum
    {
        public IWfContext Wf {get;}
        
        readonly Action<IToolFile<T,F>> Handler;
        
        [MethodImpl(Inline)]
        public ToolProcessor(IWfContext wf, Action<IToolFile<T,F>> handler)
        {
            Wf = wf;
            Handler = handler;
        }

        [MethodImpl(Inline)]
        public void Process(IToolFile<T,F> src)
        {
            Handler(src);
        }

        public void Dispose()
        {
            
        }
    }
}
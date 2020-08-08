//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolRunner : IToolRunner
    {
        public IWfContext Wf {get;}

        public ToolRunner(IWfContext wf)
        {
            Wf = wf;
            Wf.Created();
        }

        public void Run(ToolConfig config)
        {
            Wf.Running();


            Wf.Ran();            
        }

        public void Dispose()
        {
            Wf.Finished();
        }
    }
}
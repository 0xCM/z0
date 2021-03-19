//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    sealed class PipeRunnerSvc : WfService<PipeRunnerSvc>, IPipeRunner
    {
        public WfExecToken Flow<T>(ReadOnlySpan<T> src, Pipe<T> dst)
        {
            var flow = Wf.Running();
            var count = Pipes.flow(src,dst);
            return Wf.Ran(flow, count);
        }

        public WfExecToken Flow<T>(Pipe<T> src, Pipe<T> dst)
        {
            var flow = Wf.Running();
            var count = Pipes.flow(src,dst);
            return Wf.Ran(flow, count);
        }
    }
}
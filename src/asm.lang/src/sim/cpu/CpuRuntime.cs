//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    public ref struct CpuRuntime
    {
        const uint DefaultBufferSize = CpuBuffer.BufferSize;

        readonly IWfRuntime Wf;

        readonly CpuBuffers Buffers;

        int ProcessedCount;

        [MethodImpl(Inline)]
        public CpuRuntime(IWfRuntime wf)
        {
            Wf = wf;
            Buffers = CpuBuffers.create(DefaultBufferSize);
            ProcessedCount = 0;
        }

        public void Dispose()
        {

        }

        [Op]
        public void Run()
        {
            var flow = Wf.Running();
            try
            {
                var buffer =  Buffers.Run();
                var steps = buffer.Slice(0, ProcessedCount);
                var log = Buffers.Log();
                var count = Hex.render(steps, log);
                var hex =  text.format(slice(log,0,count));
                Wf.Status(hex);
            }
            catch(Exception error)
            {
                Wf.Error(error);
            }
            Wf.Ran(flow);
        }
    }
}
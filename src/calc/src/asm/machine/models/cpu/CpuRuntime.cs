//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static CpuModels;

    using static core;

    public struct CpuRuntime
    {
        const uint DefaultBufferSize = CpuBuffer.BufferSize;

        readonly Action<string> Status;

        readonly Action<string> Error;

        readonly CpuBuffers Buffers;

        int ProcessedCount;

        [MethodImpl(Inline)]
        public CpuRuntime(Action<string> status, Action<string> error)
        {
            Status = status;
            Error = error;
            Buffers = CpuBuffers.create(DefaultBufferSize);
            ProcessedCount = 0;
        }

        public void Dispose()
        {

        }

        [Op]
        public void Run()
        {
            try
            {
                var buffer =  Buffers.Run();
                var steps = buffer.Slice(0, ProcessedCount);
                var log = Buffers.Log();
                var count = Hex.render(steps, log);
                var hex =  text.format(slice(log,0,count));
                Status(hex);
            }
            catch(Exception error)
            {
                Error(error.ToString());
            }
        }
    }
}
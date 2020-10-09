//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    [WfHost]
    public class ProcessPartFiles : WfHost<ProcessPartFiles,AsmContextProvider>
    {
        protected override void Execute(IWfShell wf, in AsmContextProvider state)
        {
            using var step = new ProcessPartFilesStep(wf, this, state.Context);
            step.Run();
        }
    }

    public ref struct ProcessPartFilesStep
    {
        const uint DefaultBufferSize = CpuBuffer.BufferSize;

        readonly IWfShell Wf;

        readonly CpuBuffers Buffers;

        int ProcessedCount;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public ProcessPartFilesStep(IWfShell wf, WfHost host, IAsmContext asm)
        {
            Wf = wf;
            Host = host;
            Buffers = CpuBuffer.alloc(DefaultBufferSize);
            ProcessedCount = 0;
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        [Op]
        public void Run()
        {
            Wf.Running(Host);
            try
            {
                var buffer =  Buffers.Run();
                var steps = buffer.Slice(0, ProcessedCount);
                var log = Buffers.Log();
                var count = asci.render(steps, log);
                var hex = log.Slice(0,count).ToString();
                term.print(hex);
            }
            catch(Exception error)
            {
                Wf.Error(Host, error);
            }

            Wf.Ran(Host);
        }

        [Op, MethodImpl(Inline)]
        void Dispatch(in EncodedInstruction src)
            => Execute(AsmEncoder.bytes(src));

        [Op, MethodImpl]
        void Execute(in ReadOnlySpan<byte> src)
        {
            var buffer = Buffers.Step();
            var count = asci.codes(src, UpperCased.Case, buffer);
            var ran = buffer.Slice(0, count);
            ran.CopyTo(Buffers.Run(), ProcessedCount);
            ProcessedCount += count;
        }
    }
}
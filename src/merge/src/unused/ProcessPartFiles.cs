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

    public ref struct ProcessPartFilesStep
    {
        const uint DefaultBufferSize = CpuBuffer.BufferSize;

        readonly IAsmWf Asm;

        readonly IWfShell Wf;

        readonly CpuBuffers Buffers;

        int ProcessedCount;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public ProcessPartFilesStep(IAsmWf asm)
        {
            Host = WfShell.host(typeof(ProcessPartFilesStep));
            Asm = asm;
            Wf = Asm.Wf.WithHost(Host);
            Buffers = CpuBuffers.create(DefaultBufferSize);
            ProcessedCount = 0;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        [Op]
        public void Run()
        {
            using var flow = Wf.Running();
            try
            {
                var buffer =  Buffers.Run();
                var steps = buffer.Slice(0, ProcessedCount);
                var log = Buffers.Log();
                var count = Digital.render(steps, log);
                var hex = log.Slice(0,count).ToString();
                Wf.Status(hex);
            }
            catch(Exception error)
            {
                Wf.Error(error);
            }
        }


        [Op, MethodImpl]
        void Execute(EncodedInstruction instruction)
        {
            var src = AsmEncoder.bytes(instruction);
            var buffer = Buffers.Step();
            var count = Digital.codes(src, UpperCased.Case, buffer);

            var codes = buffer.Slice(0, count);
            Execute(codes);
            codes.CopyTo(Buffers.Run(), ProcessedCount);
            ProcessedCount += count;
        }

        int Execute(Span<HexCode> src)
        {

            return src.Length;
        }
    }
}
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
    using static ProcessPartFilesStep;
    
    [ApiHost]
    public class ProcessPartFiles : IDisposable
    {
        const int DefaultBufferSize = CpuBuffer.BufferSize;

        readonly IWfContext Wf;

        readonly CorrelationToken Ct;

        readonly CpuBuffers Buffers;

        int ProcessedCount;

        readonly PartFiles Files;

        public static CpuBuffers buffers(int size)
            => new CpuBuffers(size);

        [MethodImpl(Inline)]
        internal ProcessPartFiles(IWfContext wf, IAsmContext asm, CorrelationToken ct)
        {
            Wf = wf;
            Ct = ct;
            Files = PartFiles.create(asm);        
            Buffers = buffers(DefaultBufferSize);
            ProcessedCount = 0;
            Wf.Created(StepName, Ct);
        }
        
        void RunTestCase()
        {
            const string Case01 = "002ch vmovdqu xmmword ptr [rcx],xmm0 ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}";

            var data = 0xCE_38ul;
            var command = AsmEncoder.encode(data);
            Dispatch(command);

            var seq = 0;
            var parsed = AsmParsers.ParseLine(Case01,ref seq);
            if(parsed)
                term.print($"{parsed.Value.Statement.ToString()}");
            else
                term.print("Parse failed");
        }

        [Op]
        public void Run()
        {            
            try
            {
                var steps = Buffers.Run().Slice(0, ProcessedCount);
                var buffer = Buffers.Log();
                var count = asci.render(steps, buffer);
                var hexline = buffer.Slice(0,count).ToString();
                term.print(hexline);
            }
            catch(Exception error)
            {
                Wf.Error(error, Ct);
            }
        }

        [Op, MethodImpl(Inline)]
        public void Run(ulong data)
        {
            Dispatch(AsmEncoder.encode(data));
        }

        [Op, MethodImpl(Inline)]
        public void Dispatch(in EncodedFx src)
        {
            Execute(AsmEncoder.bytes(src));
        }

        [Op, MethodImpl]
        public void Execute(in ReadOnlySpan<byte> src)
        {
            var buffer = Buffers.Step();
            var count = asci.codes(src, UpperCased.Case, buffer);
            var ran = buffer.Slice(0, count);
            ran.CopyTo(Buffers.Run(), ProcessedCount);
            ProcessedCount += count;
        }

        public void Dispose()
        {
            Wf.Finished(StepName, Ct);
        }
    }
}
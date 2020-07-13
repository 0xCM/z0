//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using Z0.Asm;
    using Z0.Asm.Data;

    using static Konst;

    [ApiHost]
    public class PartFileProcessor
    {
        const int DefaultBufferSize = CpuBuffer.BufferSize;

        readonly IMachineContext Context;

        readonly CpuBuffers Buffers;

        readonly List<AsmSourceDoc> AsmDocs;

        int ProcessedCount;

        readonly PartFiles Files;

        public static CpuBuffers buffers(int size)
            => new CpuBuffers(size);

        [MethodImpl(Inline)]
        internal PartFileProcessor(IMachineContext context)
        {
            AsmDocs = new List<AsmSourceDoc>(100);
            Context = context;
            Files = PartFiles.create(context.AsmContext);        
            Buffers = buffers(DefaultBufferSize);
            ProcessedCount = 0;
        }

        void AddAsmDoc(FilePath src, TextDoc doc)
        {
            AsmDocs.Add(new AsmSourceDoc(src, doc, sys.empty<AsmStatementBlock>()));            
        }

        void LoadAsmDoc(FilePath src)
        {
            TextDocParser.parse(src, TextDocFormat.Unstructured)
                .OnSuccess(doc => AddAsmDoc(src, doc))
                .OnFailure(x => term.error($"{x.Source} parsed failed {x.Reason}"));
        }
        
        void LoadAsmDocs()
        {
            z.iter(Files.AsmFiles,LoadAsmDoc);
            Notify(new PartFileEvent("Loaded asm docs", $"{AsmDocs.Count}"));
        }

        void RunTestCase()
        {
            const string Case01 = "002ch vmovdqu xmmword ptr [rcx],xmm0 ; VMOVDQU xmm2/m128, xmm1 || VEX.128.F3.0F.WIG 7F /r || encoded[4]{c5 fa 7f 01}";

            var data = 0xCE_38ul;
            var command = Encoding.encode(data);
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
            LoadAsmDocs();            

            var steps = Buffers.Run().Slice(0, ProcessedCount);
            var buffer = Buffers.Log();
            var count = asci.render(steps, buffer);
            var hexline = buffer.Slice(0,count).ToString();
            term.print(hexline);
        }

        void Notify(PartFileEvent e)
        {
            term.print(e);
        }

        [Op, MethodImpl(Inline)]
        public void Run(ulong data)
        {
            Dispatch(Encoding.encode(data));
        }

        [Op, MethodImpl(Inline)]
        public void Dispatch(in EncodedCommand src)
        {
            Execute(src.Encoding);
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
    }
}
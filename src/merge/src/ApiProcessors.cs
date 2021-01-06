//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static z;

    public delegate ApiHostRoutines HostBlockDecoder(in ApiHostCode blocks);

    public ref struct ApiProcessors
    {
        public static ApiProcessors create(IWfShell wf, IAsmContext asm)
        {
            var processors = new ApiProcessors(wf, asm);
            processors.Init();
            return processors;
        }

        readonly IWfShell Wf;

        readonly IAsmContext Asm;

        ApiCodeBlockIndex Index;

        Span<ApiPartRoutines> Decoded;

        ApiProcessors(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            Asm = asm;
            Index = default;
            Decoded = default;
        }

        void Init()
        {
            Index = ApiIndex.service(Wf).CreateIndex();
            Decoded = ApiDecoder.init(Wf,Asm).DecodeIndex(Index);
        }

        public void EmitResBytes()
        {
            ResBytesEmitter.service(Wf, Index).Emit();
        }

        public void ProcessCalls()
        {
            var count = Decoded.Length;
            for(var i=0; i<count; i++)
                PartRoutinesProcessor.service(Wf, skip(Decoded,i)).ProcessCalls();
        }

        void ProcessJumps(ApiPartRoutines src)
        {
            using var step = new AsmJmpProcessor(Wf, src);
            step.Process();
        }

        public void ProcessJumps()
        {
            var count = Decoded.Length;
            for(var i=0; i<count; i++)
                ProcessJumps(skip(Decoded,i));
        }

        public void ProcessEnlisted()
        {
            var count = Decoded.Length;
            for(var i=0; i<count; i++)
                AsmProcessors.parts(Wf).Process(skip(Decoded,i));
        }


        public void ProcessSemantic()
        {
            using var service = AsmSemanticRender.create(Wf);
            var count = Decoded.Length;
            for(var i=0; i<count; i++)
                service.Render(skip(Decoded, i));
        }

        public void EmitAsmRows()
        {
            try
            {
                var processor = new AsmProcessDriver(Wf, Asm, Index);
                var result = processor.Process();
                var records = 0u;

                Wf.Processed(Seq.delimit(nameof(AsmRow), Index.Hosts.Length, result.Count));

                var sets = result.View;
                var count = result.Count;
                Wf.Status($"Emitting {count} instruction tables");
                for(var i=0; i<count; i++)
                    records += AsmTables.emit(Wf, skip(sets,i));
                Wf.Status($"Emitted a total of {records} records for {count} instruction tables");

            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }
    }
}
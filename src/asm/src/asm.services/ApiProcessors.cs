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

        public void EmitCallRows()
        {
            var count = Decoded.Length;
            for(var i=0; i<count; i++)
            {

                ref readonly var routines = ref skip(Decoded,i);
                EmitCallRows(routines);
            }
        }

        public void EmitJmpRows()
        {
            var count = Decoded.Length;
            for(var i=0; i<count; i++)
                EmitJumpRows(skip(Decoded,i));
        }

        public void ProcessEnlisted()
        {
            var count = Decoded.Length;
            for(var i=0; i<count; i++)
                AsmProcessors.parts(Wf).Process(skip(Decoded,i));
        }

        public void EmitSemantic()
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
                var emitter = new AsmDataEmitter(Wf, Asm, Index);
                var result = emitter.Emit();
                var records = 0u;

                Wf.Processed(Seq.delimit(nameof(AsmRow), Index.Hosts.Length, result.Count));

                var sets = result.View;
                var count = result.Count;
                Wf.Status($"Emitting {count} instruction tables");
                for(var i=0; i<count; i++)
                    records += asm.emit(Wf, skip(sets,i));
                Wf.Status($"Emitted a total of {records} records for {count} instruction tables");

            }
            catch(Exception e)
            {
                Wf.Error(e);
            }
        }

        void EmitJumpRows(ApiPartRoutines src)
        {
            var step = new AsmJmpRowEmitter(Wf, src);
            step.Emit();
        }

        void EmitCallRows(ApiPartRoutines Source)
        {
            var dst = Wf.Db().Table(AsmCallRow.TableId, Source.Part);
            Wf.EmittingTable<AsmCallRow>(dst);
            using var writer = dst.Writer();
            var records = @readonly(asm.calls(Source.Instructions));
            var count = records.Length;
            writer.WriteLine(AsmCallRow.header());
            for(var i=0; i<count; i++)
                writer.WriteLine(asm.format(skip(records,i)));
            Wf.EmittedTable<AsmCallRow>(count, dst);
        }
    }
}
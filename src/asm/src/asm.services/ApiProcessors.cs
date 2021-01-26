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

    public ref struct ApiProcessors
    {
        public static ApiProcessors create(IWfShell wf, IAsmContext asm)
        {
            var processors = new ApiProcessors(wf, asm);
            //processors.Init();
            return processors;
        }

        readonly IWfShell Wf;

        //readonly IAsmContext Asm;

        ApiCodeBlocks CodeBlocks;

        Index<ApiPartRoutines> Decoded;

        readonly AsmDataEmitter Emitter;

        ApiProcessors(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            //Asm = asm;
            Emitter = new AsmDataEmitter(wf, asm);
            CodeBlocks = Emitter.CodeBlocks;
            Decoded = Emitter.Decoded;
        }

        // void Init()
        // {
        //     CodeBlocks = ApiIndex.service(Wf).CreateApiBlocks();
        //     Decoded = ApiDecoder.init(Wf,Asm).DecodeIndex(CodeBlocks);
        // }

        public void EmitResBytes()
        {
            var dst = FS.dir(@"J:\dev\projects\z0.generated\respack\content\bytes");
            var service = ResBytesEmitter.create(Wf);
            service.Emit(CodeBlocks, dst);
        }

        public void EmitCallRows()
            => Emitter.EmitCallRows();
        // {
        //     var count = Decoded.Length;
        //     for(var i=0; i<count; i++)
        //         EmitCallRows(Decoded[i]);
        // }

        public void EmitJmpRows()
            => Emitter.EmitJmpRows();
        // {
        //     var count = Decoded.Length;
        //     for(var i=0; i<count; i++)
        //         EmitJumpRows(Decoded[i]);
        // }

        public void ProcessEnlisted()
        {
            var count = Decoded.Length;
            for(var i=0; i<count; i++)
                AsmProcessors.parts(Wf).Process(Decoded[i]);
        }

        public void EmitSemantic()
        {
            using var service = AsmSemanticRender.create(Wf);
            var count = Decoded.Length;
            for(var i=0; i<count; i++)
                service.Render(Decoded[i]);
        }

        public void EmitAsmRows()
            => Emitter.EmitAsmRows();

        // {
        //     try
        //     {
        //         var emitter = new AsmDataEmitter(Wf, Asm, CodeBlocks, Decoded);
        //         var result = emitter.Emit();
        //         var records = 0u;

        //         Wf.Processed(Seq.delimit(nameof(AsmRow), CodeBlocks.Hosts.Count, result.Count));

        //         var sets = result.View;
        //         var count = result.Count;
        //         Wf.Status($"Emitting {count} instruction tables");
        //         for(var i=0; i<count; i++)
        //             records += AsmEtl.emit(Wf, skip(sets,i));
        //         Wf.Status($"Emitted a total of {records} records for {count} instruction tables");

        //     }
        //     catch(Exception e)
        //     {
        //         Wf.Error(e);
        //     }
        // }

        // void EmitJumpRows(ApiPartRoutines src)
        // {
        //     var step = new AsmJmpRowEmitter(Wf, src);
        //     step.Emit();
        // }

        // static string format(in AsmCallRow src)
        //     => string.Format(AsmCallRow.RenderPattern, src.Source, src.Target, src.InstructionSize, src.TargetOffset, src.Instruction, src.Encoded);

        // void EmitCallRows(ApiPartRoutines Source)
        // {
        //     var dst = Wf.Db().Table(AsmCallRow.TableId, Source.Part);
        //     Wf.EmittingTable<AsmCallRow>(dst);
        //     using var writer = dst.Writer();
        //     var records = @readonly(AsmEtl.calls(Source.Instructions));
        //     var count = records.Length;
        //     writer.WriteLine(AsmCallRow.header());
        //     for(var i=0; i<count; i++)
        //         writer.WriteLine(format(skip(records,i)));
        //     Wf.EmittedTable<AsmCallRow>(count, dst);
        // }
    }
}
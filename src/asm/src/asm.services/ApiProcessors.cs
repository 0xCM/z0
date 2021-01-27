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
            => new ApiProcessors(wf, asm);

        readonly IWfShell Wf;

        ApiCodeBlocks CodeBlocks;

        Index<ApiPartRoutines> Decoded;

        readonly AsmDataEmitter Emitter;

        ApiProcessors(IWfShell wf, IAsmContext asm)
        {
            Wf = wf;
            Emitter = new AsmDataEmitter(wf, asm);
            CodeBlocks = Emitter.CodeBlocks;
            Decoded = Emitter.Decoded;
        }

        public void EmitResBytes()
        {
            var dst = FS.dir(@"J:\dev\projects\z0.generated\respack\content\bytes");
            ResBytesEmitter.create(Wf).Emit(CodeBlocks, dst);
        }

        public void EmitCallRows()
            => Emitter.EmitCallRows();

        public void EmitJmpRows()
            => Emitter.EmitJmpRows();

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
    }
}
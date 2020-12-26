//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using Z0.Asm;

    public sealed class EmitHostAsm : WfHost<EmitHostAsm,ApiMemberCodeBlocks,AsmRoutines>
    {
        ApiHostUri Uri;

        IAsmContext Asm;

        public static EmitHostAsm create(IAsmContext asm, ApiHostUri uri)
        {
            var dst = new EmitHostAsm();
            dst.Asm = asm;
            dst.Uri = uri;
            return dst;
        }

        protected override ref AsmRoutines Execute(IWfShell wf, in ApiMemberCodeBlocks src, out AsmRoutines dst)
        {
            using var step = new EmitHostAsmStep(wf, this, Asm, Uri);
            return ref step.Run(src, out dst);
        }
    }

    ref struct EmitHostAsmStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly IAsmContext Asm;

        readonly ApiHostUri Uri;

        public EmitHostAsmStep(IWfShell wf, WfHost host, IAsmContext asm, ApiHostUri uri)
        {
            Host = host;
            Wf = wf.WithHost(Host);
            Asm = asm;
            Uri = uri;
            Wf.Created();
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public ref AsmRoutines Run(in ApiMemberCodeBlocks src, out AsmRoutines dst)
        {
            var flow = Wf.Running();

            Decode(src, out dst);
            //DecodeApiHost.create(Asm.RoutineDecoder, Uri).Run(Wf, src, out dst);
            var emitted = Z0.Asm.ApiAsm.emit(Wf, Uri, dst.Storage, Asm.Formatter.Config);
            if(emitted.IsNonEmpty)
                Wf.EmittedFile(dst, dst.Count, emitted);

            Wf.Ran(flow);
            return ref dst;
        }

        void Decode(in ApiMemberCodeBlocks src, out AsmRoutines dst)
        {
            using var decoder = ApiHostDecoder.create(Wf, Asm.RoutineDecoder);
            dst = decoder.Decode(Uri, src);
        }
    }
}
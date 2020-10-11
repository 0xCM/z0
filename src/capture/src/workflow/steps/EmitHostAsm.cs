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
    using static z;

    public sealed class EmitHostAsm : WfHost<EmitHostAsm,ApiMemberCodeBlocks,AsmRoutines>
    {
        ICaptureContext Context;

        ApiHostUri Uri;


        public static EmitHostAsm create(ICaptureContext context, ApiHostUri uri)
        {
            var dst = new EmitHostAsm();
            dst.Context = context;
            dst.Uri = uri;
            return dst;
        }

        protected override ref AsmRoutines Execute(IWfShell wf, in ApiMemberCodeBlocks src, out AsmRoutines dst)
        {
            using var step = new EmitHostAsmStep(wf,this,Context,Uri);
            return ref step.Run(src, out dst);
        }
    }

    ref struct EmitHostAsmStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly ICaptureContext Context;

        readonly ApiHostUri Uri;

        public EmitHostAsmStep(IWfShell wf, WfHost host, ICaptureContext context, ApiHostUri uri)
        {
            Wf = wf;
            Host = host;
            Context = context;
            Uri = uri;
        }


        public void Dispose()
        {

        }

        public ref AsmRoutines Run(in ApiMemberCodeBlocks src, out AsmRoutines dst)
        {
            Wf.Running(Host);
            DecodeApiHost.create(Context.Decoder, Uri).Run(Wf, src, out dst);

            var emitted = AsmServices.emit(Uri, dst.Storage, Context.Formatter.Config, Wf.Db());

            if(emitted.IsNonEmpty)
                Wf.EmittedFile(dst, dst.Count, emitted);

            Wf.Ran(Host);
            return ref dst;
        }
    }
}
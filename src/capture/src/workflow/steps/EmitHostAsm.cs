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

        FS.FilePath Target;

        public static EmitHostAsm create(ICaptureContext context, ApiHostUri uri, FS.FilePath path)
        {
            var dst = new EmitHostAsm();
            dst.Context = context;
            dst.Uri = uri;
            dst.Target = path;
            return dst;
        }

        protected override ref AsmRoutines Execute(IWfShell wf, in ApiMemberCodeBlocks src, out AsmRoutines dst)
        {
            using var step = new EmitHostAsmStep(wf,this,Context,Uri,Target);
            return ref step.Run(src, out dst);
        }
    }

    ref struct EmitHostAsmStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        readonly ICaptureContext Context;

        readonly ApiHostUri Uri;

        readonly FS.FilePath Target;

        public EmitHostAsmStep(IWfShell wf, WfHost host, ICaptureContext context, ApiHostUri uri, FS.FilePath dst)
        {
            Wf = wf;
            Host = host;
            Context = context;
            Uri = uri;
            Target = dst;
        }

        public ref AsmRoutines Run(in ApiMemberCodeBlocks src, out AsmRoutines dst)
        {
            Wf.Running(Host, src.Count);
            DecodeApiMembers.create(Context, Uri).Run(Wf, src, out dst);
            SaveDecoded(dst.Storage);
            Wf.Ran(Host, text.format(RP.PSx3, dst.Count, Uri.Format(), Target.ToUri()));
            return ref dst;
        }

        void SaveDecoded(ReadOnlySpan<AsmRoutine> src)
        {
            var count = src.Length;
            if(count != 0)
            {
                using var writer = Target.Writer();
                var buffer = Buffers.text();

                for(var i=0; i<count; i++)
                {
                    ref readonly var routine = ref skip(src,i);
                    AsmRender.format(routine, Context.Formatter.Config, buffer);
                    writer.Write(buffer.Emit());
                }
            }
        }

        public void Dispose()
        {

        }
    }
}
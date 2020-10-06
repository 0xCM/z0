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

    public sealed class EmitAsmOpCodes : WfHost<EmitAsmOpCodes>
    {
        FS.FilePath Target;

        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitAsmOpCodesStep(wf, this, Target);
            wf.Created(this);
            wf.Running(this);
            step.Run();
            wf.Ran(this);
        }

        [MethodImpl(Inline)]
        public EmitAsmOpCodes Configure(FS.FilePath target)
        {
            Target = target;
            return this;
        }
    }

    ref struct EmitAsmOpCodesStep
    {
        readonly IWfShell Wf;

        readonly FS.FilePath Target;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public EmitAsmOpCodesStep(IWfShell context, WfHost host, FS.FilePath dst)
        {
            Wf = context;
            Host = host;
            Target = dst;
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public void Run()
        {
            var data = AsmCodes.dataset().Entries;
            var count = data.Count;
            var view = data.View;

            var formatter = AsmCodes.formatter<AsmOpCodeField>();
            using var dst = Target.Writer();
            formatter.EmitHeader(false);
            dst.WriteLine(formatter.Render());
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(view,i);
                AsmCodes.format(record, formatter);
                dst.WriteLine(formatter.Render());
            }
        }
    }
}
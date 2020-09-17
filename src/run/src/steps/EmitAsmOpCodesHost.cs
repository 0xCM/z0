//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public sealed class EmitAsmOpCodesHost : WfHost<EmitAsmOpCodesHost>
    {
        FS.FilePath Target;

        protected override void Execute(IWfShell wf)
        {
            using var step = new EmitAsmOpCodes(wf, this, Target);
            wf.Created(this);
            wf.Running(this);
            step.Run();
            wf.Ran(this);
        }

        [MethodImpl(Inline)]
        public EmitAsmOpCodesHost Configure(FS.FilePath target)
        {
            Target = target;
            return this;
        }
    }
}
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

    public sealed class EmitAsmOpCodes : CmdHost<EmitAsmOpCodes, EmitAsmOpCodesCmd>
    {
        public static CmdResult run(IWfShell wf)
            => run(wf, wf.CmdBuilder().EmitAsmOpCodes());

        [CmdWorker]
        public static CmdResult run(IWfShell wf, in EmitAsmOpCodesCmd spec)
        {
            var data = AsmOpCodes.dataset().Entries;
            var count = data.Count;
            var view = data.View;

            var formatter = AsmOpCodes.formatter<AsmOpCodeField>();
            using var dst = spec.Target.Writer();
            formatter.EmitHeader(false);
            dst.WriteLine(formatter.Render());
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(view,i);
                AsmOpCodes.format(record, formatter);
                dst.WriteLine(formatter.Render());
            }
            return Win();
        }

        protected override CmdResult Execute(IWfShell wf, in EmitAsmOpCodesCmd spec)
            => run(wf, spec);
    }
}
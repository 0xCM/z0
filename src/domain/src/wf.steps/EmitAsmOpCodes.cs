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

    [WfNode]
    public sealed class EmitAsmOpCodes : CmdNode<EmitAsmOpCodes, EmitAsmOpCodesCmd, FS.FilePath>
    {
        public static CmdResult run(IWfShell wf)
        {
            var spec = wf.CmdSpecs().EmitAsmOpCodes();
            spec.WithTarget(wf.Db().RefDataPath("asm.opcodes"));
            return run(wf,spec);
        }

        [CmdWorker]
        public static CmdResult run(IWfShell wf, in EmitAsmOpCodesCmd cmd)
        {
            var node = Node(wf);
            node.Run(cmd);
            return Cmd.ok(cmd);
        }

        protected override FS.FilePath Run(EmitAsmOpCodesCmd cmd)
        {
            var data = AsmOpCodes.dataset().Entries;
            var count = data.Count;
            var view = data.View;
            var formatter = AsmOpCodes.formatter<AsmOpCodeField>();
            var rowbuffer = alloc<AsmOpCodeRow>(count);
            var rows = span(rowbuffer);
            using var dst = cmd.Target.Writer();
            formatter.EmitHeader(false);
            dst.WriteLine(formatter.Render());
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(view,i);
                seek(rows,i) = record;

                AsmOpCodes.format(record, formatter);
                dst.WriteLine(formatter.Render());
            }
            return  cmd.Target;
        }
    }
}
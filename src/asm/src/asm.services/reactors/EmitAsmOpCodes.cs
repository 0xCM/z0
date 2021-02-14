//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Z0.Asm;

    using static memory;
    using static Asm.AsmOpCodesLegacy;

    sealed class EmitAsmOpCodes : CmdReactor<EmitAsmOpCodesCmd,FS.FilePath>
    {
        protected override FS.FilePath Run(EmitAsmOpCodesCmd cmd)
            => react(Wf,cmd);

        [Op]
        static FS.FilePath react(IWfShell wf, EmitAsmOpCodesCmd cmd)
        {
            var data = dataset().Entries;
            var count = data.Count;
            var view = data.View;
            var formatter = formatter<AsmOpCodeField>();
            var rowbuffer = alloc<AsmOpCodeRowLegacy>(count);
            var rows = span(rowbuffer);
            using var dst = cmd.Target.Writer();
            formatter.EmitHeader(false);
            dst.WriteLine(formatter.Render());
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(view,i);
                seek(rows,i) = record;

                format(record, formatter);
                dst.WriteLine(formatter.Render());
            }

            return cmd.Target;
        }
    }
}
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

    public ref struct EmitAsmOpCodes
    {
        readonly IWfShell Wf;

        readonly FS.FilePath Target;

        readonly EmitAsmOpCodesHost Host;

        [MethodImpl(Inline)]
        public EmitAsmOpCodes(IWfShell context, EmitAsmOpCodesHost host, FS.FilePath dst)
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
            var data = AsmOpCodes.dataset().Entries;
            var count = data.Count;
            var view = data.View;

            var formatter = AsmOpCodes.formatter<AsmOpCodeField>();
            using var dst = Target.Writer();
            formatter.EmitHeader(false);
            dst.WriteLine(formatter.Render());
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(view,i);
                AsmOpCodes.format(record, formatter);
                dst.WriteLine(formatter.Render());
            }
        }
    }
}
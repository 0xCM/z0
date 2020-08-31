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

    public ref struct LogOpCodes
    {
        readonly IWfShell Wf;

        readonly LogOpCodesArgs Args;

        public LogOpCodes(IWfShell context, LogOpCodesArgs args)
        {
            Wf = context;
            Args = args;
        }

        public void Run()
        {
            var data = AsmOpCodes.dataset().Entries;
            var count = data.Count;
            var view = data.View;
            using var dst = Args.Target.Writer();
            for(var i=0; i<count; i++)
            {
                ref readonly var record = ref skip(view,i);
                var fmt = record.Format();
            }
        }
    }
}
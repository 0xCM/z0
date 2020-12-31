//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Threading.Tasks;

    using static Konst;

    public readonly struct Commands
    {
        public static Commands service(IWfShell wf)
            => new Commands(wf);

        readonly IWfShell Wf;

        readonly CmdBuilder CmdBuilder;

        Commands(IWfShell wf)
        {
            Wf = wf;
            CmdBuilder = wf.CmdBuilder();
        }

        public Task<CmdResult> EmitApiIndex()
            => Wf.Dispatch(CmdBuilder.EmitApiIndex());

        public Task<CmdResult> EmitRuntimeIndex()
            => Wf.Dispatch(CmdBuilder.EmitRuntimeIndex());

        public Task<CmdResult> DumpCliTables(Assembly src)
            => Wf.Dispatch(CmdBuilder.DumpCliTables(src));

        public Task<CmdResult> DumpCliTables(FS.FilePath src)
            => Wf.Dispatch(CmdBuilder.DumpCliTables(src));

        public Task<CmdResult> EmitDocComments(ReadOnlySpan<CmdLinePart> args)
            => Wf.Dispatch(CmdBuilder.EmitDocComments());

        public Task<CmdResult> EmitAsmOpCodes(ReadOnlySpan<CmdLinePart> args)
            => Wf.Dispatch(CmdBuilder.EmitAsmOpCodes());

        public Task<CmdResult> RunStep(ReadOnlySpan<CmdLinePart> args)
            => Wf.Dispatch(CmdBuilder.RunStep(args[0]));
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0.Tooling;

    using static Part;

    [ApiHost]
    public sealed class Tools : WfService<Tools>
    {
        public static ToolCmdArgs args<T>(T src)
            where T : struct, ICmd<T>
                => typeof(T).DeclaredInstanceFields().Select(f => new ToolCmdArg(f.Name, f.GetValue(src)?.ToString() ?? EmptyString));

        public void Running(ToolExecSpec cmd)
            => Wf.Raise(new ToolRunningEvent(cmd.CmdId, Wf.Ct));

        public static IToolResultProcessor processor(IEnvPaths paths, FS.FilePath script)
            => new ToolResultProcessor(paths, script);

        [MethodImpl(Inline), Op]
        public static Nasm nasm(IWfShell wf)
            => Nasm.create(wf);

    }
}
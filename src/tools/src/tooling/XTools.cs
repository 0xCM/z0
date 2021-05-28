//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Tools;

    using Svc = Tools;

    [ApiHost]
    public static partial class XTools
    {
        public static DumpParser DumpParser(this IWfRuntime wf)
            => Z0.DumpParser.create(wf);

        [Op]
        public static Nasm Nasm(this IWfRuntime wf)
            => Svc.Nasm.create(wf);

        [Op]
        public static NDisasm NDisasm(this IWfRuntime wf)
            => Svc.NDisasm.create(wf);

        [Op]
        public static XedTool XedTool(this IWfRuntime wf)
            => Svc.XedTool.create(wf);

        [Op]
        public static DumpBin DumpBin(this IWfRuntime wf)
            => Svc.DumpBin.create(wf);

        [Op]
        public static Robocopy Robocopy(this IWfRuntime wf)
            => Svc.Robocopy.create(wf);

        [Op]
        public static ScriptRunner ScriptRunner(this IWfRuntime wf)
            => Z0.ScriptRunner.create(wf.Db());

        [Op]
        public static ScriptRunner ScriptRunner(this IEnvPaths paths)
            => Z0.ScriptRunner.create(paths);

        [Op]
        public static CultProcessor CultProcessor(this IWfRuntime wf)
            => Svc.CultProcessor.create(wf);

        [Op]
        public static MsDocPipe MsDocs(this IWfRuntime wf)
            => Svc.MsDocPipe.create(wf);

        [Op]
        public static DotNet DotNet(this IWfRuntime wf)
            => Svc.DotNet.create(wf);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Svc = Z0;

    [ApiHost]
    public static class XSvc
    {
        [Op]
        public static CmdLineRunner CmdLineRunner(this IWfRuntime wf)
            => Svc.CmdLineRunner.create(wf);

        [Op]
        public static ScriptRunner ScriptRunner(this IServiceContext context)
            => Svc.ScriptRunner.create(context.EnvPaths);

        [Op]
        public static ScriptRunner ScriptRunner(this IEnvPaths paths)
            => Svc.ScriptRunner.create(paths);

        [Op]
        public static ProcessLauncher ProcessLauncher(this IWfRuntime paths)
            => Svc.ProcessLauncher.create(paths);

        [Op]
        public static ToolBase ToolBase(this IServiceContext context, FS.FolderPath root)
            => Svc.ToolBase.create(context).Configure(root);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Svc = Z0;
    using System;

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
        public static Tooling Tooling(this IWfRuntime wf)
            => Svc.Tooling.create(wf);

        [Op]
        public static OmniScript OmniScript(this IWfRuntime wf)
            => Svc.OmniScript.create(wf);

    }
}
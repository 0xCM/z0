//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial class WfShell
    {
        [Op]
        public static ApiPartSet parts()
            => parts(controller(), args());

        [Op]
        public static ApiPartSet parts(Assembly control, string[] args)
        {
            var parts = ApiPartIdParser.parse(args);
            if(parts.Length != 0)
               return new ApiPartSet(control, parts);
            else
                return new ApiPartSet(control);
        }

        [Op]
        public static ApiPartSet parts(Assembly control)
            => parts(control, args());

        [MethodImpl(Inline), Op]
        public static IJsonSettings json(IWfPaths paths)
            => JsonSettings.Load(paths.AppConfigPath);

        [Op]
        public static WfSettings settings(IWfContext context)
        {
            var dst = z.dict<string,string>();
            var assname = Assembly.GetEntryAssembly().GetSimpleName();
            var filename = FileName.define(assname, FileExtensions.Json);
            var src = context.Paths.ConfigRoot + filename;
            JsonSettings.absorb(src, dst);
            return new WfSettings(dst);
        }

        [MethodImpl(Inline), Op]
        public static IWfPaths paths()
            => new WfPaths(config(controller().Id(), EnvVars.Common.LogRoot, dbRoot()));

        [Op]
        public static IWfContext context()
            => new WfContext();

        public static WfLogConfig config(PartId part, FS.FolderPath logRoot, FS.FolderPath dbRoot)
            => new WfLogConfig(part, logRoot, dbRoot);

        public static FS.FolderPath dbRoot()
            => FS.dir(@"j:\database\logs\wf");

        [MethodImpl(Inline), Op]
        public static string[] args()
            => Environment.GetCommandLineArgs();

        [MethodImpl(Inline), Op]
        public static PartId[] parse(string[] args, PartId[] fallback)
            => ApiPartIdParser.parse(args,fallback);

        [MethodImpl(Inline), Op]
        public static Assembly controller()
            => Assembly.GetEntryAssembly();

        public static IWfShell create()
            => create(args());

        [Op]
        public static IWfShell create(string[] args)
        {
            var control = controller();
            var controlId = control.Id();
            var logRoot = EnvVars.Common.LogRoot;

            term.inform(string.Format("{0}:{1}", "control", controlId));
            term.inform(string.Format("{0}:{1}", "args", delimit(args)));
            term.inform(string.Format("{0}:{1}", "logs.root", logRoot));

            var api = parts(control, args);
            var partIdList = api.Api.PartIdentities;
            term.inform(string.Format("{0}:{1}", "api.components.length", partIdList.Length));
            term.inform(string.Format("{0}:{1}", "api.components", delimit(partIdList)));

            var logConfig = config(controlId, logRoot, dbRoot());
            term.inform(string.Format("{0}:{1}", "logs.config", logConfig.Format()));

            IWfPaths _paths = new WfPaths(logConfig);
            var ctx = new WfContext();
            ctx.ApiParts = api;
            ctx.Args = args;
            ctx.Paths = _paths;
            ctx.Settings = JsonSettings.Load(_paths.AppConfigPath);
            ctx.WfSettings = new WfSettings(ctx.Settings);
            ctx.TestLogPaths = new TestLogPaths(logRoot);
            ctx.Controller = control;

            var init = new WfInit(ctx, logConfig, partIdList);
            term.inform(string.Format("{0}:{1}", "wf.init", init.ControlId));

            var wf = new WfShell(init);
            term.inform(string.Format("{0}:{1}", "wf", wf.AppName));
            return wf;
        }
    }
}
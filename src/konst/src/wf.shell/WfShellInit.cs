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

    [ApiHost(ApiNames.WfShellInit, true)]
    public readonly struct WfShellInit
    {
       [MethodImpl(Inline), Op]
        public static string[] args()
            => Environment.GetCommandLineArgs();

        [MethodImpl(Inline), Op]
        public static Assembly controller()
            => Assembly.GetEntryAssembly();

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

        [Op]
        public static IWfShell create(string[] args, bool verbose = false)
        {
            var control = controller();
            var controlId = control.Id();
            var configured = list<string>();

            var logRoot = EnvVars.Common.DbRoot + FS.folder("logs") + FS.folder("apps");
            var api = parts(control, args);
            var partList = api.Api.PartIdentities;
            var partCount = partList.Length;
            var logConfig = WfShellInit.logConfig(controlId, logRoot);

            IWfPaths _paths = new WfPaths(logConfig);
            var ctx = new WfContext();
            ctx.ApiParts = api;
            ctx.Args = args;
            ctx.Paths = _paths;
            ctx.Settings = JsonSettings.Load(_paths.AppConfigPath);
            ctx.WfSettings = new WfSettings(ctx.Settings);
            ctx.TestLogPaths = new TestLogPaths(logRoot);
            ctx.Controller = control;

            var init = new WfInit(ctx, logConfig, partList);
            IWfShell wf = new WfShell(init);

            configured.Add(string.Format("{0}:{1}", "control", controlId));
            configured.Add(string.Format("{0}:{1}", "args", delimit(args)));
            configured.Add(string.Format("{0}:{1}", "logs.root", logRoot));
            configured.Add(string.Format("{0}:{1}", "PartCount", partCount));
            configured.Add(string.Format("{0}:{1}", "PartList", delimit(partList)));
            configured.Add(string.Format("{0}:{1}", nameof(WfLogConfig), logConfig.Format()));
            configured.Add(string.Format("{0}:{1}", "wf.init", init.ControlId));
            configured.Add(string.Format("{0}:{1}", "wf", wf.AppName));

            if(verbose)
                wf.Status(configured.FormatList(FieldDelimiter));
            return wf;
        }

        [MethodImpl(Inline), Op]
        public static IWfEventLog log(WfLogConfig config)
            => new WfEventLog(config);

        [MethodImpl(Inline), Op]
        public static WfLogConfig logConfig(PartId part, FS.FolderPath logRoot, FS.FolderPath dbRoot)
            => new WfLogConfig(part, logRoot, dbRoot);

        [MethodImpl(Inline), Op]
        public static FS.FolderPath dbRoot()
            => EnvVars.Common.DbRoot;

        [MethodImpl(Inline), Op]
        public static WfLogConfig logConfig(PartId part, FS.FolderPath root)
            => logConfig(part, root, dbRoot());

        [MethodImpl(Inline), Op]
        public static FS.FolderPath logRoot()
            => dbRoot() + FS.folder("logs") + FS.folder("wf");

        [MethodImpl(Inline), Op]
        public static IWfPaths paths()
            => new WfPaths(logConfig(controller().Id(), logRoot(), dbRoot()));

        [MethodImpl(Inline), Op]
        public static IJsonSettings json(IWfPaths paths)
            => JsonSettings.Load(paths.AppConfigPath);
    }
}
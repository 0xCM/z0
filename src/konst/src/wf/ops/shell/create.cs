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
            var filename = FS.file(assname, FileExtensions.Json);
            var src = context.Paths.ConfigRoot + filename;
            JsonSettings.absorb(src, dst);
            return new WfSettings(dst);
        }

        public static FS.FolderPath DbRoot()
            => EnvVars.Common.DbRoot;

        public static FS.FolderPath LogRoot()
            => DbRoot() + FS.folder("logs") + FS.folder("wf");

        [MethodImpl(Inline), Op]
        public static IWfPaths paths()
            => new WfPaths(logs(controller().Id(), LogRoot(), DbRoot()));

        [Op]
        public static IWfContext context()
            => new WfContext();

        public static WfLogConfig logs(PartId part, FS.FolderPath logRoot, FS.FolderPath dbRoot)
            => new WfLogConfig(part, logRoot, dbRoot);

        public static WfLogConfig logs(PartId part, FS.FolderPath root)
            => logs(part, root, DbRoot());

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
            var configured = list<string>();

            configured.Add(string.Format("{0}:{1}", "control", controlId));
            configured.Add(string.Format("{0}:{1}", "args", delimit(args)));
            configured.Add(string.Format("{0}:{1}", "logs.root", logRoot));

            var api = parts(control, args);
            var partList = api.Api.PartIdentities;
            var partCount = partList.Length;
            configured.Add(string.Format("{0}:{1}", "PartCount", partCount));
            configured.Add(string.Format("{0}:{1}", "PartList", delimit(partList)));

            var logConfig = logs(controlId, logRoot);
            configured.Add(string.Format("{0}:{1}", nameof(WfLogConfig), logConfig.Format()));

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
            configured.Add(string.Format("{0}:{1}", "wf.init", init.ControlId));

            IWfShell wf = new WfShell(init);
            configured.Add(string.Format("{0}:{1}", "wf", wf.AppName));
            wf.Status(configured.FormatList(FieldDelimiter));
            return wf;
        }
    }
}
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
        /// <summary>
        /// Creates a T-parametric sink predicated on a <see cref='ValueReceiver{T}'/> process function
        /// </summary>
        /// <param name="wf">The workflow context</param>
        /// <param name="f">The process function</param>
        /// <typeparam name="T">The data type</typeparam>
        public static WfDataSink<T> sink<T>(IWfShell wf, ValueReceiver<T> f)
            where T : struct
                => new WfDataSink<T>(wf, f);

        [MethodImpl(Inline), Op]
        public static IJsonSettings json(IWfPaths paths)
            => JsonSettings.Load(paths.AppConfigPath);

        public static FS.FolderPath DbRoot()
            => EnvVars.Common.DbRoot;

        public static FS.FolderPath LogRoot()
            => DbRoot() + FS.folder("logs") + FS.folder("wf");

        [Op]
        public static IWfShell create(string[] args)
        {
            var control = controller();
            var controlId = control.Id();
            var configured = list<string>();

            var logRoot = EnvVars.Common.DbRoot + FS.folder("logs") + FS.folder("apps");

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
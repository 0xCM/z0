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

    partial struct Flow
    {
        public static WfInit init(Assembly control, string[] args)
        {
            var id = control.Id();
            var ct = correlate(id);
            var modules = ApiQuery.modules(control, args);
            var context = Flow.context(control, modules, args);
            var parts = Flow.parts(args, modules.Api.PartIdentities);
            var src = ApiQuery.modules(FS.path(control.Location).FolderPath);
            var paths = ShellPaths.Default;
            var settings = Flow.settings(context);
            var captureOut = FS.dir(paths.LogRoot.Name) + FS.folder("capture/artifacts");
            var captureLog = FS.dir(paths.LogRoot.Name) + FS.folder("capture/logs");
            var dstArchive = new ArchiveConfig(FolderPath.Define(captureOut.Name));
            return new WfInit(context, args, src, dstArchive, parts, paths.ResourceRoot, paths.AppDataRoot, paths.AppLogRoot, settings);
        }

        public static WfInit init(string[] args)
            => init(Assembly.GetEntryAssembly(), args);

    }
}
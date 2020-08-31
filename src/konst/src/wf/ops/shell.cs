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
    using static TableFunctions;

    partial struct AB
    {
        public static IWfShell shell(params string[] args)
        {
            var paths = ShellPaths.Default;
            var settings = AB.settings(paths);
            var entry = Assembly.GetEntryAssembly();
            var part = entry.Id();
            var ct = correlate(part);
            var parts = PartIdParser.parse(args);
            var modules = ModuleArchives.from(FS.path(entry.Location).FolderPath, parts);
            var api = modules.Api;
            var captureOut = FS.dir(paths.LogRoot.Name) + FS.folder("capture/artifacts");
            var captureLog = FS.dir(paths.LogRoot.Name) + FS.folder("capture/logs");
            var dstArchive = new ArchiveConfig(FolderPath.Define(captureOut.Name));
            var shell = new ShellContext(args, api);
            var config  = new WfConfig(shell, args, modules, dstArchive, parts, paths.ResourceRoot,
                paths.AppDataRoot, paths.AppLogRoot, settings);
            var context = new ShellContext<WfConfig>(api,config);
            return new WfShellContext(context, ct);
        }
    }
}
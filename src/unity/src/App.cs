//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;
    using System.Reflection;
    using static z;

    struct App
    {
        static FS.FolderPath BuildRoot => FS.dir(ShellPaths.Default.DevRoot.Name) + FS.folder(".build");

        public static void Main(params string[] args)
        {
            var wf = Flow.shell(args);

            var build = BuildArchive.create(BuildRoot);
            var bin = build.NetCoreWin64("3.1");
            var modules = ModuleArchive.create(bin);
            foreach(var src in modules.Files())
            {
                wf.DataRow(src);
            }

            // var modules = ModuleArchive.module(w)
        }
    }

    public static partial class XTend { }
}
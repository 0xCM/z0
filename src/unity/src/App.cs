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
        static FS.FolderPath BuildRoot = FS.dir(AppConfig.BuildRoot);

        static IModuleArchive CreateBuildModuleArchive()
            => ModuleArchive.create(BuildRoot);

        static void Print<T>(IWfShell wf, ReadOnlySpan<T> src)
            where T : ITextual
        {
            var count = src.Length;
            if(count != 0)
            {
                ref readonly var lead = ref first(src);
                for(var i=0u; i<count; i++)
                {
                    ref readonly var current = ref skip(lead, i);
                    wf.DataRow(current);
                }
            }
        }

        static void PrintBuildModules(IWfShell wf)
        {
            var modules = CreateBuildModuleArchive();
            Print(wf,modules.Files().ToReadOnlySpan());

        }

        public static void Main(params string[] args)
        {
            var wf = Flow.shell(args);

        }
    }

    public static partial class XTend { }
}
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

    using api = ClrArtifacts;

    struct App
    {
        static FS.FolderPath BuildRoot = FS.dir(@"J:\dev\projects\z0\.build\bin\netcoreapp3.1\win-x64");

        static IModuleArchive CreateBuildModuleArchive()
            => ModuleArchive.create(new ArchiveConfig(BuildRoot));

        [MethodImpl(Inline)]
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
                    wf.Row(current);
                }
            }
        }

        [MethodImpl(Inline)]
        static void Print<T>(IWfShell wf, in T src)
            where T : ITextual
                => wf.Row(src);

        static void PrintBuildModules(IWfShell wf)
        {
            var modules = CreateBuildModuleArchive();
            Print(wf,modules.Files().ToReadOnlySpan());
        }

        static void Traverse(IWfShell wf, ClrArtifactSet<ClrArtifacts.FieldView> src)
        {
            var count = src.Length;
            if(count == 0)
                return;

            var printer = new ClrArtifactPrinter(wf);
            ref readonly var lead = ref src.First;
            for(var i=0; i<count; i++)
            {
                ref readonly var current = ref skip(lead,i);
                printer.Print(current);
            }
        }

        public static void Traverse(IWfShell wf, Assembly src)
        {
            var printer = new ClrArtifactPrinter(wf);
            var models = api.sTypes(src);
            var count = models.Length;
            ref readonly var lead = ref models.First;
            for(var i=0; i<count; i++)
            {
                ref readonly var current = ref skip(lead,i);
                printer.Print(current);

                Traverse(wf,api.vFields(current));
            }
        }

        public static void Main(params string[] args)
        {
            var wf = WfShell.create(args);
            Traverse(wf,Assembly.GetEntryAssembly());

        }
    }

    public static partial class XTend { }
}
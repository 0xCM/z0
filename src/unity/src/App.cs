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
            => ModuleArchive.create(BuildRoot);

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

        public static void Main(params string[] args)
        {
            var wf = WfShell.create(args);

        }
    }

    public static partial class XTend { }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Reflection;

    using static z;
    using static Konst;
    using static FileExtensions;

    [ApiHost]
    public readonly struct RuntimeArchive : IFileArchive
    {
        public FS.FolderPath Root {get;}

        public FS.Files Files {get;}

        [MethodImpl(Inline)]
        public static RuntimeArchive create()
            => new RuntimeArchive(FS.dir(RuntimeEnvironment.GetRuntimeDirectory()));

        [MethodImpl(Inline)]
        public static RuntimeArchive create(FS.FolderPath src)
            => new RuntimeArchive(src);

        [Op]
        public static string format(RuntimeAssembly src)
            => string.Format("{0}:{1}", src.Component.GetSimpleName(), src.Path.ToUri());

        [MethodImpl(Inline)]
        public static RuntimeAssembly assembly(Assembly component)
            => new RuntimeAssembly(component, FS.path(component.Location));

        [MethodImpl(Inline)]
        public static RuntimeAssembly assembly(Assembly component, FS.FilePath path)
            => new RuntimeAssembly(component, path);

        [MethodImpl(Inline)]
        public static RuntimeAssembly assembly(FS.FilePath src)
            => new RuntimeAssembly(Assembly.LoadFile(src.Name), src);

        public RuntimeAssembly MsBuild
            => assembly(Root + FS.file("MsBuild", Dll));

        public Assembly MsBuildFramework
            => typeof(Microsoft.Build.Framework.BuildEngineResult).Assembly;

        public Assembly MsBuildTasks
            => typeof(Microsoft.Build.Tasks.AssignCulture).Assembly;

        public Assembly MsBuildUtilities
            => typeof(Microsoft.Build.Utilities.MuxLogger).Assembly;

        public Assembly MsCSharp
            => assembly(Root + FS.file("Microsoft.CSharp", Dll));

        public Assembly Dia2Lib
            => typeof(Dia2Lib._FILETIME).Assembly;

        public Assembly MsTraceEvent
            => typeof(Microsoft.Diagnostics.Symbols.NativeSymbolModule).Assembly;

        public Assembly CSharpWorkspaces
            => typeof(Microsoft.CodeAnalysis.CSharp.Formatting.BinaryOperatorSpacingOptions).Assembly;

        public Assembly CodeAnalysis
            => typeof(Microsoft.CodeAnalysis.Emit.InstrumentationKind).Assembly;

        public Assembly Srm
            => typeof(System.Reflection.Metadata.AssemblyDefinition).Assembly;

        [MethodImpl(Inline)]
        internal RuntimeArchive(FS.FolderPath root)
        {
            Root = root;
            Files = root.Files(false, Exe, Dll, Pdb, Json, Xml).Where(x => !x.Name.Contains("System.Private.CoreLib"));
        }

        public FS.Files ManagedLibraries
            => Files.Where(x => FS.managed(x) && x.Is(Dll)).Array();

        public FS.Files ManagedExecutables
            => Files.Where(x => FS.managed(x) && x.Is(Exe)).Array();

        public FS.Files NativeLibraries
            => Files.Where(x => !FS.managed(x) && x.Is(FileExtensions.Dll)).Array();

        public FS.Files NativeExecutables
            => Files.Where(x => !FS.managed(x) && x.Is(Exe)).Array();

        public FS.Files ExeFiles
            => Files.Where(x => x.Is(Exe)).Array();

        public FS.Files JsonFiles
            => Files.Where(x => x.Is(Json)).Array();

        public FS.Files XmlFiles
            => Files.Where(x => x.Is(Xml)).Array();

        public FS.Files DllFiles
            => Files.Where(x => x.Is(Dll)).Array();

        public FS.Files PdbFiles
            => Files.Where(x => x.Is(Pdb)).Array();
    }

    partial class XTend
    {
        [Op]
        public static RuntimeArchive RuntimeArchive(this IWfShell wf)
            => Z0.RuntimeArchive.create();

        [Op]
        public static RuntimeArchive RuntimeArchive(this IWfShell wf, FS.FolderPath src)
            => Z0.RuntimeArchive.create(src);
    }
}
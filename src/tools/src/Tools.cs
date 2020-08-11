//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Tools;
    
    using static Konst;

    [ApiHost("api")]
    public readonly struct Tooling
    {
        public static ListedFiles listed<T,F>(ToolFiles<T,F> src)   
            where T : struct, ITool<T>
            where F : unmanaged, Enum  
        {   
            var view = src.View;
            var buffer = sys.alloc<ListedFile>(src.Count);
            var dst = z.span(buffer);
            for(var i=0u; i<src.Count; i++)
                z.seek(dst,i) = new ListedFile(i, z.skip(view,i).Path.Name);
            return buffer;
        }

        [MethodImpl(Inline), Op]
        public static ToolConfig config(ToolId tool,FilePath src)
            => new ToolConfig(tool,src);

        [MethodImpl(Inline)]
        public static ToolProcessor<T,F> processor<T,F>(IWfContext wf, Action<IToolFile<T,F>> handler)
            where T : struct, ITool<T,F>            
            where F : unmanaged, Enum   
                => new ToolProcessor<T,F>(wf, handler);

        [MethodImpl(Inline)]
        public static ExtensionMap<F> ext<F>(F f = default)
            where F : unmanaged, Enum            
                => new ExtensionMap<F>(0);

        [MethodImpl(Inline), Op]
        public static DumpBin dumpbin(IWfContext wf)
            => new DumpBin(wf, ToolSourceDir, ToolTargetRoot + FolderName.Define(DumpBin.ToolName));

        [MethodImpl(Inline)]
        public static Tool<T,F> tool<T,F>(ToolId id, FolderPath src, FolderPath dst)
            where T : struct, ITool<T,F>
            where F : unmanaged, Enum            
                => new Tool<T,F>(id, src, dst);

        [MethodImpl(Inline)]
        public static ToolFile<T,F> file<T,F>(F kind, FilePath path)
            where T : struct, ITool<T>
            where F : unmanaged, Enum   
                => new ToolFile<T,F>(kind, path);

        [MethodImpl(Inline)]
        public static ToolArchive<T,F> archive<T,F>(ToolId id, FolderPath root)
            where T : struct, ITool<T,F>
            where F : unmanaged, Enum   
                => new ToolArchive<T,F>(id,root);         

        static FolderPath ToolTargetRoot
            => AppPaths.Default.LogRoot + FolderName.Define("tools");

        static FolderPath ToolSourceDir
            => FolderPath.Define("J:/assets/tools");
    }
}
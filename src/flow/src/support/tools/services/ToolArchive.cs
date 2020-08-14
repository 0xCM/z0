//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct ToolArchive    
    {     
        [MethodImpl(Inline)]
        public static ToolArchive<T> create<T>(FolderPath src, FolderPath dst)
            where T : struct, ITool<T>
                => new ToolArchive<T>(default(T).ToolId, src, dst);

        [MethodImpl(Inline)]
        public static Files output<T>(IToolArchive<T> archive)
            where T : struct, ITool<T>
                => Files.from(archive.ToolOutput.AllFiles);

        [MethodImpl(Inline)]
        public static Files processed<T>(IToolArchive<T> archive)
            where T : struct, ITool<T>
                => Files.from(archive.Processed.AllFiles);

        // [MethodImpl(Inline)]
        // public static FolderPath root<T,F>(IToolArchive<T,F> archive)
        //     where T : struct, ITool<T>
        //     where F : unmanaged, Enum
        //         => archive.ToolOutput;

        // [MethodImpl(Inline)]
        // public static FileExtension ext<T,F>(IToolArchive<T,F> archive, F f = default)
        //     where T : struct, ITool<T>
        //     where F : unmanaged, Enum
        //         => archive.Map.Ext(f);

        // public static void map<T,F>(IToolArchive<T,F> archive, F flag, FileExtension ext)
        //     where T : struct, ITool<T>
        //     where F : unmanaged, Enum
        //         => archive.Map.MapExtension(flag,ext);

        // public static Files output<T,F>(IToolArchive<T,F> archive, F f)
        //     where T : struct, ITool<T>
        //     where F : unmanaged, Enum
        //         => Files.from(root(archive).Files(ext(archive,f)));            

        // public static ToolFiles<T,F> dir<T,F>(IToolArchive<T,F> archive, F f)
        //     where T : struct, ITool<T>
        //     where F : unmanaged, Enum
        //         => output(archive,f).Map(path => new ToolFile<T,F>(f, path));

        // public static ToolFiles<T,F> dir<T,F>(IToolArchive<T,F> archive)
        //     where T : struct, ITool<T>
        //     where F : unmanaged, Enum
        //         => archive.ToolOutput.AllFiles.Map(f => new ToolFile<T,F>(f));
    }
}
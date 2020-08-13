//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    
    public readonly struct ToolArchive    
    {
        public static FolderName folder<T,F>(IToolArchive<T,F> archive, F f)
            where T : struct, ITool<T>
            where F : unmanaged, Enum
                => FolderName.Define(f.ToString().ToLower());        
     
        public static FilePath Path<T,F>(IToolArchive<T,F> archive, F f, FileName file)
            where T : struct, ITool<T>
            where F : unmanaged, Enum
                => (archive.Root + folder(archive, f)) + file;

        public static FolderPath dir<T,F>(IToolArchive<T,F> archive, F f)
            where T : struct, ITool<T>
            where F : unmanaged, Enum
                => archive.Root + folder(archive, f);        

        public static FileExtension ext<T,F>(IToolArchive<T,F> archive, F f)
            where T : struct, ITool<T>
            where F : unmanaged, Enum
                => archive.Map.Ext(f);

        public static void map<T,F>(IToolArchive<T,F> archive, F flag, FileExtension ext)
            where T : struct, ITool<T>
            where F : unmanaged, Enum
                => archive.Map.MapExtension(flag,ext);

        public static Files output<T,F>(IToolArchive<T,F> archive, F f)
            where T : struct, ITool<T>
            where F : unmanaged, Enum
                => Files.from(dir(archive, f).Files(ext(archive,f)));            

        public static ToolFiles<T,F> files<T,F>(IToolArchive<T,F> archive, F f)
            where T : struct, ITool<T>
            where F : unmanaged, Enum
                => output(archive,f).Map(path => new ToolFile<T,F>(f, path));
    }
}
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
    }
}
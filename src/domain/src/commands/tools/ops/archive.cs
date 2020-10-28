//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Tooling
    {
        [MethodImpl(Inline)]
        public static ToolArchive<T,F> archive<T,F>(ToolId id, FS.FolderPath root)
            where T : struct, ITool<T,F>
            where F : unmanaged, Enum
                => new ToolArchive<T,F>(id, root);

        [MethodImpl(Inline)]
        public static ToolArchive<T> archive<T>(FS.FolderPath src, FS.FolderPath dst)
            where T : struct, ITool<T>
                => new ToolArchive<T>(default(T).ToolId, src, dst);


        [MethodImpl(Inline)]
        public static FS.Files output<T>(IToolArchive<T> archive)
            where T : struct, ITool<T>
                => archive.ToolOutput.AllFiles;

        [MethodImpl(Inline)]
        public static FS.Files processed<T>(IToolArchive<T> archive)
            where T : struct, ITool<T>
                => archive.Processed.AllFiles;
    }
}
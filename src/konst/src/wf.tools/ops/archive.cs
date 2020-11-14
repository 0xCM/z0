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
        public static ToolArchive<T> archive<T>(ToolId tool, FS.FolderPath src, FS.FolderPath dst)
            where T : struct, ITool<T>
                => new ToolArchive<T>(tool, src, dst);

        [MethodImpl(Inline)]
        public static FS.Files output<T>(IToolArchive<T> archive)
            where T : struct, ITool<T>
                => archive.Target.AllFiles;

        [MethodImpl(Inline)]
        public static FS.Files processed<T>(IToolArchive<T> archive)
            where T : struct, ITool<T>
                => archive.Processed.AllFiles;
    }
}
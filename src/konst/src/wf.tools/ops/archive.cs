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
        public static ToolArchive<T> archive<T>(ToolId tool, FS.FolderPath root, ToolArchiveKind kind)
            where T : struct, ITool<T>
                => new ToolArchive<T>(tool, root, kind);
    }
}
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
        public static ToolArchive<T,F> archive<T,F>(IWfContext wf, ToolId id, FolderPath root)
            where T : struct, ITool<T,F>
            where F : unmanaged, Enum   
                => new ToolArchive<T,F>(wf, id, root);
    }
}
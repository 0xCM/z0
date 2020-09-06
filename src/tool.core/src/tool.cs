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
        public static Tool<T,F> tool<T,F>(IWfShell wf, WfToolId id, FS.FolderPath src, FS.FolderPath dst)
            where T : struct, ITool<T,F>
            where F : unmanaged, Enum
                => new Tool<T,F>(wf, id, src, dst);
    }
}
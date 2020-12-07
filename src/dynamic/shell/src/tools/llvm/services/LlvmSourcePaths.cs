//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct LlvmSourcePaths
    {
        public FS.FolderPath Root {get;}

        public LlvmSourcePaths(FS.FolderPath root)
            => Root = root;

        [MethodImpl(Inline)]
        public LlvmSourcePaths Update(FS.FolderPath root)
            => new LlvmSourcePaths(root);

        public FS.FolderPath IncludeDir => Root + FS.folder("include");
    }
}


//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Llvm
    {
        public readonly struct SourcePaths
        {
            public FS.FolderPath Root {get;}

            public SourcePaths(FS.FolderPath root)
                => Root = root;

            [MethodImpl(Inline)]
            public SourcePaths Update(FS.FolderPath root)
                => new SourcePaths(root);

            public FS.FolderPath IncludeDir
                => Root + FS.folder("include");
        }
    }
}
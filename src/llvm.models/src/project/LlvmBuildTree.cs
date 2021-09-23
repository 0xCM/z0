//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.llvm
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct LlvmBuildTree
    {
        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public LlvmBuildTree(FS.FolderPath root)
        {
            Root = root;
        }
    }
}
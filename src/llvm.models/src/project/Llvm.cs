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

    public readonly partial struct Llvm
    {
        public static LlvmProject project(FS.FolderPath src, FS.FolderPath build)
            => new LlvmProject(new LlvmSourceTree(src), new LlvmBuildTree(build));
    }
}
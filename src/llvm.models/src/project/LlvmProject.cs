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

    public readonly struct LlvmProject
    {
        public LlvmSourceTree Source {get;}

        public LlvmBuildTree Build {get;}

        [MethodImpl(Inline)]
        public LlvmProject(LlvmSourceTree src, LlvmBuildTree build)
        {
            Source = src;
            Build = build;
        }
    }
}
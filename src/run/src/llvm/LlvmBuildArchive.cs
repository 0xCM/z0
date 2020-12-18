//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct LlvmBuildArchive : IBuildArchive
    {
        public FS.FolderPath Root {get;}

        [MethodImpl(Inline)]
        public LlvmBuildArchive(FS.FolderPath root)
            => Root = root;
    }
}
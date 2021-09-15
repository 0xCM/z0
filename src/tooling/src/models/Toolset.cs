//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Toolset
    {
        public FS.FolderPath InstallBase {get;}

        public Index<ToolId> Members {get;}

        [MethodImpl(Inline)]
        public Toolset(FS.FolderPath @base, ToolId[] members)
        {
            InstallBase = @base;
            Members = members;
        }
    }
}
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
        [MethodImpl(Inline), Op]
        public static ToolConfig config(ToolId tool,FolderPath src, FolderPath dst)
            => new ToolConfig(tool,src,dst);
    }
}
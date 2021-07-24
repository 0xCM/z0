//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public readonly struct Toolchains
    {
        public static ToolchainRule rule(ToolId tool, FS.FilePath src, CmdArgs args, FS.FilePath dst)
            => new ToolchainRule(tool,src,args,dst);
    }
}
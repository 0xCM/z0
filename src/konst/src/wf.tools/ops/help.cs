//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct CmdTools
    {
        [MethodImpl(Inline), Op]
        public static ToolHelp help(ToolId tool, string src)
            => new ToolHelp(tool, src);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Tools;
    
    using static Konst;

    partial struct Tooling
    {
        [MethodImpl(Inline), Op]
        public static ToolConfig config(ToolId tool,FilePath src)
            => new ToolConfig(tool,src);
    }
}
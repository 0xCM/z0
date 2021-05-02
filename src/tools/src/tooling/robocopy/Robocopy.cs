//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    [ApiHost]
    public sealed partial class Robocopy : AppService<Robocopy>, ITool<Robocopy>
    {
        public ToolId Id => Toolsets.nasm;

    }
}
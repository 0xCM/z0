//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    [ApiHost]
    public sealed partial class Robocopy : WfService<Robocopy>, ITool<Robocopy>
    {
        public ToolId Id => Toolsets.nasm;

    }
}
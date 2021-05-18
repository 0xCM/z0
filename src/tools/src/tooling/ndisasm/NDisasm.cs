//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;


    [ApiHost]
    public sealed partial class NDisasm : ToolService<NDisasm>
    {
        public NDisasm()
            : base(Toolsets.ndisasm)
        {

        }
    }
}
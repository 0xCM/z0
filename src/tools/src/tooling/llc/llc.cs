//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public partial class llc : ToolCmdBuilder<llc>
    {
        public llc()
            : base(nameof(llc))
        {

        }

    }
}
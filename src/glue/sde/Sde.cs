//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tools
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;


    public class Sde : ToolService<Sde>
    {
        public Sde()
            :base(Toolsets.sde)
        {

        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct ToolCmd
    {
        public ToolId Id {get;}

        public CmdLine Spec {get;}

        [MethodImpl(Inline)]
        public ToolCmd(ToolId id, CmdLine spec)
        {
            Id = id;
            Spec = spec;
        }
    }
}
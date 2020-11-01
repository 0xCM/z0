//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct ToolSpec
    {
        public readonly CmdToolId Id;

        public readonly ToolFlag[] Flags;

        [MethodImpl(Inline)]
        public ToolSpec(CmdToolId id, ToolFlag[] flags)
        {
            Id = id;
            Flags = flags;
        }
    }
}
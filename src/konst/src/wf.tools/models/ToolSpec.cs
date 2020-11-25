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
        public CmdHostId Id {get;}

        public ToolVerb[] Verbs {get;}

        [MethodImpl(Inline)]
        public ToolSpec(CmdHostId id, ToolVerb[] verbs)
        {
            Id = id;
            Verbs = verbs;
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolSpec
    {
        public ToolId Id {get;}

        public CmdFlagSpecs Flags {get;}

        public CmdOptionSpecs Options {get;}

        public UsageSyntax Usage {get;}

        [MethodImpl(Inline)]
        public ToolSpec(ToolId id, CmdFlagSpec[] flags, CmdOptionSpec[] options, UsageSyntax usage)
        {
            Id = id;
            Flags = flags;
            Options = options;
            Usage = usage;
        }
    }
}
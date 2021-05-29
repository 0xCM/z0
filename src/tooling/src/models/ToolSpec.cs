//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ToolSpec
    {
        public ToolId Id {get;}

        public ToolFlagSpecs Flags {get;}

        public ToolOptionSpecs Options {get;}

        public ToolUsage Usage {get;}

        [MethodImpl(Inline)]
        public ToolSpec(ToolId id, ToolFlagSpec[] flags, ToolOptionSpec[] options, ToolUsage usage)
        {
            Id = id;
            Flags = flags;
            Options = options;
            Usage = usage;
        }
    }
}
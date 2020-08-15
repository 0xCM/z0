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
        public readonly ToolId Id;

        public readonly ToolFlag[] Flags;

        public readonly ToolOption[] Options;

        [MethodImpl(Inline)]
        public ToolSpec(string name, ToolFlag[] flags, ToolOption[] options)
        {
            Id = name;
            Flags = flags;
            Options = options;
        }    
    }
}
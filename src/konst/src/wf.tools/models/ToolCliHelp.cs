//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ToolCliHelp : IToolCliHelp
    {
        public ToolId Id {get;}

        public string Content {get;}

        [MethodImpl(Inline)]
        public ToolCliHelp(ToolId id, string content)
        {
            Id = id;
            Content = content;
        }
    }
}
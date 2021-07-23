//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct ToolScript
    {
        public ToolId Tool {get;}

        public TextBlock Content {get;}

        [MethodImpl(Inline)]
        public ToolScript(ToolId tool, TextBlock content)
        {
            Tool = tool;
            Content = content;
        }
    }
}
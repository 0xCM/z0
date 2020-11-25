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

    /// <summary>
    /// Reprents a tool command operand that accepts no arguments; the presence of a flag is the argument
    /// </summary>
    public readonly struct ToolVerb
    {
        public CmdHostId Tool {get;}

        public string Name {get;}

        [MethodImpl(Inline)]
        public ToolVerb(CmdHostId tool, string name)
        {
            Tool = tool;
            Name = name;
        }
    }
}
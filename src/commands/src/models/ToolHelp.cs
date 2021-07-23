//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public struct ToolHelp
    {
        public ToolId Tool {get;}

        public string Description {get;}

        public string Document {get;}

        readonly Index<CmdOption> _Options;

        public ToolHelp(ToolId tool, string doc, string desc, CmdOption[] options)
        {
            Tool = tool;
            Document = doc;
            Description = desc;
            _Options = options;
        }

        public ReadOnlySpan<CmdOption> Options
        {
            [MethodImpl(Inline)]
            get => _Options.View;
        }

        public uint OptionCount
        {
            [MethodImpl(Inline)]
            get => _Options.Count;
        }
    }
}
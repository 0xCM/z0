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

    using api = Cmd;

    public readonly struct CmdLine
    {
        public string ToolName {get;}

        public CmdOptions Options {get;}

        public CmdLine(string tool, CmdOptions options)
        {
            ToolName = tool;
            Options = options;
        }

        public byte OptionCount
        {
            [MethodImpl(Inline)]
            get => Options.Count;
        }
    }
}
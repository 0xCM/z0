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

    public readonly struct CmdParser
    {
        public ParseResult<CmdSpec> ParseSpec(string src)
            => Cmd.parse(src);

        public ParseResult<CmdId> ParseId(string src)
            => Cmd.id(src);

        public ParseResult<CmdOption> ParseOption(string src)
            => Cmd.option(src);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static memory;

    [Cmd(CmdName)]
    public readonly struct ShowVerbsCmd : ICmdSpec<ShowVerbsCmd>
    {
        public const string CmdName = "show-verbs";
    }
}
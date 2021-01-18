//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Cmd(CmdName)]
    public readonly struct ShowConfigCmd : ICmd<ShowConfigCmd>
    {
        public const string CmdName = "show-config";
    }
}
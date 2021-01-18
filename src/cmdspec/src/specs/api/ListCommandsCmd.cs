//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [Cmd(CmdName)]
    public struct ListCommands : ICmd<ListFilesCmd>
    {
        public const string CmdName = "list-commands";

        public FS.FilePath? Target;

    }
}
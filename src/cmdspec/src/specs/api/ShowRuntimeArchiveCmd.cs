//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;

    [Cmd(CmdName)]
    public struct ShowRuntimeArchiveCmd : ICmd<ShowRuntimeArchiveCmd>
    {
        public const string CmdName = "show-runtime-archive";
    }
}
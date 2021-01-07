//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;

    [Cmd(CmdName)]
    public struct ShowRuntimeArchiveCmd : ICmdSpec<ShowRuntimeArchiveCmd>
    {
        public const string CmdName = "show-runtime-archive";
    }

    partial class XCmd
    {
        [MethodImpl(Inline)]
        public static ShowRuntimeArchiveCmd ShowRuntimeArchive(this CmdBuilder wf)
            => default;
    }
}
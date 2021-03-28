//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;

    [Cmd(CmdName)]
    public readonly struct ShowEnvCmd : ICmd<ShowEnvCmd>
    {
        public const string CmdName = "show-env";
    }

    partial class XCmd
    {
        [MethodImpl(Inline), Op]
        public static ShowEnvCmd ShowEnv(this WfCmdBuilder builder)
        {
            var dst = new ShowEnvCmd();
            return dst;
        }
    }
}
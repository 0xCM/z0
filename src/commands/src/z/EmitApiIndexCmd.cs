//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct EmitApiIndexCmd : ICmdSpec<EmitApiIndexCmd>
    {
        public const string CmdName = "emit-hex-index";
    }

    partial class XCmd
    {
        [Op]
        public static EmitApiIndexCmd EmitApiIndex(this CmdBuilder builder)
        {
            var dst = new EmitApiIndexCmd();

            return dst;
        }
    }
}
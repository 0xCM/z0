//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct EmitHexIndexCmd : ICmd<EmitHexIndexCmd>
    {
        public const string CmdName = "emit-hex-index";
    }

    partial class XCmd
    {
        [Op]
        public static EmitHexIndexCmd EmitHexIndex(this CmdBuilder builder)
        {
            var dst = new EmitHexIndexCmd();

            return dst;
        }

    }
}
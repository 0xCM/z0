//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct EmitRuntimeIndexCmd : ICmdSpec<EmitRuntimeIndexCmd>
    {
        public const string CmdName = "emit-runtime-index";
    }

    partial class XCmd
    {
        [Op]
        public static EmitRuntimeIndexCmd EmitRuntimeIndex(this CmdBuilder builder)
        {
            var dst = new EmitRuntimeIndexCmd();

            return dst;
        }
    }
}
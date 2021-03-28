//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Cmd(CmdName)]
    public struct CheckBitMasksCmd : ICmd<CheckBitMasksCmd>
    {
        public const string CmdName = "check-bitmasks";
    }

    partial class XCmd
    {
        [MethodImpl(Inline), Op]
        public static CheckBitMasksCmd CheckBitmasks(this WfCmdBuilder builder)
        {
            var cmd = new CheckBitMasksCmd();
            return cmd;
        }
    }
}
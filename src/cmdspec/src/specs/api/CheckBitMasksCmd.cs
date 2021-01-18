//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Cmd(CmdName)]
    public struct CheckBitMasksCmd : ICmd<CheckBitMasksCmd>
    {
        public const string CmdName = "check-bitmasks";
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;

    /// <summary>
    /// Defines the lock prefix code
    /// </summary>
    [PrefixCodes]
    public enum LockPrefixCode : byte
    {
        None = 0,

        LOCK = xf0,
    }
}
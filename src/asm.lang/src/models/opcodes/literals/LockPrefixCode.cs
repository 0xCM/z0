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
    public enum LockPrefixCode : byte
    {
        Lock = xf0,
    }
}
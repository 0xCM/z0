//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;

    partial struct AsmCodes
    {
        /// <summary>
        /// Defines the lock prefix code
        /// </summary>
        [SymSource]
        public enum LockPrefixCode : byte
        {
            None = 0,

            [Symbol("f0", "Lock Prefix")]
            LOCK = xf0,
        }
    }
}
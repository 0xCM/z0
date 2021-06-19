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
        public enum LockPrefix : byte
        {
            LOCK = xf0,
        }
    }
}
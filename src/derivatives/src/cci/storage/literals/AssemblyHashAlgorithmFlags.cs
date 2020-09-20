//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    partial struct ClrStorage
    {
        [Flags]
        public enum AssemblyHashAlgorithmFlags : uint
        {
            None = 0x00000000,

            MD5 = 0x00008003,

            SHA1 = 0x00008004
        }
    }
}
//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    partial struct ClrStorage
    {
        public enum PEMagic : ushort
        {
            PEMagic32 = 0x010B,

            PEMagic64 = 0x020B,
        }
    }
}
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
        [Flags]
        public enum EventFlags : ushort
        {
            SpecialNameImpl = 0x0200,

            RTSpecialNameReserved = 0x0400,

            //  Load flags
            AdderLoaded = 0x0001,

            RemoverLoaded = 0x0002,

            FireLoaded = 0x0004,
        }
    }
}
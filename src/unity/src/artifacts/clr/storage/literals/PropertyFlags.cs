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
        public enum PropertyFlags : ushort
        {
            SpecialNameImpl = 0x0200,

            RTSpecialNameReserved = 0x0400,

            HasDefaultReserved = 0x1000,

            //  Comes from signature...
            HasThis = 0x0001,

            ReturnValueIsByReference = 0x0002,
            //  Load flags

            GetterLoaded = 0x0004,

            SetterLoaded = 0x0008,
        }
    }
}
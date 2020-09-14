//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;

    partial struct ClrStorage
    {
        public enum SEHFlags : uint
        {
            Catch = 0x0000,

            Filter = 0x0001,

            Finally = 0x0002,

            Fault = 0x0004,
        }

    }
}
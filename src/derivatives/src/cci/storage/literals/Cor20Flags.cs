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
        public enum COR20Flags : uint
        {
            ILOnly = 0x00000001,

            Bit32Required = 0x00000002,

            ILLibrary = 0x00000004,

            StrongNameSigned = 0x00000008,

            NativeEntryPoint = 0x00000010,

            TrackDebugData = 0x00010000,

            Prefers32bits = 0x00020000,
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Pe
{
    using System;

    [Flags]
    public enum CorFlags
    {
        ILOnly = 0x1,

        Requires32Bit = 0x2,

        ILLibrary = 0x4,

        StrongNameSigned = 0x8,

        NativeEntryPoint = 0x10,

        TrackDebugData = 0x10000,

        Prefers32Bit = 0x20000
    }
}
//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    [Flags]
    public enum CorFlags
    {
        ILOnly = 1,
        
        Requires32Bit = 2,
        
        ILLibrary = 4,
        
        StrongNameSigned = 8,
        
        NativeEntryPoint = 16,
        
        TrackDebugData = 65536,
        
        Prefers32Bit = 131072,
    }

}
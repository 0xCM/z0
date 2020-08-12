//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;

    [Flags]
    public enum PEStreamOptions
    {
        Default = 0,
        
        LeaveOpen = 1,
        
        PrefetchMetadata = 2,
        
        PrefetchEntireImage = 4,
        
        IsLoadedImage = 8,
    }
}
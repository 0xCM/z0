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
    public enum ManifestResourceAttributes
    {
        Public = 1,
     
        Private = 2,
     
        VisibilityMask = 7,
    }
}
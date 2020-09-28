//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System;

    partial struct MetadataRows
    {
        [Flags]
        public enum ManifestResourceFlags : uint
        {
            PublicVisibility = 0x00000001,

            PrivateVisibility = 0x00000002,

            VisibilityMask = 0x00000007,

            InExternalFile = 0x00000010,
        }
    }
}
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
        public enum FileFlags : uint
        {
            ContainsMetadata = 0x00000000,

            ContainsNoMetadata = 0x00000001,
        }
    }
}
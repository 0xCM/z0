//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using static Part;

    public readonly struct MetadataStreamConstants
    {
        public const int SizeOfMetadataTableHeader = 24;
        public const uint LargeTableRowCount = 0x00010000;
    }

}
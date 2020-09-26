//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System;

    [Flags]
    public enum HeapSizeKind : byte
    {
        StringHeapLarge = 0x01, // 4 byte uint indexes used for string heap offsets

        GuidHeapLarge = 0x02,   // 4 byte uint indexes used for GUID heap offsets

        BlobHeapLarge = 0x04,   // 4 byte uint indexes used for Blob heap offsets

        EncDeltas = 0x20,       // Indicates only EnC Deltas are present

        DeletedMarks = 0x80,    // Indicates metadata might contain items marked deleted
    }
}

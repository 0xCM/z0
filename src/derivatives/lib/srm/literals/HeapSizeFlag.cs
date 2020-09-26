//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System;

    public enum HeapSizeFlag : byte
    {
        StringHeapLarge = 0x01, //  4 byte uint indexes used for string heap offsets

        GUIDHeapLarge = 0x02, //  4 byte uint indexes used for GUID heap offsets

        BlobHeapLarge = 0x04, //  4 byte uint indexes used for Blob heap offsets

        EnCDeltas = 0x20, //  Indicates only EnC Deltas are present

        DeletedMarks = 0x80, //  Indicates metadata might contain items marked deleted
    }

}
//-----------------------------------------------------------------------------
// Derivative Work
// Origin:    : https://github.com/microsoft/scalar
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    public enum HeapSizes : byte
    {
        StringHeapLarge = 0x01, // 4 byte uint indexes used for string heap offsets

        GuidHeapLarge = 0x02,   // 4 byte uint indexes used for GUID heap offsets

        BlobHeapLarge = 0x04,   // 4 byte uint indexes used for Blob heap offsets

        ExtraData = 0x40,       // Indicates that there is an extra 4 bytes of data immediately after the row counts
    }
}
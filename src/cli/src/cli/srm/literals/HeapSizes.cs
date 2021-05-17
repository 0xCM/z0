//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata/src/System/Reflection/Metadata/MetadataReader.cs
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class SRM
    {
        public enum HeapSizes : byte
        {
            StringHeapLarge = 0x01, // 4 byte uint indexes used for string heap offsets
            GuidHeapLarge = 0x02,   // 4 byte uint indexes used for GUID heap offsets
            BlobHeapLarge = 0x04,   // 4 byte uint indexes used for Blob heap offsets
            ExtraData = 0x40,       // Indicates that there is an extra 4 bytes of data immediately after the row counts
        }
    }
}
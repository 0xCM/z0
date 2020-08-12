//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    [Table]
    public struct IMAGE_DEBUG_DIRECTORY
    {
        public int Characteristics;

        public int TimeDateStamp;

        public short MajorVersion;

        public short MinorVersion;

        public IMAGE_DEBUG_TYPE Type;

        public int SizeOfData;

        public int AddressOfRawData;

        public int PointerToRawData;
    }                
}
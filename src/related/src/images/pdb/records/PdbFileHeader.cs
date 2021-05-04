//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial struct ImageRecords
    {
        [Record]
        public struct PdbFileHeader : IRecord<PdbFileHeader>
        {
            public Cell256 Magic;

            public Cell32 PageSize;

            public Cell32 FreePageMap;

            public Cell32 PagesUsed;

            public Cell32 DirectorySize;

            public Cell32 Reserved;
        }
    }
    /*
                return new byte[]
                {
                    0x4D, 0x69, 0x63, 0x72, 0x6F, 0x73, 0x6F, 0x66, // "Microsof"
                    0x74, 0x20, 0x43, 0x2F, 0x43, 0x2B, 0x2B, 0x20, // "t C/C++ "
                    0x4D, 0x53, 0x46, 0x20, 0x37, 0x2E, 0x30, 0x30, // "MSF 7.00"
                    0x0D, 0x0A, 0x1A, 0x44, 0x53, 0x00, 0x00, 0x00  // "^^^DS^^^"
                };

    */
}
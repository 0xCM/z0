//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Part;

    partial struct ClrStorage
    {
        public static class PEFileConstants
        {
            public const ushort DosSignature = 0x5A4D; // MZ

            public const int PESignatureOffsetLocation = 0x3C;

            public const uint PESignature = 0x00004550; // PE00

            public const int BasicPEHeaderSize = PEFileConstants.PESignatureOffsetLocation;

            public const int SizeofCOFFFileHeader = 20;

            public const int SizeofOptionalHeaderStandardFields32 = 28;

            public const int SizeofOptionalHeaderStandardFields64 = 24;

            public const int SizeofOptionalHeaderNTAdditionalFields32 = 68;

            public const int SizeofOptionalHeaderNTAdditionalFields64 = 88;

            public const int NumberofOptionalHeaderDirectoryEntries = 16;

            public const int SizeofOptionalHeaderDirectoriesEntries = 16 * 8;

            public const int SizeofSectionHeader = 40;

            public const int SizeofSectionName = 8;

            public const int SizeofResourceDirectory = 16;

            public const int SizeofResourceDirectoryEntry = 8;
        }
    }

}
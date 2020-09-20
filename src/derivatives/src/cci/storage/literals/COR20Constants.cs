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
        public readonly struct COR20Constants
        {
            public const int SizeOfCOR20Header = 72;

            public const uint COR20MetadataSignature = 0x424A5342;

            public const int MinimumSizeofMetadataHeader = 16;

            public const int SizeofStorageHeader = 4;

            public const int MinimumSizeofStreamHeader = 8;

            public const string StringStreamName = "#Strings";

            public const string BlobStreamName = "#Blob";

            public const string GUIDStreamName = "#GUID";

            public const string UserStringStreamName = "#US";

            public const string CompressedMetadataTableStreamName = "#~";

            public const string UncompressedMetadataTableStreamName = "#-";

            public const int LargeStreamHeapSize = 0x0001000;
        }


    }

}
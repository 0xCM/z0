//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Image
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct IMAGE_OPTIONAL_HEADER_SPECIFIC
    {
        public ulong SizeOfStackReserve;

        public ulong SizeOfStackCommit;

        public ulong SizeOfHeapReserve;

        public ulong SizeOfHeapCommit;

        public uint LoaderFlags;

        public uint NumberOfRvaAndSizes;
    }
}
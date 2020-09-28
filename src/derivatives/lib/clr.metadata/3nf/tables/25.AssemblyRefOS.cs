//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Images
{
    using System;
    using System.Runtime.InteropServices;

    partial struct ClrMetadata
    {
        //  0x25
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyRefOS
        {
            public uint OSPlatformId;

            public uint OSMajorVersionId;

            public uint OSMinorVersionId;

            public uint AssemblyRef;
        }
    }
}
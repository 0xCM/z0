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
        //  0x28
        [StructLayout(LayoutKind.Sequential)]
        public struct ManifestResource
        {
            public uint Offset;

            public ManifestResourceFlags Flags;

            public uint Name;

            public uint Implementation;
        }
    }
}
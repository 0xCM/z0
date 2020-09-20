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
        [StructLayout(LayoutKind.Sequential)]
        public struct MetadataHeader
        {
            public uint Signature;

            public ushort MajorVersion;

            public ushort MinorVersion;

            public uint ExtraData;

            public int VersionStringSize;

            public string VersionString;
        }
    }
}
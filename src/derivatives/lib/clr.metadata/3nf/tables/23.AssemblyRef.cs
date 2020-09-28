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
        //  0x23
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyRef
        {
            public ushort MajorVersion;

            public ushort MinorVersion;

            public ushort BuildNumber;

            public ushort RevisionNumber;

            public AssemblyFlags Flags;

            public uint PublicKeyOrToken;

            public uint Name;

            public uint Culture;

            public uint HashValue;
        }
    }
}
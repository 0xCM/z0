//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System;
    using System.Runtime.InteropServices;

    partial struct MetadataRows
    {
        //  0x22
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyOS
        {
            public uint OSPlatformId;

            public uint OSMajorVersionId;

            public uint OSMinorVersionId;
        }

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

        //  0x24
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyRefProcessor
        {
            public uint Processor;
            public uint AssemblyRef;

        }

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
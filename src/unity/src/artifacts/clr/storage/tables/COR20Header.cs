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

    using static Konst;

    partial struct ClrStorage
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct COR20Header
        {
            public ByteSize CountBytes;

            public ushort MajorRuntimeVersion;

            public ushort MinorRuntimeVersion;

            public DirectoryEntry MetaDataDirectory;

            public COR20Flags COR20Flags;

            public Address32 EntryPointTokenOrRVA;

            public DirectoryEntry ResourcesDirectory;

            public DirectoryEntry StrongNameSignatureDirectory;

            public DirectoryEntry CodeManagerTableDirectory;

            public DirectoryEntry VtableFixupsDirectory;

            public DirectoryEntry ExportAddressTableJumpsDirectory;

            public DirectoryEntry ManagedNativeHeaderDirectory;
        }

    }
}
//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.SRM
{
    using System.Runtime.InteropServices;

    using Z0.Image;

    [StructLayout(LayoutKind.Sequential)]
    public struct COR20Header
    {
        public uint CountBytes;

        public ushort MajorRuntimeVersion;

        public ushort MinorRuntimeVersion;

        public DirectoryEntry MetaDataDirectory;

        public COR20Flags COR20Flags;

        public uint EntryPointTokenOrRVA;

        public DirectoryEntry ResourcesDirectory;

        public DirectoryEntry StrongNameSignatureDirectory;

        public DirectoryEntry CodeManagerTableDirectory;

        public DirectoryEntry VtableFixupsDirectory;

        public DirectoryEntry ExportAddressTableJumpsDirectory;

        public DirectoryEntry ManagedNativeHeaderDirectory;
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Pe
{
    using System.Runtime.InteropServices;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct CorHeader : IRecord<CorHeader>
    {
        public const string TableId = "pe-corheader";

        public ushort MajorRuntimeVersion;

        public ushort MinorRuntimeVersion;

        public ImageDirectoryEntry MetadataDirectory;

        public CorFlags Flags;

        public int EntryPointTokenOrRelativeVirtualAddress;

        public ImageDirectoryEntry ResourcesDirectory;

        public ImageDirectoryEntry StrongNameSignatureDirectory;

        public ImageDirectoryEntry CodeManagerTableDirectory;

        public ImageDirectoryEntry VtableFixupsDirectory;

        public ImageDirectoryEntry ExportAddressTableJumpsDirectory;

        public ImageDirectoryEntry ManagedNativeHeaderDirectory;
    }
}
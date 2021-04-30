//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;
    using System.Reflection.PortableExecutable;

    partial struct Images
    {
        [Record(TableId), StructLayout(LayoutKind.Sequential)]
        public struct CorHeaderRow : IRecord<CorHeaderRow>
        {
            public const string TableId = "pe-corheader";

            public ushort MajorRuntimeVersion;

            public ushort MinorRuntimeVersion;

            public DirectoryEntryRow MetadataDirectory;

            public CorFlags Flags;

            public int EntryPointTokenOrRelativeVirtualAddress;

            public DirectoryEntryRow ResourcesDirectory;

            public DirectoryEntryRow StrongNameSignatureDirectory;

            public DirectoryEntryRow CodeManagerTableDirectory;

            public DirectoryEntryRow VtableFixupsDirectory;

            public DirectoryEntryRow ExportAddressTableJumpsDirectory;

            public DirectoryEntryRow ManagedNativeHeaderDirectory;
        }
    }
}
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

    using static Part;

    [StructLayout(LayoutKind.Sequential)]
    public struct OptionalHeaderDirectoryEntries
    {
        public DirectoryEntry ExportTableDirectory;

        public DirectoryEntry ImportTableDirectory;

        public DirectoryEntry ResourceTableDirectory;

        public DirectoryEntry ExceptionTableDirectory;

        public DirectoryEntry CertificateTableDirectory;

        public DirectoryEntry BaseRelocationTableDirectory;

        public DirectoryEntry DebugTableDirectory;

        public DirectoryEntry CopyrightTableDirectory;

        public DirectoryEntry GlobalPointerTableDirectory;

        public DirectoryEntry ThreadLocalStorageTableDirectory;

        public DirectoryEntry LoadConfigTableDirectory;

        public DirectoryEntry BoundImportTableDirectory;

        public DirectoryEntry ImportAddressTableDirectory;

        public DirectoryEntry DelayImportTableDirectory;

        public DirectoryEntry COR20HeaderTableDirectory;

        public DirectoryEntry ReservedDirectory;
    }
}
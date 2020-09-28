//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;
    using System;

    using Z0.Image;

    partial struct ImageTables
    {
        [Table, StructLayout (LayoutKind.Sequential)]
        public struct ImageCoreHeader
        {
            /// <summary>
            /// Header versioning
            /// </summary>
            public uint cb;

            public ushort MajorRuntimeVersion;

            public ushort MinorRuntimeVersion;

            /// <summary>
            /// Symbol table and startup information
            /// </summary>
            public DirectoryEntry MetaData;

            public ComImageKind Flags;

            /// <summary>
            /// The main program if it is an EXE (not used if a DLL?)
            /// If COMIMAGE_FLAGS_NATIVE_ENTRYPOINT is not set, EntryPointToken represents a managed entrypoint.
            /// If COMIMAGE_FLAGS_NATIVE_ENTRYPOINT is set, EntryPointRVA represents an RVA to a native entrypoint
            /// (deprecated for DLLs, use modules constructors instead).
            /// </summary>
            public HeaderEntryPoint EntryPoint;

            /// <summary>
            /// This is the blob of managed resources. Fetched using code:AssemblyNative.GetResource and
            /// code:PEFile.GetResource and accessible from managed code from System.Assembly.GetManifestResourceStream.
            /// The meta data has a table that maps names to offsets into this blob, so logically the blob is a set of resources.
            /// </summary>
            public DirectoryEntry Resources;

            /// <summary>
            /// IL assemblies can be signed with a public-private key to validate who created it.
            /// The signature goes here if this feature is used.
            /// </summary>
            public DirectoryEntry StrongNameSignature;

            /// <summary>
            /// Deprecated, not used; Used for manged code that has unmanaged code inside it
            /// (or exports methods as unmanaged entry points)
            /// </summary>
            public DirectoryEntry CodeManagerTable;

            /// <summary>
            /// Used for managed code that has unmanaged code inside of it (or exports methods as unmanaged entry points) .
            /// </summary>
            public DirectoryEntry VTableFixups;

            public DirectoryEntry ExportAddressTableJumps;

            /// <summary>
            /// null for ordinary IL images.  NGEN images it points at a code:CORCOMPILE_HEADER structure
            /// </summary>
            public DirectoryEntry ManagedNativeHeader;

            public uint NativeEntryPoint
                => (Flags & ComImageKind.NATIVE_ENTRYPOINT)
                == ComImageKind.NATIVE_ENTRYPOINT
                ? EntryPoint.RVA : uint.MaxValue;

            public uint ManagedEntryPoint
                => (Flags & ComImageKind.NATIVE_ENTRYPOINT)
                != ComImageKind.NATIVE_ENTRYPOINT
                ? EntryPoint.Token : uint.MaxValue;
        }
    }
}
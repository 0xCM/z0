//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ImageTables
    {
        /// <summary>
        /// A wrapper over IMAGE_OPTIONAL_HEADER.  See https://msdn.microsoft.com/en-us/library/windows/desktop/ms680339(v=vs.85).aspx.
        /// </summary>
        [Table]
        public struct OptionalHeader
        {
            readonly bool _32bit;

            public OptionalHeaderA Agnostic;

            public OptionalHeaderS Specific;

            public DirectoryEntry[] Directories;

            public OptionalHeader(ref OptionalHeaderA optional, OptionalHeaderS specific, DirectoryEntry[] directories, bool is32bit)
            {
                Agnostic = optional;
                Specific = specific;
                _32bit = is32bit;
                Directories = directories;
            }

            public ushort Magic
                => Agnostic.Magic;

            public byte MajorLinkerVersion
                => Agnostic.MajorLinkerVersion;

            public byte MinorLinkerVersion
                => Agnostic.MinorLinkerVersion;

            public uint SizeOfCode
                => Agnostic.SizeOfCode;

            public uint SizeOfInitializedData
                => Agnostic.SizeOfInitializedData;

            public uint SizeOfUninitializedData
                => Agnostic.SizeOfUninitializedData;

            public uint AddressOfEntryPoint
                => Agnostic.AddressOfEntryPoint;

            public uint BaseOfCode
                => Agnostic.BaseOfCode;

            /// <summary>
            /// Only valid in 32bit images.
            /// </summary>
            public uint BaseOfData
                => _32bit
                ? Agnostic.BaseOfData
                : throw new InvalidOperationException();

            public ulong ImageBase
                => _32bit ? Agnostic.ImageBase : Agnostic.ImageBase64;

            public uint SectionAlignment
                => Agnostic.SectionAlignment;

            public uint FileAlignment
                => Agnostic.FileAlignment;

            public ushort MajorOperatingSystemVersion
                => Agnostic.MajorOperatingSystemVersion;

            public ushort MinorOperatingSystemVersion
                => Agnostic.MinorOperatingSystemVersion;

            public ushort MajorImageVersion
                => Agnostic.MajorImageVersion;

            public ushort MinorImageVersion
                => Agnostic.MinorImageVersion;

            public ushort MajorSubsystemVersion
                => Agnostic.MajorSubsystemVersion;

            public ushort MinorSubsystemVersion
                => Agnostic.MinorSubsystemVersion;

            public uint Win32VersionValue
                => Agnostic.Win32VersionValue;

            public uint SizeOfImage
                => Agnostic.SizeOfImage;

            public uint SizeOfHeaders
                => Agnostic.SizeOfHeaders;

            public uint CheckSum
                => Agnostic.CheckSum;

            public ushort Subsystem
                => Agnostic.Subsystem;

            public ushort DllCharacteristics
                => Agnostic.DllCharacteristics;

            public ulong SizeOfStackReserve
                => Specific.SizeOfStackReserve;

            public ulong SizeOfStackCommit
                => Specific.SizeOfStackCommit;

            public ulong SizeOfHeapReserve
                => Specific.SizeOfHeapReserve;

            public ulong SizeOfHeapCommit
                => Specific.SizeOfHeapCommit;

            public uint LoaderFlags
                => Specific.LoaderFlags;

            public uint NumberOfRvaAndSizes
                => Specific.NumberOfRvaAndSizes;

            public ref DirectoryEntry ExportDirectory
                => ref Directories[0];

            public ref DirectoryEntry ImportDirectory
                => ref Directories[1];

            public ref DirectoryEntry ResourceDirectory
                => ref Directories[2];

            public ref DirectoryEntry ExceptionDirectory
                => ref Directories[3];

            public ref DirectoryEntry CertificatesDirectory
                => ref Directories[4];

            public ref DirectoryEntry BaseRelocationDirectory
                => ref Directories[5];

            public ref DirectoryEntry DebugDirectory
                => ref Directories[6];

            public DirectoryEntry ArchitectureDirectory
                => Directories[7];

            public ref DirectoryEntry GlobalPointerDirectory
                => ref Directories[8];

            public ref DirectoryEntry ThreadStorageDirectory
                => ref Directories[9];

            public ref DirectoryEntry LoadConfigurationDirectory
                => ref Directories[10];

            public ref DirectoryEntry BoundImportDirectory
                => ref Directories[11];

            public ref DirectoryEntry ImportAddressTableDirectory
                => ref Directories[12];

            public ref DirectoryEntry DelayImportDirectory
                => ref Directories[13];

            public ref DirectoryEntry ComDescriptorDirectory
                => ref Directories[14];
        }
    }
}
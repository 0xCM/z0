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
        public struct DirectoryEntry
        {
            public Address32 RelativeVirtualAddress;

            public uint Size;
        }

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

        [StructLayout(LayoutKind.Sequential)]
        public struct StorageHeader
        {
            public ushort Flags;

            public short NumberOfStreams;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct StreamHeader
        {
            public uint Offset;

            public int Size;

            public string Name;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SectionHeader
        {
            public string Name;

            public ByteSize VirtualSize;

            public Address32 VirtualAddress;

            public ByteSize SizeOfRawData;

            public Address32 OffsetToRawData;

            public Address32 RVAToRelocations;

            public Address32 PointerToLineNumbers;

            public ushort NumberOfRelocations;

            public ushort NumberOfLineNumbers;

            public SectionCharacteristics SectionCharacteristics;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct OptionalHeaderNTAdditionalFields
        {
            public MemoryAddress ImageBase;

            public int SectionAlignment;

            public uint FileAlignment;

            public ushort MajorOperatingSystemVersion;

            public ushort MinorOperatingSystemVersion;

            public ushort MajorImageVersion;

            public ushort MinorImageVersion;

            public ushort MajorSubsystemVersion;

            public ushort MinorSubsystemVersion;

            public uint Win32VersionValue;

            public int SizeOfImage;

            public int SizeOfHeaders;

            public uint CheckSum;

            public Subsystem Subsystem;

            public DllCharacteristics DllCharacteristics;

            public ulong SizeOfStackReserve;

            public ulong SizeOfStackCommit;

            public ulong SizeOfHeapReserve;

            public ulong SizeOfHeapCommit;

            public uint LoaderFlags;

            public int NumberOfRvaAndSizes;
        }

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

        [StructLayout(LayoutKind.Sequential)]
        public struct COFFFileHeader
        {
            public Machine Machine;
            public short NumberOfSections;
            public int TimeDateStamp;
            public int PointerToSymbolTable;
            public int NumberOfSymbols;
            public short SizeOfOptionalHeader;
            public Characteristics Characteristics;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct PeDebugDirectory
        {
            public uint Characteristics;

            public uint TimeDateStamp;

            public ushort MajorVersion;

            public ushort MinorVersion;

            public uint Type;

            public uint SizeOfData;

            public uint AddressOfRawData;

            public uint PointerToRawData;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct OptionalHeaderStandardFields
        {
            public PEMagic PEMagic;

            public byte MajorLinkerVersion;

            public byte MinorLinkerVersion;

            public int SizeOfCode;

            public int SizeOfInitializedData;

            public int SizeOfUninitializedData;

            public int RVAOfEntryPoint;

            public int BaseOfCode;

            public int BaseOfData;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ResourceDirectory
        {
            public uint Charecteristics;

            public uint TimeDateStamp;

            public short MajorVersion;

            public short MinorVersion;

            public short NumberOfNamedEntries;

            public short NumberOfIdEntries;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ResourceDirectoryEntry
        {
            public int NameOrId;

            public int DataOffset;

            public bool IsDirectory
            {
                get  => (this.DataOffset & 0x80000000) == 0x80000000;
            }

            public int OffsetToDirectory
            {
                get => DataOffset & 0x7FFFFFFF;

            }
            public int OffsetToData
            {
                get => DataOffset & 0x7FFFFFFF;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct ResourceDataEntry
        {
            public int RVAToData;

            public int Size;

            public int CodePage;

            public int Reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SEHTableEntry
        {
            public SEHFlags SEHFlags;

            public uint TryOffset;

            public uint TryLength;

            public uint HandlerOffset;

            public uint HandlerLength;

            public uint ClassTokenOrFilterOffset;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MethodIL
        {
            public bool LocalVariablesInited;

            public ushort MaxStack;

            public uint LocalSignatureToken;

            public MemoryBlock EncodedILMemoryBlock;

            public SEHTableEntry[]  SEHTable;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MetadataTableHeader
        {
            public uint Reserved;

            public byte MajorVersion;

            public byte MinorVersion;

            public HeapSizeFlag HeapSizeFlags;

            public byte RowId;

            public TableMask ValidTables;

            public TableMask SortedTables;

            public int GetNumberOfTablesPresent()
            {
                const ulong MASK_01010101010101010101010101010101 = 0x5555555555555555UL;
                const ulong MASK_00110011001100110011001100110011 = 0x3333333333333333UL;
                const ulong MASK_00001111000011110000111100001111 = 0x0F0F0F0F0F0F0F0FUL;
                const ulong MASK_00000000111111110000000011111111 = 0x00FF00FF00FF00FFUL;
                const ulong MASK_00000000000000001111111111111111 = 0x0000FFFF0000FFFFUL;
                const ulong MASK_11111111111111111111111111111111 = 0x00000000FFFFFFFFUL;
                var count = (ulong)this.ValidTables;
                count = (count & MASK_01010101010101010101010101010101) + ((count >> 1) & MASK_01010101010101010101010101010101);
                count = (count & MASK_00110011001100110011001100110011) + ((count >> 2) & MASK_00110011001100110011001100110011);
                count = (count & MASK_00001111000011110000111100001111) + ((count >> 4) & MASK_00001111000011110000111100001111);
                count = (count & MASK_00000000111111110000000011111111) + ((count >> 8) & MASK_00000000111111110000000011111111);
                count = (count & MASK_00000000000000001111111111111111) + ((count >> 16) & MASK_00000000000000001111111111111111);
                count = (count & MASK_11111111111111111111111111111111) + ((count >> 32) & MASK_11111111111111111111111111111111);
                return (int)count;
            }
        }

        //  0x00
        [StructLayout(LayoutKind.Sequential)]
        public struct ModuleRow
        {
            public readonly ushort Generation;

            public readonly uint Name;

            public readonly uint MVId;

            public readonly uint EnCId;

            public readonly uint EnCBaseId;

        }

        //  0x01
        [StructLayout(LayoutKind.Sequential)]
        public struct TypeRefRow
        {
            public readonly uint ResolutionScope;

            public readonly uint Name;

            public readonly uint Namespace;
        }

        //  0x02
        [StructLayout(LayoutKind.Sequential)]
        public struct TypeDefRow
        {
            public TypeDefFlags Flags;

            public uint Name;

            public uint Namespace;

            public uint Extends;

            public uint FieldList;

            public uint MethodList;

            public bool IsNested
            {
                get  => (this.Flags & TypeDefFlags.NestedMask) != 0;
            }
        }

        //  0x03
        [StructLayout(LayoutKind.Sequential)]
        public struct FieldPtrRow
        {
            public uint Field;

        }

        //  0x04
        [StructLayout(LayoutKind.Sequential)]
        public struct FieldRow
        {
            public FieldFlags Flags;

            public uint Name;

            public uint Signature;

        }

        //  0x05
        [StructLayout(LayoutKind.Sequential)]
        public struct MethodPtrRow
        {
            public uint Method;
        }

        //  0x06
        [StructLayout(LayoutKind.Sequential)]
        public struct MethodRow
        {
            public Address32 RVA;

            public MethodImplFlags ImplFlags;

            public MethodFlags Flags;

            public uint Name;

            public uint Signature;

            public uint ParamList;

        }

        //  0x07
        [StructLayout(LayoutKind.Sequential)]
        public struct ParamPtrRow
        {
            public uint Param;

        }

        //  0x08
        [StructLayout(LayoutKind.Sequential)]
        public struct ParamRow
        {
            public ParamFlags Flags;
            public ushort Sequence;
            public uint Name;

        }

        //  0x09
        [StructLayout(LayoutKind.Sequential)]
        public struct InterfaceImplRow
        {
            public uint Class;

            public uint Interface;
        }

        //  0x0A
        [StructLayout(LayoutKind.Sequential)]
        public struct MemberRefRow
        {
            public uint Class;

            public uint Name;

            public uint Signature;

        }
        //  0x0B
        [StructLayout(LayoutKind.Sequential)]
        public struct ConstantRow
        {
            public byte Type;

            public uint Parent;

            public uint Value;

        }

        //  0x0C
        [StructLayout(LayoutKind.Sequential)]
        public struct CustomAttributeRow
        {
            public uint Parent;

            public uint Type;

            public uint Value;

        }

        //  0x0D
        [StructLayout(LayoutKind.Sequential)]
        public struct FieldMarshalRow
        {
            public uint Parent;


            public uint NativeType;

        }

        //  0x0E
        [StructLayout(LayoutKind.Sequential)]
        public struct DeclSecurityRow
        {
            public DeclSecurityActionFlags ActionFlags;

            public uint Parent;

            public uint PermissionSet;
        }

        //  0x0F
        [StructLayout(LayoutKind.Sequential)]
        public struct ClassLayoutRow
        {
            public ushort PackingSize;

            public uint ClassSize;

            public uint Parent;

        }

        //  0x10
        [StructLayout(LayoutKind.Sequential)]
        public struct FieldLayoutRow
        {
            public uint Offset;

            public uint Field;

        }

        //  0x11
        [StructLayout(LayoutKind.Sequential)]
        public struct StandAloneSigRow
        {
            public uint Signature;
        }

        //  0x12
        [StructLayout(LayoutKind.Sequential)]
        public struct EventMapRow
        {
            public uint Parent;

            public uint EventList;

        }

        //  0x13
        [StructLayout(LayoutKind.Sequential)]
        public struct EventPtrRow
        {
            public uint Event;

        }

        //  0x14
        [StructLayout(LayoutKind.Sequential)]
        public struct EventRow
        {
            public EventFlags Flags;

            public uint Name;

            public uint EventType;
        }

        //  0x15
        [StructLayout(LayoutKind.Sequential)]
        public struct PropertyMapRow
        {
            public uint Parent;

            public uint PropertyList;

        }

    //  0x16
        [StructLayout(LayoutKind.Sequential)]
        public struct PropertyPtrRow
        {
            public uint Property;

        }

        //  0x17
        [StructLayout(LayoutKind.Sequential)]
        public struct PropertyRow
        {
            public PropertyFlags Flags;

            public uint Name;

            public uint Signature;
        }

        //  0x18
        [StructLayout(LayoutKind.Sequential)]
        public struct MethodSemanticsRow
        {
            public MethodSemanticsFlags SemanticsFlag;
            public uint Method;
            public uint Association;

        }

        //  0x19
        [StructLayout(LayoutKind.Sequential)]
        public struct MethodImplRow
        {
            public uint Class;

            public uint MethodBody;

            public uint MethodDeclaration;
        }

        //  0x1A
        [StructLayout(LayoutKind.Sequential)]
        public struct ModuleRefRow
        {
            public uint Name;
        }

        //  0x1B
        [StructLayout(LayoutKind.Sequential)]
        public struct TypeSpecRow
        {
            public uint Signature;
        }

        //  0x1C
        [StructLayout(LayoutKind.Sequential)]
        public struct ImplMapRow
        {
            public PInvokeMapFlags PInvokeMapFlags;

            public uint MemberForwarded;

            public uint ImportName;

            public uint ImportScope;
        }

        //  0x1D
        [StructLayout(LayoutKind.Sequential)]
        public struct FieldRVARow
        {
            public Address32 RVA;

            public uint Field;

        }

        //  0x1E
        [StructLayout(LayoutKind.Sequential)]
        public struct EnCLogRow
        {
            public uint Token;

            public uint FuncCode;

        }

        //  0x1F
        [StructLayout(LayoutKind.Sequential)]
        public struct EnCMapRow
        {
            public uint Token;

        }

        //  0x20
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyRow
        {
            public uint HashAlgId;

            public ushort MajorVersion;

            public ushort MinorVersion;

            public ushort BuildNumber;

            public ushort RevisionNumber;

            public AssemblyFlags Flags;

            public uint PublicKey;


            public uint Name;


            public uint Culture;
        }

        //  0x21
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyProcessorRow
        {
            public uint Processor;
        }

        //  0x22
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyOSRow
        {
            public uint OSPlatformId;

            public uint OSMajorVersionId;

            public uint OSMinorVersionId;

        }

        //  0x23
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyRefRow
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
        public struct AssemblyRefProcessorRow
        {
            public uint Processor;
            public uint AssemblyRef;

        }

        //  0x25
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyRefOSRow
        {
            public uint OSPlatformId;
            public uint OSMajorVersionId;
            public uint OSMinorVersionId;
            public uint AssemblyRef;
        }

        //  0x26
        [StructLayout(LayoutKind.Sequential)]
        public struct FileRow
        {
            public FileFlags Flags;

            public uint Name;

            public uint HashValue;

        }

        //  0x27
        [StructLayout(LayoutKind.Sequential)]
        public struct ExportedTypeRow
        {
            public TypeDefFlags Flags;

            public uint TypeDefId;

            public uint TypeName;

            public uint TypeNamespace;

            public uint Implementation;

            public bool IsNested {
                get {
                return (this.Flags & TypeDefFlags.NestedMask) != 0;
                }
            }
        }

        //  0x28
        [StructLayout(LayoutKind.Sequential)]
        public struct ManifestResourceRow
        {
            public uint Offset;

            public ManifestResourceFlags Flags;

            public uint Name;

            public uint Implementation;
        }

        //  0x29
        [StructLayout(LayoutKind.Sequential)]
        public struct NestedClassRow
        {
            public uint NestedClass;

            public uint EnclosingClass;
        }

        //  0x2A
        [StructLayout(LayoutKind.Sequential)]
        public struct GenericParamRow
        {
            public ushort Number;

            public GenericParamFlags Flags;

            public uint Owner;

            public uint Name;

        }

        //  0x2B
        [StructLayout(LayoutKind.Sequential)]
        public struct MethodSpecRow
        {
            public uint Method;

            public uint Instantiation;
        }

        //  0x2C
        [StructLayout(LayoutKind.Sequential)]
        public struct GenericParamConstraintRow
        {
            public uint Owner;
            public uint Constraint;
        }
    }
}
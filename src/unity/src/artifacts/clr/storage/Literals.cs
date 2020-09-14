//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;

    partial struct ClrStorage
    {
        public readonly struct MetadataStreamConstants
        {
            public const int SizeOfMetadataTableHeader = 24;
            public const uint LargeTableRowCount = 0x00010000;
        }

        public readonly struct COR20Constants
        {
            public const int SizeOfCOR20Header = 72;

            public const uint COR20MetadataSignature = 0x424A5342;

            public const int MinimumSizeofMetadataHeader = 16;

            public const int SizeofStorageHeader = 4;

            public const int MinimumSizeofStreamHeader = 8;

            public const string StringStreamName = "#Strings";

            public const string BlobStreamName = "#Blob";

            public const string GUIDStreamName = "#GUID";

            public const string UserStringStreamName = "#US";

            public const string CompressedMetadataTableStreamName = "#~";

            public const string UncompressedMetadataTableStreamName = "#-";

            public const int LargeStreamHeapSize = 0x0001000;
        }

        public enum CILMethodFlags : byte
        {
            ILTinyFormat = 0x02,

            ILFatFormat = 0x03,

            ILFormatMask = 0x03,

            ILTinyFormatSizeShift = 2,

            ILMoreSects = 0x08,

            ILInitLocals = 0x10,

            ILFatFormatHeaderSize = 0x03,

            ILFatFormatHeaderSizeShift = 4,

            SectEHTable = 0x01,

            SectOptILTable = 0x02,

            SectFatFormat = 0x40,

            SectMoreSects = 0x40,
        }

        public enum SEHFlags : uint
        {
            Catch = 0x0000,

            Filter = 0x0001,

            Finally = 0x0002,

            Fault = 0x0004,
        }

        /// <summary>
        /// Target CPU types.
        /// </summary>
        public enum Machine : ushort
        {
            /// <summary>
            /// The target CPU is unknown or not specified.
            /// </summary>
            Unknown = 0x0000,
            /// <summary>
            /// Intel 386.
            /// </summary>
            I386 = 0x014C,
            /// <summary>
            /// MIPS little-endian
            /// </summary>
            R3000 = 0x0162,
            /// <summary>
            /// MIPS little-endian
            /// </summary>
            R4000 = 0x0166,
            /// <summary>
            /// MIPS little-endian
            /// </summary>
            R10000 = 0x0168,
            /// <summary>
            /// MIPS little-endian WCE v2
            /// </summary>
            WCEMIPSV2 = 0x0169,
            /// <summary>
            /// Alpha_AXP
            /// </summary>
            Alpha = 0x0184,
            /// <summary>
            /// SH3 little-endian
            /// </summary>
            SH3 = 0x01a2,
            /// <summary>
            /// SH3 little-endian. DSP.
            /// </summary>
            SH3DSP = 0x01a3,
            /// <summary>
            /// SH3E little-endian.
            /// </summary>
            SH3E = 0x01a4,
            /// <summary>
            /// SH4 little-endian.
            /// </summary>
            SH4 = 0x01a6,
            /// <summary>
            /// SH5.
            /// </summary>
            SH5 = 0x01a8,
            /// <summary>
            /// ARM Little-Endian
            /// </summary>
            ARM = 0x01c0,
            /// <summary>
            /// Thumb.
            /// </summary>
            Thumb = 0x01c2,
            /// <summary>
            /// ARM Thumb-2 Little-Endian
            /// </summary>
            ARMThumb2 = 0x01c4,
            /// <summary>
            /// AM33
            /// </summary>
            AM33 = 0x01d3,
            /// <summary>
            /// IBM PowerPC Little-Endian
            /// </summary>
            PowerPC = 0x01F0,
            /// <summary>
            /// PowerPCFP
            /// </summary>
            PowerPCFP = 0x01f1,
            /// <summary>
            /// Intel 64
            /// </summary>
            IA64 = 0x0200,
            /// <summary>
            /// MIPS
            /// </summary>
            MIPS16 = 0x0266,
            /// <summary>
            /// ALPHA64
            /// </summary>
            Alpha64 = 0x0284,
            /// <summary>
            /// MIPS
            /// </summary>
            MIPSFPU = 0x0366,
            /// <summary>
            /// MIPS
            /// </summary>
            MIPSFPU16 = 0x0466,
            /// <summary>
            /// AXP64
            /// </summary>
            AXP64 = Alpha64,
            /// <summary>
            /// Infineon
            /// </summary>
            Tricore = 0x0520,
            /// <summary>
            /// CEF
            /// </summary>
            CEF = 0x0CEF,
            /// <summary>
            /// EFI Byte Code
            /// </summary>
            EBC = 0x0EBC,
            /// <summary>
            /// AMD64 (K8)
            /// </summary>
            AMD64 = 0x8664,
            /// <summary>
            /// M32R little-endian
            /// </summary>
            M32R = 0x9041,
            /// <summary>
            /// ARM64 Little-Endian
            /// </summary>
            ARM64 = 0xAA64,
            /// <summary>
            /// CEE
            /// </summary>
            CEE = 0xC0EE,
        }

        public static class PEFileConstants
        {
            public const ushort DosSignature = 0x5A4D; // MZ

            public const int PESignatureOffsetLocation = 0x3C;

            public const uint PESignature = 0x00004550; // PE00

            public const int BasicPEHeaderSize = PEFileConstants.PESignatureOffsetLocation;

            public const int SizeofCOFFFileHeader = 20;
            public const int SizeofOptionalHeaderStandardFields32 = 28;
            public const int SizeofOptionalHeaderStandardFields64 = 24;
            public const int SizeofOptionalHeaderNTAdditionalFields32 = 68;
            public const int SizeofOptionalHeaderNTAdditionalFields64 = 88;
            public const int NumberofOptionalHeaderDirectoryEntries = 16;
            public const int SizeofOptionalHeaderDirectoriesEntries = 16 * 8;
            public const int SizeofSectionHeader = 40;
            public const int SizeofSectionName = 8;
            public const int SizeofResourceDirectory = 16;
            public const int SizeofResourceDirectoryEntry = 8;
        }

        public enum COR20Flags : uint
        {
            ILOnly = 0x00000001,
            Bit32Required = 0x00000002,
            ILLibrary = 0x00000004,
            StrongNameSigned = 0x00000008,
            NativeEntryPoint = 0x00000010,
            TrackDebugData = 0x00010000,
            Prefers32bits = 0x00020000,
        }

        public enum Characteristics : ushort
        {
            RelocsStripped = 0x0001, // Relocation info stripped from file.

            ExecutableImage = 0x0002, // File is executable  (i.e. no unresolved external references).

            LineNumsStripped = 0x0004, // Line numbers stripped from file.

            LocalSymsStripped = 0x0008, // Local symbols stripped from file.

            AggressiveWsTrim = 0x0010, // Agressively trim working set

            LargeAddressAware = 0x0020, // App can handle >2gb addresses

            BytesReversedLo = 0x0080, // Bytes of machine word are reversed.

            Bit32Machine = 0x0100, // 32 bit word machine.

            DebugStripped = 0x0200, // Debugging info stripped from file in .DBG file

            RemovableRunFromSwap = 0x0400, // If Image is on removable media, copy and run from the swap file.

            NetRunFromSwap = 0x0800, // If Image is on Net, copy and run from the swap file.

            System = 0x1000, // System File.

            Dll = 0x2000, // File is a DLL.

            UpSystemOnly = 0x4000, // File should only be run on a UP machine

            BytesReversedHi = 0x8000, // Bytes of machine word are reversed.
        }

        public enum PEMagic : ushort
        {
            PEMagic32 = 0x010B,
            PEMagic64 = 0x020B,
        }

        public enum Directories : ushort
        {
            Export,

            Import,

            Resource,

            Exception,

            Certificate,

            BaseRelocation,

            Debug,

            Copyright,

            GlobalPointer,

            ThreadLocalStorage,

            LoadConfig,

            BoundImport,

            ImportAddress,

            DelayImport,

            COR20Header,

            Reserved,

            Cor20HeaderMetaData,

            Cor20HeaderResources,

            Cor20HeaderStrongNameSignature,

            Cor20HeaderCodeManagerTable,

            Cor20HeaderVtableFixups,

            Cor20HeaderExportAddressTableJumps,

            Cor20HeaderManagedNativeHeader,
        }

        public enum Subsystem : ushort
        {
            Unknown = 0, // Unknown subsystem.
            Native = 1, // Image doesn't require a subsystem.
            WindowsGUI = 2, // Image runs in the Windows GUI subsystem.
            WindowsCUI = 3, // Image runs in the Windows character subsystem.
            OS2CUI = 5, // image runs in the OS/2 character subsystem.
            POSIXCUI = 7, // image runs in the Posix character subsystem.
            NativeWindows = 8, // image is a native Win9x driver.
            WindowsCEGUI = 9, // Image runs in the Windows CE subsystem.
            EFIApplication = 10,
            EFIBootServiceDriver = 11,
            EFIRuntimeDriver = 12,
            EFIROM = 13,
            XBOX = 14,
        }

        public enum DllCharacteristics : ushort
        {
            ProcessInit = 0x0001, // Reserved.
            ProcessTerm = 0x0002, // Reserved.
            ThreadInit = 0x0004, // Reserved.
            ThreadTerm = 0x0008, // Reserved.
            DynamicBase = 0x0040, //
            NxCompatible = 0x0100, //
            NoIsolation = 0x0200, // Image understands isolation and doesn't want it
            NoSEH = 0x0400, // Image does not use SEH.  No SE handler may reside in this image
            NoBind = 0x0800, // Do not bind this image.
            AppContainer = 0x1000, // The image must run inside an AppContainer
            WDM_Driver = 0x2000, // Driver uses WDM model
            //                      0x4000     // Reserved.
            TerminalServerAware = 0x8000,
        }

        public enum SectionCharacteristics : uint
        {
            TypeReg = 0x00000000, // Reserved.

            TypeDSect = 0x00000001, // Reserved.

            TypeNoLoad = 0x00000002, // Reserved.

            TypeGroup = 0x00000004, // Reserved.

            TypeNoPad = 0x00000008, // Reserved.

            TypeCopy = 0x00000010, // Reserved.

            CNTCode = 0x00000020, // Section contains code.

            CNTInitializedData = 0x00000040, // Section contains initialized data.

            CNTUninitializedData = 0x00000080, // Section contains uninitialized data.

            LNKOther = 0x00000100, // Reserved.

            LNKInfo = 0x00000200, // Section contains comments or some other type of information.

            TypeOver = 0x00000400, // Reserved.

            LNKRemove = 0x00000800, // Section contents will not become part of image.

            LNKCOMDAT = 0x00001000, // Section contents comdat.
            //                                0x00002000  // Reserved.

            MemProtected = 0x00004000,

            No_Defer_Spec_Exc = 0x00004000, // Reset speculative exceptions handling bits in the TLB entries for this section.

            GPRel = 0x00008000, // Section content can be accessed relative to GP

            MemFardata = 0x00008000,

            MemSysheap = 0x00010000,

            MemPurgeable = 0x00020000,

            Mem16Bit = 0x00020000,

            MemLocked = 0x00040000,

            MemPreload = 0x00080000,

            Align1Bytes = 0x00100000, //
            Align2Bytes = 0x00200000, //
            Align4Bytes = 0x00300000, //
            Align8Bytes = 0x00400000, //
            Align16Bytes = 0x00500000, // Default alignment if no others are specified.
            Align32Bytes = 0x00600000, //
            Align64Bytes = 0x00700000, //
            Align128Bytes = 0x00800000, //
            Align256Bytes = 0x00900000, //
            Align512Bytes = 0x00A00000, //
            Align1024Bytes = 0x00B00000, //
            Align2048Bytes = 0x00C00000, //
            Align4096Bytes = 0x00D00000, //
            Align8192Bytes = 0x00E00000, //
            // Unused                     0x00F00000
            AlignMask = 0x00F00000,

            LNKNRelocOvfl = 0x01000000, // Section contains extended relocations.
            MemDiscardable = 0x02000000, // Section can be discarded.
            MemNotCached = 0x04000000, // Section is not cachable.
            MemNotPaged = 0x08000000, // Section is not pageable.
            MemShared = 0x10000000, // Section is shareable.
            MemExecute = 0x20000000, // Section is executable.
            MemRead = 0x40000000, // Section is readable.
            MemWrite = 0x80000000, // Section is writeable.
        }

        public enum MetadataStreamKind
        {
            Illegal,
            Compressed,
            UnCompressed,
        }

        public enum TableIndices : byte
        {
            Module = 0x00,

            TypeRef = 0x01,

            TypeDef = 0x02,

            FieldPtr = 0x03,

            Field = 0x04,

            MethodPtr = 0x05,

            Method = 0x06,

            ParamPtr = 0x07,

            Param = 0x08,

            InterfaceImpl = 0x09,

            MemberRef = 0x0A,

            Constant = 0x0B,

            CustomAttribute = 0x0C,

            FieldMarshal = 0x0D,

            DeclSecurity = 0x0E,

            ClassLayout = 0x0F,

            FieldLayout = 0x10,

            StandAloneSig = 0x11,

            EventMap = 0x12,

            EventPtr = 0x13,

            Event = 0x14,

            PropertyMap = 0x15,

            PropertyPtr = 0x16,

            Property = 0x17,

            MethodSemantics = 0x18,

            MethodImpl = 0x19,

            ModuleRef = 0x1A,

            TypeSpec = 0x1B,

            ImplMap = 0x1C,

            FieldRva = 0x1D,

            EnCLog = 0x1E,

            EnCMap = 0x1F,

            Assembly = 0x20,

            AssemblyProcessor = 0x21,

            AssemblyOS = 0x22,

            AssemblyRef = 0x23,

            AssemblyRefProcessor = 0x24,

            AssemblyRefOS = 0x25,

            File = 0x26,

            ExportedType = 0x27,

            ManifestResource = 0x28,

            NestedClass = 0x29,

            GenericParam = 0x2A,

            MethodSpec = 0x2B,

            GenericParamConstraint = 0x2C,

            Count,
        }

        public enum TableMask : ulong
        {
            Module = 0x0000000000000001UL << 0x00,

            TypeRef = 0x0000000000000001UL << 0x01,

            TypeDef = 0x0000000000000001UL << 0x02,

            FieldPtr = 0x0000000000000001UL << 0x03,

            Field = 0x0000000000000001UL << 0x04,

            MethodPtr = 0x0000000000000001UL << 0x05,

            Method = 0x0000000000000001UL << 0x06,

            ParamPtr = 0x0000000000000001UL << 0x07,

            Param = 0x0000000000000001UL << 0x08,

            InterfaceImpl = 0x0000000000000001UL << 0x09,

            MemberRef = 0x0000000000000001UL << 0x0A,

            Constant = 0x0000000000000001UL << 0x0B,

            CustomAttribute = 0x0000000000000001UL << 0x0C,

            FieldMarshal = 0x0000000000000001UL << 0x0D,

            DeclSecurity = 0x0000000000000001UL << 0x0E,

            ClassLayout = 0x0000000000000001UL << 0x0F,

            FieldLayout = 0x0000000000000001UL << 0x10,

            StandAloneSig = 0x0000000000000001UL << 0x11,

            EventMap = 0x0000000000000001UL << 0x12,

            EventPtr = 0x0000000000000001UL << 0x13,

            Event = 0x0000000000000001UL << 0x14,

            PropertyMap = 0x0000000000000001UL << 0x15,

            PropertyPtr = 0x0000000000000001UL << 0x16,

            Property = 0x0000000000000001UL << 0x17,

            MethodSemantics = 0x0000000000000001UL << 0x18,

            MethodImpl = 0x0000000000000001UL << 0x19,

            ModuleRef = 0x0000000000000001UL << 0x1A,

            TypeSpec = 0x0000000000000001UL << 0x1B,

            ImplMap = 0x0000000000000001UL << 0x1C,

            FieldRva = 0x0000000000000001UL << 0x1D,

            EnCLog = 0x0000000000000001UL << 0x1E,

            EnCMap = 0x0000000000000001UL << 0x1F,

            Assembly = 0x0000000000000001UL << 0x20,

            AssemblyProcessor = 0x0000000000000001UL << 0x21,

            AssemblyOS = 0x0000000000000001UL << 0x22,

            AssemblyRef = 0x0000000000000001UL << 0x23,

            AssemblyRefProcessor = 0x0000000000000001UL << 0x24,

            AssemblyRefOS = 0x0000000000000001UL << 0x25,

            File = 0x0000000000000001UL << 0x26,

            ExportedType = 0x0000000000000001UL << 0x27,

            ManifestResource = 0x0000000000000001UL << 0x28,

            NestedClass = 0x0000000000000001UL << 0x29,

            GenericParam = 0x0000000000000001UL << 0x2A,

            MethodSpec = 0x0000000000000001UL << 0x2B,

            GenericParamConstraint = 0x0000000000000001UL << 0x2C,

            SortedTablesMask = TableMask.ClassLayout |
                TableMask.Constant |
                TableMask.CustomAttribute |
                TableMask.DeclSecurity |
                TableMask.FieldLayout |
                TableMask.FieldMarshal |
                TableMask.FieldRva |
                TableMask.GenericParam |
                TableMask.GenericParamConstraint |
                TableMask.ImplMap |
                TableMask.InterfaceImpl |
                TableMask.MethodImpl |
                TableMask.MethodSemantics |
                TableMask.NestedClass,

            CompressedStreamNotAllowedMask = TableMask.FieldPtr |
                TableMask.MethodPtr |
                TableMask.ParamPtr |
                TableMask.EventPtr |
                TableMask.PropertyPtr |
                TableMask.EnCLog |
                TableMask.EnCMap,

            V1_0_TablesMask = TableMask.Module |
                TableMask.TypeRef |
                TableMask.TypeDef |
                TableMask.FieldPtr |
                TableMask.Field |
                TableMask.MethodPtr |
                TableMask.Method |
                TableMask.ParamPtr |
                TableMask.Param |
                TableMask.InterfaceImpl |
                TableMask.MemberRef |
                TableMask.Constant |
                TableMask.CustomAttribute |
                TableMask.FieldMarshal |
                TableMask.DeclSecurity |
                TableMask.ClassLayout |
                TableMask.FieldLayout |
                TableMask.StandAloneSig |
                TableMask.EventMap |
                TableMask.EventPtr |
                TableMask.Event |
                TableMask.PropertyMap |
                TableMask.PropertyPtr |
                TableMask.Property |
                TableMask.MethodSemantics |
                TableMask.MethodImpl |
                TableMask.ModuleRef |
                TableMask.TypeSpec |
                TableMask.ImplMap |
                TableMask.FieldRva |
                TableMask.EnCLog |
                TableMask.EnCMap |
                TableMask.Assembly |
                TableMask.AssemblyRef |
                TableMask.File |
                TableMask.ExportedType |
                TableMask.ManifestResource |
                TableMask.NestedClass,
            V1_1_TablesMask = TableMask.Module |
                TableMask.TypeRef |
                TableMask.TypeDef |
                TableMask.FieldPtr |
                TableMask.Field |
                TableMask.MethodPtr |
                TableMask.Method |
                TableMask.ParamPtr |
                TableMask.Param |
                TableMask.InterfaceImpl |
                TableMask.MemberRef |
                TableMask.Constant |
                TableMask.CustomAttribute |
                TableMask.FieldMarshal |
                TableMask.DeclSecurity |
                TableMask.ClassLayout |
                TableMask.FieldLayout |
                TableMask.StandAloneSig |
                TableMask.EventMap |
                TableMask.EventPtr |
                TableMask.Event |
                TableMask.PropertyMap |
                TableMask.PropertyPtr |
                TableMask.Property |
                TableMask.MethodSemantics |
                TableMask.MethodImpl |
                TableMask.ModuleRef |
                TableMask.TypeSpec |
                TableMask.ImplMap |
                TableMask.FieldRva |
                TableMask.EnCLog |
                TableMask.EnCMap |
                TableMask.Assembly |
                TableMask.AssemblyRef |
                TableMask.File |
                TableMask.ExportedType |
                TableMask.ManifestResource |
                TableMask.NestedClass,

            V2_0_TablesMask = TableMask.Module |
                TableMask.TypeRef |
                TableMask.TypeDef |
                TableMask.FieldPtr |
                TableMask.Field |
                TableMask.MethodPtr |
                TableMask.Method |
                TableMask.ParamPtr |
                TableMask.Param |
                TableMask.InterfaceImpl |
                TableMask.MemberRef |
                TableMask.Constant |
                TableMask.CustomAttribute |
                TableMask.FieldMarshal |
                TableMask.DeclSecurity |
                TableMask.ClassLayout |
                TableMask.FieldLayout |
                TableMask.StandAloneSig |
                TableMask.EventMap |
                TableMask.EventPtr |
                TableMask.Event |
                TableMask.PropertyMap |
                TableMask.PropertyPtr |
                TableMask.Property |
                TableMask.MethodSemantics |
                TableMask.MethodImpl |
                TableMask.ModuleRef |
                TableMask.TypeSpec |
                TableMask.ImplMap |
                TableMask.FieldRva |
                TableMask.EnCLog |
                TableMask.EnCMap |
                TableMask.Assembly |
                TableMask.AssemblyRef |
                TableMask.File |
                TableMask.ExportedType |
                TableMask.ManifestResource |
                TableMask.NestedClass |
                TableMask.GenericParam |
                TableMask.MethodSpec |
                TableMask.GenericParamConstraint,
        }

        public enum HeapSizeFlag : byte
        {
            StringHeapLarge = 0x01, //  4 byte uint indexes used for string heap offsets
            GUIDHeapLarge = 0x02, //  4 byte uint indexes used for GUID heap offsets
            BlobHeapLarge = 0x04, //  4 byte uint indexes used for Blob heap offsets
            EnCDeltas = 0x20, //  Indicates only EnC Deltas are present
            DeletedMarks = 0x80, //  Indicates metadata might contain items marked deleted
        }


        public enum AssemblyHashAlgorithmFlags : uint
        {
            None = 0x00000000,
            MD5 = 0x00008003,
            SHA1 = 0x00008004
        }


        public enum FieldFlags : ushort
        {
            CompilerControlledAccess = 0x0000,

            PrivateAccess = 0x0001,

            FamilyAndAssemblyAccess = 0x0002,

            AssemblyAccess = 0x0003,

            FamilyAccess = 0x0004,

            FamilyOrAssemblyAccess = 0x0005,

            PublicAccess = 0x0006,

            AccessMask = 0x0007,

            StaticContract = 0x0010,

            InitOnlyContract = 0x0020,

            LiteralContract = 0x0040,

            NotSerializedContract = 0x0080,

            SpecialNameImpl = 0x0200,

            PInvokeImpl = 0x2000,

            RTSpecialNameReserved = 0x0400,

            HasFieldMarshalReserved = 0x1000,

            HasDefaultReserved = 0x8000,

            HasFieldRVAReserved = 0x0100,

            //  Load flags
            FieldLoaded = 0x4000,
        }

        public enum MethodFlags : ushort
        {
            CompilerControlledAccess = 0x0000,

            PrivateAccess = 0x0001,

            FamilyAndAssemblyAccess = 0x0002,

            AssemblyAccess = 0x0003,

            FamilyAccess = 0x0004,

            FamilyOrAssemblyAccess = 0x0005,

            PublicAccess = 0x0006,

            AccessMask = 0x0007,

            StaticContract = 0x0010,

            FinalContract = 0x0020,

            VirtualContract = 0x0040,

            HideBySignatureContract = 0x0080,

            ReuseSlotVTable = 0x0000,

            NewSlotVTable = 0x0100,

            CheckAccessOnOverrideImpl = 0x0200,

            AbstractImpl = 0x0400,

            SpecialNameImpl = 0x0800,

            PInvokeInterop = 0x2000,

            UnmanagedExportInterop = 0x0008,

            RTSpecialNameReserved = 0x1000,

            HasSecurityReserved = 0x4000,

            RequiresSecurityObjectReserved = 0x8000,
        }

        public enum ParamFlags : ushort
        {
            InSemantics = 0x0001,

            OutSemantics = 0x0002,

            OptionalSemantics = 0x0010,

            HasDefaultReserved = 0x1000,

            HasFieldMarshalReserved = 0x2000,

            //  Comes from signature...
            ByReference = 0x0100,

            ParamArray = 0x0200,
        }

        public enum PropertyFlags : ushort
        {
            SpecialNameImpl = 0x0200,

            RTSpecialNameReserved = 0x0400,

            HasDefaultReserved = 0x1000,

            //  Comes from signature...
            HasThis = 0x0001,

            ReturnValueIsByReference = 0x0002,
            //  Load flags

            GetterLoaded = 0x0004,

            SetterLoaded = 0x0008,
        }

        public enum EventFlags : ushort
        {
            SpecialNameImpl = 0x0200,

            RTSpecialNameReserved = 0x0400,

            //  Load flags
            AdderLoaded = 0x0001,

            RemoverLoaded = 0x0002,

            FireLoaded = 0x0004,
        }

        public enum MethodSemanticsFlags : ushort
        {
            Setter = 0x0001,
            Getter = 0x0002,
            Other = 0x0004,
            AddOn = 0x0008,
            RemoveOn = 0x0010,
            Fire = 0x0020,
        }

        public enum DeclSecurityActionFlags : ushort
        {
            ActionNil = 0x0000,

            Request = 0x0001,

            Demand = 0x0002,

            Assert = 0x0003,

            Deny = 0x0004,

            PermitOnly = 0x0005,

            LinktimeCheck = 0x0006,

            InheritanceCheck = 0x0007,

            RequestMinimum = 0x0008,

            RequestOptional = 0x0009,

            RequestRefuse = 0x000A,

            PrejitGrant = 0x000B,

            PrejitDenied = 0x000C,

            NonCasDemand = 0x000D,

            NonCasLinkDemand = 0x000E,

            NonCasInheritance = 0x000F,

            MaximumValue = 0x000F,

            ActionMask = 0x001F,
        }

        public enum MethodImplFlags : ushort
        {
            ILCodeType = 0x0000,
            NativeCodeType = 0x0001,
            OPTILCodeType = 0x0002,
            RuntimeCodeType = 0x0003,
            CodeTypeMask = 0x0003,

            Unmanaged = 0x0004,
            NoInlining = 0x0008,
            ForwardRefInterop = 0x0010,
            Synchronized = 0x0020,
            NoOptimization = 0x0040,
            PreserveSigInterop = 0x0080,
            AggressiveInlining = 0x0100,
            InternalCall = 0x1000,

        }

        public enum PInvokeMapFlags : ushort
        {
            NoMangle = 0x0001,

            DisabledBestFit = 0x0020,
            EnabledBestFit = 0x0010,
            UseAssemblyBestFit = 0x0000,
            BestFitMask = 0x0030,

            CharSetNotSpec = 0x0000,
            CharSetAnsi = 0x0002,
            CharSetUnicode = 0x0004,
            CharSetAuto = 0x0006,
            CharSetMask = 0x0006,

            EnabledThrowOnUnmappableChar = 0x1000,
            DisabledThrowOnUnmappableChar = 0x2000,
            UseAssemblyThrowOnUnmappableChar = 0x0000,
            ThrowOnUnmappableCharMask = 0x3000,

            SupportsLastError = 0x0040,

            WinAPICallingConvention = 0x0100,
            CDeclCallingConvention = 0x0200,
            StdCallCallingConvention = 0x0300,
            ThisCallCallingConvention = 0x0400,
            FastCallCallingConvention = 0x0500,
            CallingConventionMask = 0x0700,
        }

        public enum AssemblyFlags : uint
        {
            PublicKey = 0x00000001,
            Retargetable = 0x00000100,
            ContainsForeignTypes = 0x00000200
        }

        public enum ManifestResourceFlags : uint
        {
            PublicVisibility = 0x00000001,
            PrivateVisibility = 0x00000002,
            VisibilityMask = 0x00000007,

            InExternalFile = 0x00000010,
        }

        public enum FileFlags : uint
        {
            ContainsMetadata = 0x00000000,
            ContainsNoMetadata = 0x00000001,
        }

        public enum GenericParamFlags : ushort
        {
            NonVariant = 0x0000,
            Covariant = 0x0001,
            Contravariant = 0x0002,
            VarianceMask = 0x0003,

            ReferenceTypeConstraint = 0x0004,
            ValueTypeConstraint = 0x0008,
            DefaultConstructorConstraint = 0x0010,
        }


        public enum SerializationType : byte
        {
            CustomAttributeStart = 0x01,

            SecurityAttribute20Start = 0x2E,

            Undefined = 0x00,

            Boolean = ElementType.Boolean,

            Char = ElementType.Char,

            Int8 = ElementType.Int8,

            UInt8 = ElementType.UInt8,

            Int16 = ElementType.Int16,

            UInt16 = ElementType.UInt16,

            Int32 = ElementType.Int32,

            UInt32 = ElementType.UInt32,

            Int64 = ElementType.Int64,

            UInt64 = ElementType.UInt64,

            Single = ElementType.Single,

            Double = ElementType.Double,

            String = ElementType.String,

            SZArray = ElementType.SzArray,

            Type = 0x50,

            TaggedObject = 0x51,

            Field = 0x53,

            Property = 0x54,

            Enum = 0x55,
        }

        public enum SigHeaderCode : byte
        {
            DefaultCall = 0x00,

            CCall = 0x01,

            StdCall = 0x02,

            ThisCall = 0x03,

            FastCall = 0x04,

            VarArgCall = 0x05,

            Field = 0x06,

            LocalVar = 0x07,

            Property = 0x08,

            GenericInstance = 0x0A,

            Max = 0x0C,

            CallingConventionMask = 0x0F,

            HasThis = 0x20,

            ExplicitThis = 0x40,

            Generic = 0x10,

            SignatureHeaderMask = 0x7F,
        }
    }
}
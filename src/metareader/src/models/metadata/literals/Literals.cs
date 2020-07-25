//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Immutable;

    public readonly partial struct MdR
    {        
        [Flags]
        public enum LocalVariableAttributes
        {
            None = 0,
            DebuggerHidden = 1,
        }
        
        public enum CustomAttributeNamedArgumentKind : byte
        {
            Field = 0x53,
            Property = 0x54,
        }
        
        internal static class MetadataStreamConstants
        {
            internal const int SizeOfMetadataTableHeader = 24;

            internal const uint LargeTableRowCount = 0x00010000;
        }        

        /// <summary>
        /// Type codes used to encode types of primitive values in Custom Attribute value blob.
        /// </summary>
        public enum PrimitiveSerializationTypeCode : byte
        {
            Boolean = SignatureTypeCode.Boolean,

            Byte = SignatureTypeCode.Byte,

            SByte = SignatureTypeCode.SByte,

            Char = SignatureTypeCode.Char,

            Int16 = SignatureTypeCode.Int16,

            UInt16 = SignatureTypeCode.UInt16,

            Int32 = SignatureTypeCode.Int32,

            UInt32 = SignatureTypeCode.UInt32,

            Int64 = SignatureTypeCode.Int64,

            UInt64 = SignatureTypeCode.UInt64,

            Single = SignatureTypeCode.Single,

            Double = SignatureTypeCode.Double,

            String = SignatureTypeCode.String,
        }

        [Flags]
        public enum AssemblyFlags
        {
            PublicKey = 1,

            Retargetable = 256,

            WindowsRuntime = 512,

            ContentTypeMask = 3584,

            DisableJitCompileOptimizer = 16384,

            EnableJitCompileTracking = 32768,
        }

        public enum AssemblyHashAlgorithm
        {
            None = 0,
            MD5 = 32771,
            Sha1 = 32772,
            Sha256 = 32780,
            Sha384 = 32781,
            Sha512 = 32782,
        }

        public enum DeclarativeSecurityAction : short
        {
            None = (short)0,
            Demand = (short)2,
            Assert = (short)3,
            Deny = (short)4,
            PermitOnly = (short)5,
            LinkDemand = (short)6,
            InheritanceDemand = (short)7,
            RequestMinimum = (short)8,
            RequestOptional = (short)9,
            RequestRefuse = (short)10,
        }
        
        [Flags]
        public enum ManifestResourceAttributes
        {
            Public = 1,
            Private = 2,
            VisibilityMask = 7,
        }
        
        [Flags]
        public enum MethodImportAttributes : short
        {
            None = (short)0,
            ExactSpelling = (short)1,
            CharSetAnsi = (short)2,
            CharSetUnicode = (short)4,
            CharSetAuto = (short)6,
            CharSetMask = (short)6,
            BestFitMappingEnable = (short)16,
            BestFitMappingDisable = (short)32,
            BestFitMappingMask = (short)48,
            SetLastError = (short)64,
            CallingConventionWinApi = (short)256,
            CallingConventionCDecl = (short)512,
            CallingConventionStdCall = (short)768,
            CallingConventionThisCall = (short)1024,
            CallingConventionFastCall = (short)1280,
            CallingConventionMask = (short)1792,
            ThrowOnUnmappableCharEnable = (short)4096,
            ThrowOnUnmappableCharDisable = (short)8192,
            ThrowOnUnmappableCharMask = (short)12288,
        }

        [Flags]
        public enum MethodSemanticsAttributes
        {
            Setter = 1,
            Getter = 2,
            Other = 4,
            Adder = 8,
            Remover = 16,
            Raiser = 32,
        }
        
        public enum HandleKind : byte
        {
            ModuleDefinition = (byte)0,

            TypeReference = (byte)1,

            TypeDefinition = (byte)2,

            FieldDefinition = (byte)4,

            MethodDefinition = (byte)6,

            Parameter = (byte)8,

            InterfaceImplementation = (byte)9,
            
            MemberReference = (byte)10,
            
            Constant = (byte)11,
            
            CustomAttribute = (byte)12,
            
            DeclarativeSecurityAttribute = (byte)14,
            
            StandaloneSignature = (byte)17,
            
            EventDefinition = (byte)20,
            
            PropertyDefinition = (byte)23,
            
            MethodImplementation = (byte)25,
            
            ModuleReference = (byte)26,
            
            TypeSpecification = (byte)27,
            
            AssemblyDefinition = (byte)32,
            
            AssemblyReference = (byte)35,

            AssemblyFile = (byte)38,

            ExportedType = (byte)39,

            ManifestResource = (byte)40,

            GenericParameter = (byte)42,

            MethodSpecification = (byte)43,

            GenericParameterConstraint = (byte)44,

            Document = (byte)48,

            MethodDebugInformation = (byte)49,

            LocalScope = (byte)50,

            LocalVariable = (byte)51,

            LocalConstant = (byte)52,

            ImportScope = (byte)53,

            CustomDebugInformation = (byte)55,

            UserString = (byte)112,

            Blob = (byte)113,

            Guid = (byte)114,

            String = (byte)120,

            NamespaceDefinition = (byte)124,
        }

        public enum ImportDefinitionKind
        {
            ImportNamespace = 1,

            ImportAssemblyNamespace = 2,

            ImportType = 3,

            ImportXmlNamespace = 4,

            ImportAssemblyReferenceAlias = 5,

            AliasAssemblyReference = 6,

            AliasNamespace = 7,

            AliasAssemblyNamespace = 8,

            AliasType = 9,
        }


        /// <summary>
        /// Represents a primitive type found in metadata signatures.
        /// </summary>
        public enum PrimitiveTypeCode : byte
        {
            Boolean = SignatureTypeCode.Boolean,
            Byte = SignatureTypeCode.Byte,
            SByte = SignatureTypeCode.SByte,
            Char = SignatureTypeCode.Char,
            Int16 = SignatureTypeCode.Int16,
            UInt16 = SignatureTypeCode.UInt16,
            Int32 = SignatureTypeCode.Int32,
            UInt32 = SignatureTypeCode.UInt32,
            Int64 = SignatureTypeCode.Int64,
            UInt64 = SignatureTypeCode.UInt64,
            Single = SignatureTypeCode.Single,
            Double = SignatureTypeCode.Double,
            IntPtr = SignatureTypeCode.IntPtr,
            UIntPtr = SignatureTypeCode.UIntPtr,
        
            Object = SignatureTypeCode.Object,
        
            String = SignatureTypeCode.String,
        
            TypedReference = SignatureTypeCode.TypedReference,
        
            Void = SignatureTypeCode.Void,
        }

        /// <summary>
        /// Type codes used to encode types of values in Custom Attribute value blob.
        /// </summary>
        public enum SerializationTypeCode : byte
        {
            /// <summary>
            /// Equivalent to <see cref="SignatureTypeCode.Invalid"/>.
            /// </summary>
            Invalid = SignatureTypeCode.Invalid,

            /// <summary>
            /// Equivalent to <see cref="SignatureTypeCode.Boolean"/>.
            /// </summary>
            Boolean = SignatureTypeCode.Boolean,

            /// <summary>
            /// Equivalent to <see cref="SignatureTypeCode.Char"/>.
            /// </summary>
            Char = SignatureTypeCode.Char,

            /// <summary>
            /// Equivalent to <see cref="SignatureTypeCode.SByte"/>.
            /// </summary>
            SByte = SignatureTypeCode.SByte,

            /// <summary>
            /// Equivalent to <see cref="SignatureTypeCode.Byte"/>.
            /// </summary>
            Byte = SignatureTypeCode.Byte,

            /// <summary>
            /// Equivalent to <see cref="SignatureTypeCode.Int16"/>.
            /// </summary>
            Int16 = SignatureTypeCode.Int16,

            /// <summary>
            /// Equivalent to <see cref="SignatureTypeCode.UInt16"/>.
            /// </summary>
            UInt16 = SignatureTypeCode.UInt16,

            /// <summary>
            /// Equivalent to <see cref="SignatureTypeCode.Int32"/>.
            /// </summary>
            Int32 = SignatureTypeCode.Int32,

            /// <summary>
            /// Equivalent to <see cref="SignatureTypeCode.UInt32"/>.
            /// </summary>
            UInt32 = SignatureTypeCode.UInt32,

            /// <summary>
            /// Equivalent to <see cref="SignatureTypeCode.Int64"/>.
            /// </summary>
            Int64 = SignatureTypeCode.Int64,

            /// <summary>
            /// Equivalent to <see cref="SignatureTypeCode.UInt64"/>.
            /// </summary>
            UInt64 = SignatureTypeCode.UInt64,

            /// <summary>
            /// Equivalent to <see cref="SignatureTypeCode.Single"/>.
            /// </summary>
            Single = SignatureTypeCode.Single,

            /// <summary>
            /// Equivalent to <see cref="SignatureTypeCode.Double"/>.
            /// </summary>
            Double = SignatureTypeCode.Double,

            /// <summary>
            /// Equivalent to <see cref="SignatureTypeCode.String"/>.
            /// </summary>
            String = SignatureTypeCode.String,

            /// <summary>
            /// Equivalent to <see cref="SignatureTypeCode.SZArray"/>.
            /// </summary>
            SZArray = SignatureTypeCode.SZArray,

            /// <summary>
            /// The attribute argument is a System.Type instance.
            /// </summary>
            Type = 0x50,

            /// <summary>
            /// The attribute argument is "boxed" (passed to a parameter, field, or property of type object) and carries type information in the attribute blob.
            /// </summary>
            TaggedObject = 0x51,

            /// <summary>
            /// The attribute argument is an Enum instance.
            /// </summary>
            Enum = 0x55,
        }        
        
        
        /// <summary>
        /// Specifies how arguments in a given signature are passed from the caller to the callee.
        /// Underlying values correspond to the representation in the leading signature byte
        /// represented by <see cref="SignatureHeader"/>.
        /// </summary>
        public enum SignatureCallingConvention : byte
        {
            /// <summary>
            /// Managed calling convention with fixed-length argument list.
            /// </summary>
            Default = 0x0,

            /// <summary>
            /// Unmanaged C/C++-style calling convention where the call stack is cleaned by the caller.
            /// </summary>
            CDecl = 0x1,

            /// <summary>
            /// Unmanaged calling convention where call stack is cleaned up by the callee.
            /// </summary>
            StdCall = 0x2,

            /// <summary>
            /// Unmanaged C++-style calling convention for calling instance member functions with a fixed argument list.
            /// </summary>
            ThisCall = 0x3,

            /// <summary>
            /// Unmanaged calling convention where arguments are passed in registers when possible.
            /// </summary>
            FastCall = 0x4,

            /// <summary>
            /// Managed calling convention for passing extra arguments.
            /// </summary>
            VarArgs = 0x5,
        }
        /// <summary>
        /// Specifies the signature kind. Underlying values correspond to the representation
        /// in the leading signature byte represented by <see cref="SignatureHeader"/>.
        /// </summary>
        public enum SignatureKind : byte
        {
            /// <summary>
            /// Method reference, method definition, or standalone method signature.
            /// </summary>
            Method = 0x0,

            /// <summary>
            /// Field signature.
            /// </summary>
            Field = 0x6,

            /// <summary>
            /// Local variables signature.
            /// </summary>
            LocalVariables = 0x7,

            /// <summary>
            /// Property signature.
            /// </summary>
            Property = 0x8,

            /// <summary>
            /// Method specification signature.
            /// </summary>
            MethodSpecification = 0xA,
        }        

        public enum SignatureTypeKind : byte
        {
            /// <summary>
            /// It is not known in the current context if the type reference or definition is a class or value type.
            /// </summary>
            Unknown = 0,

            /// <summary>
            /// The type definition or reference refers to a class.
            /// </summary>
            Class = CorElementType.ELEMENT_TYPE_CLASS,

            /// <summary>
            /// The type definition or reference refers to a value type.
            /// </summary>
            ValueType = CorElementType.ELEMENT_TYPE_VALUETYPE,
        }

        public enum EditAndContinueOperation
        {
            Default = 0,

            AddMethod = 1,

            AddField = 2,

            AddParameter = 3,

            AddProperty = 4,

            AddEvent = 5,
        }

        public enum FunctionPointerAttributes
        {
            None = 0,

            HasThis = 32,

            HasExplicitThis = 96,
        }

        public enum HeapIndex
        {
            UserString = 0,

            String = 1,

            Blob = 2,

            Guid = 3,
        }

        [Flags]
        public enum MethodBodyAttributes
        {
            None = 0,
            InitLocals = 1,
        }



        [Flags]
        public enum CorFlags
        {
            ILOnly = 1,
            Requires32Bit = 2,
            ILLibrary = 4,
            StrongNameSigned = 8,
            NativeEntryPoint = 16,
            TrackDebugData = 65536,
            Prefers32Bit = 131072,
        }

        public enum DebugDirectoryEntryType
        {
            Unknown = 0,
            Coff = 1,
            CodeView = 2,
            Reproducible = 16,
            EmbeddedPortablePdb = 17,
            PdbChecksum = 19,
        }

        
        public enum Machine : ushort
        {
            Unknown = (ushort)0,
            I386 = (ushort)332,
            WceMipsV2 = (ushort)361,
            Alpha = (ushort)388,
            SH3 = (ushort)418,
            SH3Dsp = (ushort)419,
            SH3E = (ushort)420,
            SH4 = (ushort)422,
            SH5 = (ushort)424,
            Arm = (ushort)448,
            Thumb = (ushort)450,
            ArmThumb2 = (ushort)452,
            AM33 = (ushort)467,
            PowerPC = (ushort)496,
            PowerPCFP = (ushort)497,
            IA64 = (ushort)512,
            MIPS16 = (ushort)614,
            Alpha64 = (ushort)644,
            MipsFpu = (ushort)870,
            MipsFpu16 = (ushort)1126,
            Tricore = (ushort)1312,
            Ebc = (ushort)3772,
            Amd64 = (ushort)34404,
            M32R = (ushort)36929,
            Arm64 = (ushort)43620,
        }

        public enum PEMagic : ushort
        {
            PE32 = (ushort)267,
            PE32Plus = (ushort)523,
        }

        [Flags]
        public enum PEStreamOptions
        {
            Default = 0,
         
            LeaveOpen = 1,
         
            PrefetchMetadata = 2,
         
            PrefetchEntireImage = 4,
         
            IsLoadedImage = 8,
        }

        [Flags]
        public enum SectionCharacteristics : uint
        {
            TypeReg = (uint)0,
            TypeDSect = (uint)1,
            TypeNoLoad = (uint)2,
            TypeGroup = (uint)4,
            TypeNoPad = (uint)8,
            TypeCopy = (uint)16,
            ContainsCode = (uint)32,
            ContainsInitializedData = (uint)64,
            ContainsUninitializedData = (uint)128,
            LinkerOther = (uint)256,
            LinkerInfo = (uint)512,
            TypeOver = (uint)1024,
            LinkerRemove = (uint)2048,
            LinkerComdat = (uint)4096,
            MemProtected = (uint)16384,
            NoDeferSpecExc = (uint)16384,
            GPRel = (uint)32768,
            MemFardata = (uint)32768,
            MemSysheap = (uint)65536,
            Mem16Bit = (uint)131072,
            MemPurgeable = (uint)131072,
            MemLocked = (uint)262144,
            MemPreload = (uint)524288,
            Align1Bytes = (uint)1048576,
            Align2Bytes = (uint)2097152,
            Align4Bytes = (uint)3145728,
            Align8Bytes = (uint)4194304,
            Align16Bytes = (uint)5242880,
            Align32Bytes = (uint)6291456,
            Align64Bytes = (uint)7340032,
            Align128Bytes = (uint)8388608,
            Align256Bytes = (uint)9437184,
            Align512Bytes = (uint)10485760,
            Align1024Bytes = (uint)11534336,
            Align2048Bytes = (uint)12582912,
            Align4096Bytes = (uint)13631488,
            Align8192Bytes = (uint)14680064,
            AlignMask = (uint)15728640,
            LinkerNRelocOvfl = (uint)16777216,
            MemDiscardable = (uint)33554432,
            MemNotCached = (uint)67108864,
            MemNotPaged = (uint)134217728,
            MemShared = (uint)268435456,
            MemExecute = (uint)536870912,
            MemRead = (uint)1073741824,
            MemWrite = (uint)2147483648,
        }

        public enum Subsystem : ushort
        {
            Unknown = (ushort)0,
         
            Native = (ushort)1,
         
            WindowsGui = (ushort)2,
         
            WindowsCui = (ushort)3,
         
            OS2Cui = (ushort)5,
         
            PosixCui = (ushort)7,
         
            NativeWindows = (ushort)8,
         
            WindowsCEGui = (ushort)9,
         
            EfiApplication = (ushort)10,
         
            EfiBootServiceDriver = (ushort)11,
         
            EfiRuntimeDriver = (ushort)12,
         
            EfiRom = (ushort)13,
         
            Xbox = (ushort)14,
         
            WindowsBootApplication = (ushort)16,
        }

        /// <summary>
        /// Indicates whether a <see cref="MemberReference"/> references a method or field.
        /// </summary>
        public enum MemberReferenceKind
        {
            /// <summary>
            /// The <see cref="MemberReference"/> references a method.
            /// </summary>
            Method,

            /// <summary>
            /// The <see cref="MemberReference"/> references a field.
            /// </summary>
            Field,
        }
    }
}
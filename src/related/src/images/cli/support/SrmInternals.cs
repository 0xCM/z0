// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    using static Part;
    using static memory;
    using static Images;

    [ApiHost]
    public readonly struct SrmInternals
    {
        [MethodImpl(Inline), Op]
        public static StringHandle StringHandleFromOffset(int heapOffset)
            => memory.@as<uint,StringHandle>(StringHandleType.String | (uint)heapOffset);

        [Flags]
        enum TableMask : ulong
        {
            Module = 1UL << TableIndex.Module,

            TypeRef = 1UL << TableIndex.TypeRef,

            TypeDef = 1UL << TableIndex.TypeDef,

            FieldPtr = 1UL << TableIndex.FieldPtr,

            Field = 1UL << TableIndex.Field,

            MethodPtr = 1UL << TableIndex.MethodPtr,

            MethodDef = 1UL << TableIndex.MethodDef,

            ParamPtr = 1UL << TableIndex.ParamPtr,

            Param = 1UL << TableIndex.Param,

            InterfaceImpl = 1UL << TableIndex.InterfaceImpl,

            MemberRef = 1UL << TableIndex.MemberRef,

            Constant = 1UL << TableIndex.Constant,

            CustomAttribute = 1UL << TableIndex.CustomAttribute,

            FieldMarshal = 1UL << TableIndex.FieldMarshal,

            DeclSecurity = 1UL << TableIndex.DeclSecurity,

            ClassLayout = 1UL << TableIndex.ClassLayout,

            FieldLayout = 1UL << TableIndex.FieldLayout,

            StandAloneSig = 1UL << TableIndex.StandAloneSig,

            EventMap = 1UL << TableIndex.EventMap,

            EventPtr = 1UL << TableIndex.EventPtr,

            Event = 1UL << TableIndex.Event,

            PropertyMap = 1UL << TableIndex.PropertyMap,

            PropertyPtr = 1UL << TableIndex.PropertyPtr,

            Property = 1UL << TableIndex.Property,

            MethodSemantics = 1UL << TableIndex.MethodSemantics,

            MethodImpl = 1UL << TableIndex.MethodImpl,

            ModuleRef = 1UL << TableIndex.ModuleRef,

            TypeSpec = 1UL << TableIndex.TypeSpec,

            ImplMap = 1UL << TableIndex.ImplMap,

            FieldRva = 1UL << TableIndex.FieldRva,

            EnCLog = 1UL << TableIndex.EncLog,

            EnCMap = 1UL << TableIndex.EncMap,

            Assembly = 1UL << TableIndex.Assembly,

            AssemblyRef = 1UL << TableIndex.AssemblyRef,

            File = 1UL << TableIndex.File,

            ExportedType = 1UL << TableIndex.ExportedType,

            ManifestResource = 1UL << TableIndex.ManifestResource,

            NestedClass = 1UL << TableIndex.NestedClass,

            GenericParam = 1UL << TableIndex.GenericParam,

            MethodSpec = 1UL << TableIndex.MethodSpec,

            GenericParamConstraint = 1UL << TableIndex.GenericParamConstraint,

            Document = 1UL << TableIndex.Document,

            MethodDebugInformation = 1UL << TableIndex.MethodDebugInformation,

            LocalScope = 1UL << TableIndex.LocalScope,

            LocalVariable = 1UL << TableIndex.LocalVariable,

            LocalConstant = 1UL << TableIndex.LocalConstant,

            ImportScope = 1UL << TableIndex.ImportScope,

            StateMachineMethod = 1UL << TableIndex.StateMachineMethod,

            CustomDebugInformation = 1UL << TableIndex.CustomDebugInformation,

            PtrTables =
                FieldPtr
            | MethodPtr
            | ParamPtr
            | EventPtr
            | PropertyPtr,

            EncTables =
                EnCLog
            | EnCMap,

            TypeSystemTables =
                PtrTables
            | EncTables
            | Module
            | TypeRef
            | TypeDef
            | Field
            | MethodDef
            | Param
            | InterfaceImpl
            | MemberRef
            | Constant
            | CustomAttribute
            | FieldMarshal
            | DeclSecurity
            | ClassLayout
            | FieldLayout
            | StandAloneSig
            | EventMap
            | Event
            | PropertyMap
            | Property
            | MethodSemantics
            | MethodImpl
            | ModuleRef
            | TypeSpec
            | ImplMap
            | FieldRva
            | Assembly
            | AssemblyRef
            | File
            | ExportedType
            | ManifestResource
            | NestedClass
            | GenericParam
            | MethodSpec
            | GenericParamConstraint,

            DebugTables =
                Document
            | MethodDebugInformation
            | LocalScope
            | LocalVariable
            | LocalConstant
            | ImportScope
            | StateMachineMethod
            | CustomDebugInformation,

            AllTables =
                TypeSystemTables |
                DebugTables,

            ValidPortablePdbExternalTables =
                TypeSystemTables & ~PtrTables & ~EncTables
        }


        /// <summary>
        /// These constants are all in the byte range and apply to the interpretation of <see cref="Handle.VType"/>,
        /// </summary>
        readonly struct HandleType
        {
            public const uint Module = (uint)TableIndex.Module;

            public const uint TypeRef = (uint)TableIndex.TypeRef;

            public const uint TypeDef = (uint)TableIndex.TypeDef;

            public const uint FieldDef = (uint)TableIndex.Field;

            public const uint MethodDef = (uint)TableIndex.MethodDef;

            public const uint ParamDef = (uint)TableIndex.Param;

            public const uint InterfaceImpl = (uint)TableIndex.InterfaceImpl;

            public const uint MemberRef = (uint)TableIndex.MemberRef;

            public const uint Constant = (uint)TableIndex.Constant;

            public const uint CustomAttribute = (uint)TableIndex.CustomAttribute;

            public const uint DeclSecurity = (uint)TableIndex.DeclSecurity;

            public const uint Signature = (uint)TableIndex.StandAloneSig;

            public const uint EventMap = (uint)TableIndex.EventMap;

            public const uint Event = (uint)TableIndex.Event;

            public const uint PropertyMap = (uint)TableIndex.PropertyMap;

            public const uint Property = (uint)TableIndex.Property;

            public const uint MethodSemantics = (uint)TableIndex.MethodSemantics;

            public const uint MethodImpl = (uint)TableIndex.MethodImpl;

            public const uint ModuleRef = (uint)TableIndex.ModuleRef;

            public const uint TypeSpec = (uint)TableIndex.TypeSpec;

            public const uint Assembly = (uint)TableIndex.Assembly;

            public const uint AssemblyRef = (uint)TableIndex.AssemblyRef;

            public const uint File = (uint)TableIndex.File;

            public const uint ExportedType = (uint)TableIndex.ExportedType;

            public const uint ManifestResource = (uint)TableIndex.ManifestResource;

            public const uint NestedClass = (uint)TableIndex.NestedClass;

            public const uint GenericParam = (uint)TableIndex.GenericParam;

            public const uint MethodSpec = (uint)TableIndex.MethodSpec;

            public const uint GenericParamConstraint = (uint)TableIndex.GenericParamConstraint;

            // debug tables:
            public const uint Document = (uint)TableIndex.Document;

            public const uint MethodDebugInformation = (uint)TableIndex.MethodDebugInformation;

            public const uint LocalScope = (uint)TableIndex.LocalScope;

            public const uint LocalVariable = (uint)TableIndex.LocalVariable;

            public const uint LocalConstant = (uint)TableIndex.LocalConstant;

            public const uint ImportScope = (uint)TableIndex.ImportScope;

            public const uint AsyncMethod = (uint)TableIndex.StateMachineMethod;

            public const uint CustomDebugInformation = (uint)TableIndex.CustomDebugInformation;

            public const uint UserString = 0x70;     // #UserString heap

            // The following values never appear in a token stored in metadata,
            // they are just helper values to identify the type of a handle.
            // Note, however, that even though they do not come from the spec,
            // they are surfaced as public constants via HandleKind enum and
            // therefore cannot change!

            public const uint Blob = 0x71;        // #Blob heap

            public const uint Guid = 0x72;        // #Guid heap

            // #String heap and its modifications
            //
            // Multiple values are reserved for string handles so that we can encode special
            // handling with more than just the virtual bit. See StringHandleType for how
            // the two extra bits are actually interpreted. The extra String1,2,3 values here are
            // not used directly, but serve as a reminder that they are not available for use
            // by another handle type.
            public const uint String  = 0x78;

            public const uint String1 = 0x79;

            public const uint String2 = 0x7a;

            public const uint String3 = 0x7b;

            // Namespace handles also have offsets into the #String heap (when non-virtual)
            // to their full name. However, this is an implementation detail and they are
            // surfaced with first-class HandleKind.Namespace and strongly-typed NamespaceHandle.
            public const uint Namespace = 0x7c;

            public const uint HeapMask = 0x70;

            public const uint TypeMask = 0x7F;

            /// <summary>
            /// Use the highest bit to mark tokens that are virtual (synthesized).
            /// We create virtual tokens to represent projected WinMD entities.
            /// </summary>
            public const uint VirtualBit = 0x80;

            /// <summary>
            /// In the case of string handles, the two lower bits that (in addition to the
            /// virtual bit not included in this mask) encode how to obtain the string value.
            /// </summary>
            public const uint NonVirtualStringTypeMask = 0x03;
        }

        readonly struct StringHandleType
        {
            // The 3 high bits above the offset that specify the full string type (including virtual bit)
            public const uint TypeMask = ~(HeapHandleType.OffsetMask);

            // The string type bits excluding the virtual bit.
            public const uint NonVirtualTypeMask = TypeMask & ~(HeapHandleType.VirtualBit);

            // NUL-terminated UTF8 string on a #String heap.
            public const uint String = (0 << HeapHandleType.OffsetBitCount);

            // String on #String heap whose terminator is NUL and '.', whichever comes first.
            public const uint DotTerminatedString = (1 << HeapHandleType.OffsetBitCount);

            // Reserved values that can be used for future strings:
            public const uint ReservedString1 = (2 << HeapHandleType.OffsetBitCount);
            public const uint ReservedString2 = (3 << HeapHandleType.OffsetBitCount);

            // Virtual string identified by a virtual index
            public const uint VirtualString = HeapHandleType.VirtualBit | (0 << HeapHandleType.OffsetBitCount);

            // Virtual string whose value is a "<WinRT>" prefixed string found at the specified heap offset.
            public const uint WinRTPrefixedString = HeapHandleType.VirtualBit | (1 << HeapHandleType.OffsetBitCount);

            // Reserved virtual strings that can be used in future:
            public const uint ReservedVirtualString1 = HeapHandleType.VirtualBit | (2 << HeapHandleType.OffsetBitCount);
            public const uint ReservedVirtualString2 = HeapHandleType.VirtualBit | (3 << HeapHandleType.OffsetBitCount);
        }

        readonly struct HeapHandleType
        {
            // Heap offset values are limited to 29 bits (max compressed integer)
            public const int OffsetBitCount = 29;

            public const uint OffsetMask = (1 << OffsetBitCount) - 1;

            public const uint VirtualBit = 0x80000000;

            public static bool IsValidHeapOffset(uint offset)
            {
                return (offset & ~OffsetMask) == 0;
            }
        }

        readonly struct TokenTypeIds
        {
            public const uint Module = HandleType.Module << RowIdBitCount;

            public const uint TypeRef = HandleType.TypeRef << RowIdBitCount;

            public const uint TypeDef = HandleType.TypeDef << RowIdBitCount;

            public const uint FieldDef = HandleType.FieldDef << RowIdBitCount;

            public const uint MethodDef = HandleType.MethodDef << RowIdBitCount;

            public const uint ParamDef = HandleType.ParamDef << RowIdBitCount;

            public const uint InterfaceImpl = HandleType.InterfaceImpl << RowIdBitCount;

            public const uint MemberRef = HandleType.MemberRef << RowIdBitCount;

            public const uint Constant = HandleType.Constant << RowIdBitCount;

            public const uint CustomAttribute = HandleType.CustomAttribute << RowIdBitCount;

            public const uint DeclSecurity = HandleType.DeclSecurity << RowIdBitCount;

            public const uint Signature = HandleType.Signature << RowIdBitCount;

            public const uint EventMap = HandleType.EventMap << RowIdBitCount;

            public const uint Event = HandleType.Event << RowIdBitCount;

            public const uint PropertyMap = HandleType.PropertyMap << RowIdBitCount;

            public const uint Property = HandleType.Property << RowIdBitCount;

            public const uint MethodSemantics = HandleType.MethodSemantics << RowIdBitCount;

            public const uint MethodImpl = HandleType.MethodImpl << RowIdBitCount;

            public const uint ModuleRef = HandleType.ModuleRef << RowIdBitCount;

            public const uint TypeSpec = HandleType.TypeSpec << RowIdBitCount;

            public const uint Assembly = HandleType.Assembly << RowIdBitCount;

            public const uint AssemblyRef = HandleType.AssemblyRef << RowIdBitCount;

            public const uint File = HandleType.File << RowIdBitCount;

            public const uint ExportedType = HandleType.ExportedType << RowIdBitCount;

            public const uint ManifestResource = HandleType.ManifestResource << RowIdBitCount;

            public const uint NestedClass = HandleType.NestedClass << RowIdBitCount;

            public const uint GenericParam = HandleType.GenericParam << RowIdBitCount;

            public const uint MethodSpec = HandleType.MethodSpec << RowIdBitCount;

            public const uint GenericParamConstraint = HandleType.GenericParamConstraint << RowIdBitCount;

            // debug tables:
            public const uint Document = HandleType.Document << RowIdBitCount;

            public const uint MethodDebugInformation = HandleType.MethodDebugInformation << RowIdBitCount;

            public const uint LocalScope = HandleType.LocalScope << RowIdBitCount;

            public const uint LocalVariable = HandleType.LocalVariable << RowIdBitCount;

            public const uint LocalConstant = HandleType.LocalConstant << RowIdBitCount;

            public const uint ImportScope = HandleType.ImportScope << RowIdBitCount;

            public const uint AsyncMethod = HandleType.AsyncMethod << RowIdBitCount;

            public const uint CustomDebugInformation = HandleType.CustomDebugInformation << RowIdBitCount;

            public const uint UserString = HandleType.UserString << RowIdBitCount;

            public const int RowIdBitCount = 24;

            public const uint RIDMask = (1 << RowIdBitCount) - 1;

            public const uint TypeMask = HandleType.TypeMask << RowIdBitCount;

            /// <summary>
            /// Use the highest bit to mark tokens that are virtual (synthesized).
            /// We create virtual tokens to represent projected WinMD entities.
            /// </summary>
            public const uint VirtualBit = 0x80000000;

            /// <summary>
            /// Returns true if the token value can escape the metadata reader.
            /// We don't allow virtual tokens and heap tokens other than UserString to escape
            /// since the token type ids are public to the reader and not specified by ECMA spec.
            ///
            /// Spec (Partition III, 1.9 Metadata tokens):
            /// Many CIL instructions are followed by a "metadata token". This is a 4-byte value, that specifies a row in a
            /// metadata table, or a starting byte offset in the User String heap.
            ///
            /// For example, a value of 0x02 specifies the TypeDef table; a value of 0x70 specifies the User
            /// String heap.The value corresponds to the number assigned to that metadata table (see Partition II for the full
            /// list of tables) or to 0x70 for the User String heap.The least-significant 3 bytes specify the target row within that
            /// metadata table, or starting byte offset within the User String heap.
            /// </summary>
            public static bool IsEntityOrUserStringToken(uint vToken)
                => (vToken & TypeMask) <= UserString;

            public static bool IsEntityToken(uint vToken)
                => (vToken & TypeMask) < UserString;

            public static bool IsValidRowId(uint rowId)
            {
                return (rowId & ~RIDMask) == 0;
            }

            public static bool IsValidRowId(int rowId)
            {
                return (rowId & ~RIDMask) == 0;
            }
        }

        readonly struct COR20Constants
        {
            public const int SizeOfCorHeader = 72;

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

            public const string MinimalDeltaMetadataTableStreamName = "#JTD";

            public const string StandalonePdbStreamName = "#Pdb";

            public const int LargeStreamHeapSize = 0x0001000;
        }

    }
}
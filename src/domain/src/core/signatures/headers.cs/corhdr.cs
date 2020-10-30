//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;
    using static Cor.CorElementType;
    using static Cor.CorCallingConvention;
    using static Win.Nt;


    /// <summary>
    /// Transpiled from corhdr.h
    /// </summary>
    public readonly struct Cor
    {
        public struct mdToken
        {
            uint Value;

            [MethodImpl(Inline)]
            internal mdToken(uint value)
                => Value = value;

            [MethodImpl(Inline)]
            public static implicit operator uint(mdToken src)
                => src.Value;

            [MethodImpl(Inline)]
            public static implicit operator mdToken(uint src)
                => new mdToken(src);
        }

        public struct mdFieldDef
        {
            uint Value;

            [MethodImpl(Inline)]
            internal mdFieldDef(uint value)
                => Value = value;

            [MethodImpl(Inline)]
            public static implicit operator uint(mdFieldDef src)
                => src.Value;

            [MethodImpl(Inline)]
            public static implicit operator mdFieldDef(uint src)
                => new mdFieldDef(src);

            [MethodImpl(Inline)]
            public static implicit operator mdToken(mdFieldDef src)
                => new mdToken(src.Value);
        }

        /*

        typedef mdToken mdModule;               // Module token (roughly, a scope)
        typedef mdToken mdTypeRef;              // TypeRef reference (this or other scope)
        typedef mdToken mdTypeDef;              // TypeDef in this scope
        typedef mdToken mdFieldDef;             // Field in this scope
        typedef mdToken mdMethodDef;            // Method in this scope
        typedef mdToken mdParamDef;             // param token
        typedef mdToken mdInterfaceImpl;        // interface implementation token
        typedef mdToken mdMemberRef;            // MemberRef (this or other scope)
        typedef mdToken mdCustomAttribute;      // attribute token
        typedef mdToken mdPermission;           // DeclSecurity
        typedef mdToken mdSignature;            // Signature object
        typedef mdToken mdEvent;                // event token
        typedef mdToken mdProperty;             // property token
        typedef mdToken mdModuleRef;            // Module reference (for the imported modules)
        typedef mdToken mdAssembly;             // Assembly token.
        typedef mdToken mdAssemblyRef;          // AssemblyRef token.
        typedef mdToken mdFile;                 // File token.
        typedef mdToken mdExportedType;         // ExportedType token.
        typedef mdToken mdManifestResource;     // ManifestResource token.
        typedef mdToken mdTypeSpec;             // TypeSpec object
        typedef mdToken mdGenericParam;         // formal parameter to generic type or method
        typedef mdToken mdMethodSpec;           // instantiation of a generic method
        typedef mdToken mdGenericParamConstraint; // constraint on a formal generic parameter
        typedef mdToken mdString;               // User literal string token.
        typedef mdToken mdCPToken;              // constantpool token
        */

        public const string COR_CTOR_METHOD_NAME =       ".ctor";

        public const string COR_CTOR_METHOD_NAME_W   =   ".ctor";

        public const string COR_CCTOR_METHOD_NAME     =  ".cctor";

        public const string COR_CCTOR_METHOD_NAME_W   =   ".cctor";

        public const string COR_ENUM_FIELD_NAME        = "value__";

        public const string COR_ENUM_FIELD_NAME_W      = "value__";

        // The predefined name for deleting a typeDef,MethodDef, FieldDef, Property and Event
        public const string COR_DELETED_NAME_A         = "_Deleted";

        public const string COR_DELETED_NAME_W         = "_Deleted";

        public const string COR_VTABLEGAP_NAME_A    =    "_VtblGap";

        public const string COR_VTABLEGAP_NAME_W   =     "_VtblGap";

        public const CorCallingConvention IMAGE_CEE_CS_CALLCONV_INSTANTIATION = IMAGE_CEE_CS_CALLCONV_GENERICINST;

        // DESCR group for MethodDefs
        public const byte DESCR_GROUP_METHODDEF = 0;

        // DESCR group for MethodImpls
        public const byte DESCR_GROUP_METHODIMPL = 1;

        public enum ReplacesCorHdrNumericDefines : uint
        {
            // COM+ Header entry point flags.
            COMIMAGE_FLAGS_ILONLY               =0x00000001,

            COMIMAGE_FLAGS_32BITREQUIRED        =0x00000002,    // *** Do not manipulate this bit directly (see notes above)

            COMIMAGE_FLAGS_IL_LIBRARY           =0x00000004,

            COMIMAGE_FLAGS_STRONGNAMESIGNED     =0x00000008,

            COMIMAGE_FLAGS_NATIVE_ENTRYPOINT    =0x00000010,

            COMIMAGE_FLAGS_TRACKDEBUGDATA       =0x00010000,

            COMIMAGE_FLAGS_32BITPREFERRED       =0x00020000,    // *** Do not manipulate this bit directly (see notes above)


            // Version flags for image.
            COR_VERSION_MAJOR_V2                =2,

            COR_VERSION_MAJOR                   =COR_VERSION_MAJOR_V2,

            COR_VERSION_MINOR                   =5,

            COR_DELETED_NAME_LENGTH             =8,

            COR_VTABLEGAP_NAME_LENGTH           =8,

            // Maximum size of a NativeType descriptor.
            NATIVE_TYPE_MAX_CB                  =1,

            COR_ILMETHOD_SECT_SMALL_MAX_DATASIZE=0xFF,

            // V-table constants
            COR_VTABLE_32BIT                    =0x01,          // V-table slots are 32-bits in size.

            COR_VTABLE_64BIT                    =0x02,          // V-table slots are 64-bits in size.

            COR_VTABLE_FROM_UNMANAGED           =0x04,          // If set, transition from unmanaged.

            COR_VTABLE_FROM_UNMANAGED_RETAIN_APPDOMAIN=0x08,    // NEW

            COR_VTABLE_CALL_MOST_DERIVED        =0x10,          // Call most derived method described by

            // EATJ constants
            IMAGE_COR_EATJ_THUNK_SIZE           = 32,           // Size of a jump thunk reserved range.

            // Max name lengths
            //@todo: Change to unlimited name lengths.
            MAX_CLASS_NAME                      =1024,

            MAX_PACKAGE_NAME                    =1024,
        }


        //
        // A managed code EXE or DLL uses the same basic format that unmanaged executables use call the Portable
        // Executable (PE) format. See http://en.wikipedia.org/wiki/Portable_Executable or
        // http://msdn.microsoft.com/msdnmag/issues/02/02/PE/default.aspx for more on this format and RVAs.
        //
        // PE files define fixed table of well known entry pointers call Directory entries. Each entry holds the
        // relative virtual address (RVA) and length of a blob of data within the PE file. You can see these using
        // the command
        //
        // link /dump /headers <EXENAME>
        //
        //
        // Managed code has defined one of these entries (the 14th see code:IMAGE_DIRECTORY_ENTRY_COMHEADER) and the RVA points
        // that the IMAGE_COR20_HEADER.  This header shows up in the previous dump as the following line
        //
        // // Managed code is identified by is following line
        //
        //             2008 [      48] RVA [size] of COM Descriptor Directory
        //
        // The IMAGE_COR20_HEADER is mostly just RVA:Length pairs (pointers) to other interesting data structures.
        // The most important of these is the MetaData tables.   The easiest way of looking at meta-data is using
        // the IlDasm.exe tool.
        //
        // MetaData holds most of the information in the IL image.  The exceptions are resource blobs and the IL
        // instructions streams for individual methods.  Instead the Meta-data for a method holds an RVA to a
        // code:IMAGE_COR_ILMETHOD which holds all the IL stream (and exception handling information).
        //
        // Precompiled (NGEN) images use the same IMAGE_COR20_HEADER but also use the ManagedNativeHeader field to
        // point at structures that only exist in precompiled images.
        //
        public struct IMAGE_COR20_HEADER
        {
            // Header versioning
            uint                   cb;

            ushort                    MajorRuntimeVersion;

            ushort                    MinorRuntimeVersion;

            // Symbol table and startup information
            IMAGE_DATA_DIRECTORY    MetaData;

            uint                   Flags;

            uint EntryPoint;

            // The main program if it is an EXE (not used if a DLL?)
            // If COMIMAGE_FLAGS_NATIVE_ENTRYPOINT is not set, EntryPointToken represents a managed entrypoint.
            // If COMIMAGE_FLAGS_NATIVE_ENTRYPOINT is set, EntryPointRVA represents an RVA to a native entrypoint
            // (deprecated for DLLs, use modules constructors instead).
            // union {
            //     uint               EntryPointToken;
            //     uint               EntryPointRVA;
            // };

            // This is the blob of managed resources. Fetched using code:AssemblyNative.GetResource and
            // code:PEFile.GetResource and accessible from managed code from
            // System.Assembly.GetManifestResourceStream.  The meta data has a table that maps names to offsets into
            // this blob, so logically the blob is a set of resources.
            IMAGE_DATA_DIRECTORY    Resources;

            // IL assemblies can be signed with a public-private key to validate who created it.  The signature goes
            // here if this feature is used.
            IMAGE_DATA_DIRECTORY    StrongNameSignature;

            // Deprecated, not used
            IMAGE_DATA_DIRECTORY    CodeManagerTable;

            // Used for manged code that has unmanaged code inside it (or exports methods as unmanaged entry points)
            IMAGE_DATA_DIRECTORY    VTableFixups;

            IMAGE_DATA_DIRECTORY    ExportAddressTableJumps;

            // null for ordinary IL images. In NGEN images it points at a code:CORCOMPILE_HEADER structure.
            // In Ready2Run images it points to a READYTORUN_HEADER.
            IMAGE_DATA_DIRECTORY    ManagedNativeHeader;
        }


        // TypeDef/ExportedType attr bits, used by DefineTypeDef.
        public enum CorTypeAttr : uint
        {
            // Use this mask to retrieve the type visibility information.
            tdVisibilityMask        =   0x00000007,

            // Class is not public scope.
            tdNotPublic             =   0x00000000,

            // Class is public scope.
            tdPublic                =   0x00000001,

            // Class is nested with public visibility.
            tdNestedPublic          =   0x00000002,

            // Class is nested with private visibility.
            tdNestedPrivate         =   0x00000003,

            // Class is nested with family visibility.
            tdNestedFamily          =   0x00000004,

            // Class is nested with assembly visibility.
            tdNestedAssembly        =   0x00000005,

            // Class is nested with family and assembly visibility.
            tdNestedFamANDAssem     =   0x00000006,

            // Class is nested with family or assembly visibility.
            tdNestedFamORAssem      =   0x00000007,

            // Use this mask to retrieve class layout information
            tdLayoutMask            =   0x00000018,

            // Class fields are auto-laid out
            tdAutoLayout            =   0x00000000,

            // Class fields are laid out sequentially
            tdSequentialLayout      =   0x00000008,

            // Layout is supplied explicitly
            tdExplicitLayout        =   0x00000010,
            // end layout mask

            // Use this mask to retrieve class semantics information.
            tdClassSemanticsMask    =   0x00000020,

            tdClass                 =   0x00000000,     // Type is a class.

            tdInterface             =   0x00000020,     // Type is an interface.
            // end semantics mask

            // Special semantics in addition to class semantics.
            tdAbstract              =   0x00000080,     // Class is abstract

            tdSealed                =   0x00000100,     // Class is concrete and may not be extended

            tdSpecialName           =   0x00000400,     // Class name is special.  Name describes how.

            // Implementation attributes.
            tdImport                =   0x00001000,     // Class / interface is imported

            tdSerializable          =   0x00002000,     // The class is Serializable.

            tdWindowsRuntime        =   0x00004000,     // The type is a Windows Runtime type

            // Use tdStringFormatMask to retrieve string information for native interop
            tdStringFormatMask      =   0x00030000,

            // LPTSTR is interpreted as ANSI in this class
            tdAnsiClass             =   0x00000000,

            // LPTSTR is interpreted as UNICODE
            tdUnicodeClass          =   0x00010000,

            // LPTSTR is interpreted automatically
            tdAutoClass             =   0x00020000,

            // A non-standard encoding specified by CustomFormatMask
            tdCustomFormatClass     =   0x00030000,

            // Use this mask to retrieve non-standard encoding information for native interop. The meaning of the values of these 2 bits is unspecified.
            tdCustomFormatMask      =   0x00C00000,

            // end string format mask

            // Initialize the class any time before first static field access.
            tdBeforeFieldInit       =   0x00100000,

            // This ExportedType is a type forwarder.
            tdForwarder             =   0x00200000,

            // Flags reserved for runtime use.
            tdReservedMask          =   0x00040800,

            // Runtime should check name encoding.
            tdRTSpecialName         =   0x00000800,

            // Class has security associate with it.
            tdHasSecurity           =   0x00040000,
        }

        // MethodDef attr bits, Used by DefineMethod.
        public enum CorMethodAttr : ushort
        {
            // member access mask - Use this mask to retrieve accessibility information.
            mdMemberAccessMask          =   0x0007,

            // Member not referenceable.
            mdPrivateScope              =   0x0000,

            // Accessible only by the parent type.
            mdPrivate                   =   0x0001,

            // Accessible by sub-types only in this Assembly.
            mdFamANDAssem               =   0x0002,

            // Accessibly by anyone in the Assembly.
            mdAssem                     =   0x0003,

            // Accessible only by type and sub-types.
            mdFamily                    =   0x0004,

            // Accessibly by sub-types anywhere, plus anyone in assembly.
            mdFamORAssem                =   0x0005,

            // Accessibly by anyone who has visibility to this scope.
            mdPublic                    =   0x0006,
            // end member access mask

            // method contract attributes.

            // Defined on type, else per instance.
            mdStatic                    =   0x0010,

            // Method may not be overridden.
            mdFinal                     =   0x0020,

            // Method virtual.
            mdVirtual                   =   0x0040,

            // Method hides by name+sig, else just by name.
            mdHideBySig                 =   0x0080,

            // vtable layout mask - Use this mask to retrieve vtable attributes.
            mdVtableLayoutMask          =   0x0100,

            // The default.
            mdReuseSlot                 =   0x0000,

            // Method always gets a new slot in the vtable.
            mdNewSlot                   =   0x0100,
            // end vtable layout mask

            // method implementation attributes.

            // Overridability is the same as the visibility.
            mdCheckAccessOnOverride     =   0x0200,

            // Method does not provide an implementation.
            mdAbstract                  =   0x0400,

            // Method is special.  Name describes how.
            mdSpecialName               =   0x0800,

            // interop attributes

            // Implementation is forwarded through pinvoke.
            mdPinvokeImpl               =   0x2000,

            // Managed method exported via thunk to unmanaged code.
            mdUnmanagedExport           =   0x0008,

            // Reserved flags for runtime use only.
            mdReservedMask              =   0xd000,

            // Runtime should check name encoding.
            mdRTSpecialName             =   0x1000,

            // Method has security associate with it.
            mdHasSecurity               =   0x4000,

            // Method calls another method containing security code.
            mdRequireSecObject          =   0x8000,
        }

        // FieldDef attr bits, used by DefineField.
        public enum CorFieldAttr : ushort
        {
            // member access mask - Use this mask to retrieve accessibility information.
            fdFieldAccessMask           =   0x0007,

            // Member not referenceable.
            fdPrivateScope              =   0x0000,

            fdPrivate                   =   0x0001,     // Accessible only by the parent type.

            // Accessible by sub-types only in this Assembly.
            fdFamANDAssem               =   0x0002,

            // Accessibly by anyone in the Assembly.
            fdAssembly                  =   0x0003,

            // Accessible only by type and sub-types.
            fdFamily                    =   0x0004,

            // Accessibly by sub-types anywhere, plus anyone in assembly.
            fdFamORAssem                =   0x0005,

            // Accessibly by anyone who has visibility to this scope.
            fdPublic                    =   0x0006,

            // end member access mask

            // field contract attributes.

            // Defined on type, else per instance.
            fdStatic                    =   0x0010,

            // Field may only be initialized, not written to after init.
            fdInitOnly                  =   0x0020,

            // Value is compile time constant.
            fdLiteral                   =   0x0040,

            // Field does not have to be serialized when type is remoted.
            fdNotSerialized             =   0x0080,

            // field is special.  Name describes how.
            fdSpecialName               =   0x0200,

            // interop attributes
            // Implementation is forwarded through pinvoke.
            fdPinvokeImpl               =   0x2000,

            // Reserved flags for runtime use only.
            fdReservedMask              =   0x9500,

            // Runtime(metadata internal APIs) should check name encoding.
            fdRTSpecialName             =   0x0400,

            // Field has marshalling information.
            fdHasFieldMarshal           =   0x1000,

            // Field has default.
            fdHasDefault                =   0x8000,

            // Field has RVA.
            fdHasFieldRVA               =   0x0100,
        }

        // Param attr bits, used by DefineParam.
        public enum CorParamAttr : ushort
        {
            // Param is [In]
            pdIn                        =   0x0001,

            // Param is [out]
            pdOut                       =   0x0002,

            // Param is optional
            pdOptional                  =   0x0010,

            // Reserved flags for Runtime use only.
            pdReservedMask              =   0xf000,

            // Param has default value.
            pdHasDefault                =   0x1000,

            // Param has FieldMarshal.
            pdHasFieldMarshal           =   0x2000,

            pdUnused                    =   0xcfe0,
        }

        // Property attr bits, used by DefineProperty.
        public enum CorPropertyAttr : ushort
        {
            // property is special.  Name describes how.
            prSpecialName           =   0x0200,

            // Reserved flags for Runtime use only.
            prReservedMask          =   0xf400,

           // Runtime(metadata internal APIs) should check name encoding.
            prRTSpecialName         =   0x0400,

            // Property has default
            prHasDefault            =   0x1000,

            prUnused                =   0xe9ff,
        }

        // Event attr bits, used by DefineEvent.
        public enum CorEventAttr : ushort
        {
            // event is special.  Name describes how.
            evSpecialName           =   0x0200,

            // Reserved flags for Runtime use only.
            evReservedMask          =   0x0400,

            // Runtime(metadata internal APIs) should check name encoding.
            evRTSpecialName         =   0x0400,
        }


        // MethodSemantic attr bits, used by DefineProperty, DefineEvent.
        public enum CorMethodSemanticsAttr : ushort
        {
            // Setter for property
            msSetter    =   0x0001,

            // Getter for property
            msGetter    =   0x0002,

            // other method for property or event
            msOther     =   0x0004,

             // AddOn method for event
            msAddOn     =   0x0008,

            // RemoveOn method for event
            msRemoveOn  =   0x0010,

            // Fire method for event
            msFire      =   0x0020,
        }

        // DeclSecurity attr bits, used by DefinePermissionSet.
        public enum CorDeclSecurity : ushort
        {
             // Mask allows growth of enum.
            dclActionMask               =   0x001f,

            dclActionNil                =   0x0000,

            dclRequest                  =   0x0001,

            dclDemand                   =   0x0002,

            dclAssert                   =   0x0003,

            dclDeny                     =   0x0004,

            dclPermitOnly               =   0x0005,

            dclLinktimeCheck            =   0x0006,

            dclInheritanceCheck         =   0x0007,

            dclRequestMinimum           =   0x0008,

            dclRequestOptional          =   0x0009,

            dclRequestRefuse            =   0x000a,

            // Persisted grant set at prejit time
            dclPrejitGrant              =   0x000b,

            // Persisted denied set at prejit time
            dclPrejitDenied             =   0x000c,

            dclNonCasDemand             =   0x000d,     //

            dclNonCasLinkDemand         =   0x000e,     //

            dclNonCasInheritance        =   0x000f,     //

            // Maximum legal value
            dclMaximumValue             =   0x000f,
        }


        // MethodImpl attr bits, used by DefineMethodImpl.
        public enum CorMethodImpl : ushort
        {
            // code impl mask
            miCodeTypeMask       =   0x0003,   // Flags about code type.

            // Method impl is IL.
            miIL                 =   0x0000,

            // Method impl is native.
            miNative             =   0x0001,

            // Method impl is OPTIL
            miOPTIL              =   0x0002,

            // Method impl is provided by the runtime.
            miRuntime            =   0x0003,
            // end code impl mask

            // managed mask

            // Flags specifying whether the code is managed or unmanaged.
            miManagedMask        =   0x0004,

            // Method impl is unmanaged, otherwise managed.
            miUnmanaged          =   0x0004,

            // Method impl is managed.
            miManaged            =   0x0000,
            // end managed mask

            // implementation info and interop
            miForwardRef         =   0x0010,   // Indicates method is defined; used primarily in merge scenarios.

            miPreserveSig        =   0x0080,   // Indicates method sig is not to be mangled to do HRESULT conversion.

            miInternalCall       =   0x1000,   // Reserved for internal use.

            miSynchronized       =   0x0020,   // Method is single threaded through the body.

            miNoInlining         =   0x0008,   // Method may not be inlined.

            miAggressiveInlining =   0x0100,   // Method should be inlined if possible.

            miNoOptimization     =   0x0040,   // Method may not be optimized.

            miAggressiveOptimization = 0x0200, // Method may contain hot code and should be aggressively optimized.

            // These are the flags that are allowed in MethodImplAttribute's Value
            // property. This should include everything above except the code impl
            // flags (which are used for MethodImplAttribute's MethodCodeType field).
            miUserMask           =   miManagedMask | miForwardRef | miPreserveSig |
                                    miInternalCall | miSynchronized |
                                    miNoInlining | miAggressiveInlining |
                                    miNoOptimization | miAggressiveOptimization,

            miMaxMethodImplVal   =   0xffff,   // Range check value
        }


        // PinvokeMap attr bits, used by DefinePinvokeMap.
        public enum  CorPinvokeMap : ushort
        {
            pmNoMangle          = 0x0001,   // Pinvoke is to use the member name as specified.

            // Use this mask to retrieve the CharSet information.
            pmCharSetMask       = 0x0006,

            pmCharSetNotSpec    = 0x0000,

            pmCharSetAnsi       = 0x0002,

            pmCharSetUnicode    = 0x0004,

            pmCharSetAuto       = 0x0006,


            pmBestFitUseAssem   = 0x0000,

            pmBestFitEnabled    = 0x0010,

            pmBestFitDisabled   = 0x0020,

            pmBestFitMask       = 0x0030,

            pmThrowOnUnmappableCharUseAssem   = 0x0000,

            pmThrowOnUnmappableCharEnabled    = 0x1000,

            pmThrowOnUnmappableCharDisabled   = 0x2000,

            pmThrowOnUnmappableCharMask       = 0x3000,

            // Information about target function. Not relevant for fields.
            pmSupportsLastError = 0x0040,

            // None of the calling convention flags is relevant for fields.

            pmCallConvMask      = 0x0700,

            // Pinvoke will use native callconv appropriate to target windows platform.
            pmCallConvWinapi    = 0x0100,

            pmCallConvCdecl     = 0x0200,

            pmCallConvStdcall   = 0x0300,

            pmCallConvThiscall  = 0x0400,   // In M9, pinvoke will raise exception.

            pmCallConvFastcall  = 0x0500,

            pmMaxValue          = 0xFFFF,
        }


        // Assembly attr bits, used by DefineAssembly.
        public enum CorAssemblyFlags : ushort
        {
            afPublicKey             =   0x0001,     // The assembly ref holds the full (unhashed) public key.

            afPA_None               =   0x0000,     // Processor Architecture unspecified

            // Processor Architecture: neutral (PE32)
            afPA_MSIL               =   0x0010,

            // Processor Architecture: x86 (PE32)
            afPA_x86                =   0x0020,

            // Processor Architecture: Itanium (PE32+)
            afPA_IA64               =   0x0030,

            // Processor Architecture: AMD X64 (PE32+)
            afPA_AMD64              =   0x0040,

            // Processor Architecture: ARM (PE32)
            afPA_ARM                =   0x0050,

             // Processor Architecture: ARM64 (PE32+)
            afPA_ARM64              =   0x0060,

            // applies to any platform but cannot run on any (e.g. reference assembly), should not have "specified" set
            afPA_NoPlatform         =   0x0070,

            // Propagate PA flags to AssemblyRef record
            afPA_Specified          =   0x0080,

            // Bits describing the processor architecture
            afPA_Mask               =   0x0070,

            // Bits describing the PA incl. Specified
            afPA_FullMask           =   0x00F0,

            // NOT A FLAG, shift count in PA flags <--> index conversion
            afPA_Shift              =   0x0004,

            // From "DebuggableAttribute".
            afEnableJITcompileTracking   =  0x8000,

            // From "DebuggableAttribute".
            afDisableJITcompileOptimizer =  0x4000,

            afDebuggableAttributeMask    =  0xc000,

            // The assembly can be retargeted (at runtime) to an assembly from a different publisher.
            afRetargetable          =   0x0100,

            afContentType_Default         = 0x0000,

            afContentType_WindowsRuntime  = 0x0200,

            afContentType_Mask            = 0x0E00, // Bits describing ContentType
        }

        public enum CorManifestResourceFlags : ushort
        {
            mrVisibilityMask        =   0x0007,

            // The Resource is exported from the Assembly.
            mrPublic                =   0x0001,

            // The Resource is private to the Assembly.
            mrPrivate               =   0x0002,
        }

        public enum CorFileFlags : ushort
        {
            ffContainsMetaData      =   0x0000,     // This is not a resource file
            ffContainsNoMetaData    =   0x0001,     // This is a resource file or other non-metadata-containing file
        }


        // PE file kind bits, returned by IMetaDataImport2::GetPEKind()
        public enum CorPEKind : uint
        {
            peNot       = 0x00000000,   // not a PE file

            // flag IL_ONLY is set in COR header
            peILonly    = 0x00000001,

            // flag 32BITREQUIRED is set and 32BITPREFERRED is clear in COR header
            pe32BitRequired=0x00000002,

            // PE32+ file (64 bit)
            pe32Plus    = 0x00000004,

            // PE32 without COR header
            pe32Unmanaged=0x00000008,

            // flags 32BITREQUIRED and 32BITPREFERRED are set in COR header
            pe32BitPreferred=0x00000010
        }

        //*****************************************************************************
        //
        // Element type for Cor signature
        //
        //*****************************************************************************

        // GenericParam bits, used by DefineGenericParam.
        public enum CorGenericParamAttr : ushort
        {
            // Variance of type parameters, only applicable to generic parameters
            // for generic interfaces and delegates
            gpVarianceMask          =   0x0003,

            gpNonVariant            =   0x0000,

            gpCovariant             =   0x0001,

            gpContravariant         =   0x0002,

            // Special constraints, applicable to any type parameters
            gpSpecialConstraintMask =  0x001C,

            gpNoSpecialConstraint   =   0x0000,

            // type argument must be a reference type
            gpReferenceTypeConstraint = 0x0004,

            // type argument must be a value type but not Nullable
            gpNotNullableValueTypeConstraint   =   0x0008,

            // type argument must have a public default constructor
            gpDefaultConstructorConstraint = 0x0010,
        }

        /// <summary>
        /// Runtime element classifier
        /// </summary>
        /// <remarks>CLI spec, Partition II, section 23.1.16</remarks>
        public enum CorElementType : byte
        {
            ELEMENT_TYPE_END            = 0x00,

            ELEMENT_TYPE_VOID           = 0x01,

            ELEMENT_TYPE_BOOLEAN        = 0x02,

            ELEMENT_TYPE_CHAR           = 0x03,

            ELEMENT_TYPE_I1             = 0x04,

            ELEMENT_TYPE_U1             = 0x05,

            ELEMENT_TYPE_I2             = 0x06,

            ELEMENT_TYPE_U2             = 0x07,

            ELEMENT_TYPE_I4             = 0x08,

            ELEMENT_TYPE_U4             = 0x09,

            ELEMENT_TYPE_I8             = 0x0a,

            ELEMENT_TYPE_U8             = 0x0b,

            ELEMENT_TYPE_R4             = 0x0c,

            ELEMENT_TYPE_R8             = 0x0d,

            ELEMENT_TYPE_STRING         = 0x0e,

            // every type above PTR will be simple type PTR <type>
            ELEMENT_TYPE_PTR            = 0x0f,

            // BYREF <type>
            ELEMENT_TYPE_BYREF          = 0x10,

            // Please use ELEMENT_TYPE_VALUETYPE.
            //ELEMENT_TYPE_VALUECLASS is deprecated.
            // VALUETYPE <class Token>
            ELEMENT_TYPE_VALUETYPE      = 0x11,

            // CLASS <class Token>
            ELEMENT_TYPE_CLASS          = 0x12,

            // a class type variable VAR <number>
            ELEMENT_TYPE_VAR            = 0x13,

            // MDARRAY <type> <rank> <bcount> <bound1> ... <lbcount> <lb1> ...
            ELEMENT_TYPE_ARRAY          = 0x14,

            // GENERICINST <generic type> <argCnt> <arg1> ... <argn>
            ELEMENT_TYPE_GENERICINST    = 0x15,

            // TYPEDREF  (it takes no args) a typed reference to some other type
            ELEMENT_TYPE_TYPEDBYREF     = 0x16,

            // native integer size
            ELEMENT_TYPE_I              = 0x18,

            // native unsigned integer size
            ELEMENT_TYPE_U              = 0x19,

            // FNPTR <complete sig for the function including calling convention>
            ELEMENT_TYPE_FNPTR          = 0x1b,

            // Shortcut for System.Object
            ELEMENT_TYPE_OBJECT         = 0x1c,

            // Shortcut for single dimension zero lower bound array SZARRAY <type>
            ELEMENT_TYPE_SZARRAY        = 0x1d,

            // a method type variable MVAR <number>
            ELEMENT_TYPE_MVAR           = 0x1e,

            // This is only for binding
            // required C modifier : E_T_CMOD_REQD <mdTypeRef/mdTypeDef>
            ELEMENT_TYPE_CMOD_REQD      = 0x1f,

            // optional C modifier : E_T_CMOD_OPT <mdTypeRef/mdTypeDef>
            ELEMENT_TYPE_CMOD_OPT       = 0x20,

            // This is for signatures generated internally (which will not be persisted in any way).
            ELEMENT_TYPE_INTERNAL       = 0x21,     // INTERNAL <typehandle>

            // Note that this is the max of base type excluding modifiers
            ELEMENT_TYPE_MAX            = 0x22,     // first invalid element type

            ELEMENT_TYPE_MODIFIER       = 0x40,

            ELEMENT_TYPE_SENTINEL       = 0x01 | ELEMENT_TYPE_MODIFIER, // sentinel for varargs

            ELEMENT_TYPE_PINNED         = 0x05 | ELEMENT_TYPE_MODIFIER,
        }


        //*****************************************************************************
        //
        // Serialization types for Custom attribute support
        //
        //*****************************************************************************

        public enum CorSerializationType : byte
        {
            SERIALIZATION_TYPE_UNDEFINED    = 0,

            SERIALIZATION_TYPE_BOOLEAN      = ELEMENT_TYPE_BOOLEAN,

            SERIALIZATION_TYPE_CHAR         = ELEMENT_TYPE_CHAR,

            SERIALIZATION_TYPE_I1           = ELEMENT_TYPE_I1,

            SERIALIZATION_TYPE_U1           = ELEMENT_TYPE_U1,

            SERIALIZATION_TYPE_I2           = ELEMENT_TYPE_I2,

            SERIALIZATION_TYPE_U2           = ELEMENT_TYPE_U2,

            SERIALIZATION_TYPE_I4           = ELEMENT_TYPE_I4,

            SERIALIZATION_TYPE_U4           = ELEMENT_TYPE_U4,

            SERIALIZATION_TYPE_I8           = ELEMENT_TYPE_I8,

            SERIALIZATION_TYPE_U8           = ELEMENT_TYPE_U8,

            SERIALIZATION_TYPE_R4           = ELEMENT_TYPE_R4,

            SERIALIZATION_TYPE_R8           = ELEMENT_TYPE_R8,

            SERIALIZATION_TYPE_STRING       = ELEMENT_TYPE_STRING,

            // Shortcut for single dimension zero lower bound array
            SERIALIZATION_TYPE_SZARRAY      = ELEMENT_TYPE_SZARRAY,

            SERIALIZATION_TYPE_TYPE         = 0x50,

            SERIALIZATION_TYPE_TAGGED_OBJECT= 0x51,

            SERIALIZATION_TYPE_FIELD        = 0x53,

            SERIALIZATION_TYPE_PROPERTY     = 0x54,

            SERIALIZATION_TYPE_ENUM         = 0x55
        }

        public enum CorCallingConvention : byte
        {
            IMAGE_CEE_CS_CALLCONV_DEFAULT       = 0x0,

            IMAGE_CEE_CS_CALLCONV_VARARG        = 0x5,

            IMAGE_CEE_CS_CALLCONV_FIELD         = 0x6,

            IMAGE_CEE_CS_CALLCONV_LOCAL_SIG     = 0x7,

            IMAGE_CEE_CS_CALLCONV_PROPERTY      = 0x8,

            // Unmanaged calling convention encoded as modopts
            IMAGE_CEE_CS_CALLCONV_UNMANAGED     = 0x9,

            // generic method instantiation
            IMAGE_CEE_CS_CALLCONV_GENERICINST   = 0xa,

            // used ONLY for 64bit vararg PInvoke calls
            IMAGE_CEE_CS_CALLCONV_NATIVEVARARG  = 0xb,

            // first invalid calling convention
            IMAGE_CEE_CS_CALLCONV_MAX           = 0xc,

            // The high bits of the calling convention convey additional info
            // Calling convention is bottom 4 bits
            IMAGE_CEE_CS_CALLCONV_MASK      = 0x0f,

            // Top bit indicates a 'this' parameter
            IMAGE_CEE_CS_CALLCONV_HASTHIS   = 0x20,

            // This parameter is explicitly in the signature
            IMAGE_CEE_CS_CALLCONV_EXPLICITTHIS = 0x40,

            // Generic method sig with explicit number of type arguments (precedes ordinary parameter count)
            IMAGE_CEE_CS_CALLCONV_GENERIC   = 0x10,
        }

        public enum CorUnmanagedCallingConvention : byte
        {
            IMAGE_CEE_UNMANAGED_CALLCONV_C         = 0x1,

            IMAGE_CEE_UNMANAGED_CALLCONV_STDCALL   = 0x2,

            IMAGE_CEE_UNMANAGED_CALLCONV_THISCALL  = 0x3,

            IMAGE_CEE_UNMANAGED_CALLCONV_FASTCALL  = 0x4,

            IMAGE_CEE_CS_CALLCONV_C         = IMAGE_CEE_UNMANAGED_CALLCONV_C,

            IMAGE_CEE_CS_CALLCONV_STDCALL   = IMAGE_CEE_UNMANAGED_CALLCONV_STDCALL,

            IMAGE_CEE_CS_CALLCONV_THISCALL  = IMAGE_CEE_UNMANAGED_CALLCONV_THISCALL,

            IMAGE_CEE_CS_CALLCONV_FASTCALL  = IMAGE_CEE_UNMANAGED_CALLCONV_FASTCALL,
        }

        public enum CorArgType : byte
        {
            IMAGE_CEE_CS_END        = 0x0,

            IMAGE_CEE_CS_VOID       = 0x1,

            IMAGE_CEE_CS_I4         = 0x2,

            IMAGE_CEE_CS_I8         = 0x3,

            IMAGE_CEE_CS_R4         = 0x4,

            IMAGE_CEE_CS_R8         = 0x5,

            IMAGE_CEE_CS_PTR        = 0x6,

            IMAGE_CEE_CS_OBJECT     = 0x7,

            IMAGE_CEE_CS_STRUCT4    = 0x8,

            IMAGE_CEE_CS_STRUCT32   = 0x9,

            IMAGE_CEE_CS_BYVALUE    = 0xA,
        }


        //*****************************************************************************
        //
        // Native type for N-Direct
        //
        //*****************************************************************************

        // Keep this in-synch with ndp\clr\src\BCL\System\runtime\interopservices\attributes.cs
        public enum CorNativeType : byte
        {

            //DEPRECATED
            NATIVE_TYPE_END         = 0x0,

            //DEPRECATED
            NATIVE_TYPE_VOID        = 0x1,

            // (4 byte boolean value: TRUE = non-zero, FALSE = 0)
            NATIVE_TYPE_BOOLEAN     = 0x2,

            NATIVE_TYPE_I1          = 0x3,

            NATIVE_TYPE_U1          = 0x4,

            NATIVE_TYPE_I2          = 0x5,

            NATIVE_TYPE_U2          = 0x6,

            NATIVE_TYPE_I4          = 0x7,

            NATIVE_TYPE_U4          = 0x8,

            NATIVE_TYPE_I8          = 0x9,

            NATIVE_TYPE_U8          = 0xa,

            NATIVE_TYPE_R4          = 0xb,

            NATIVE_TYPE_R8          = 0xc,

            //DEPRECATED
            NATIVE_TYPE_SYSCHAR     = 0xd,

            //DEPRECATED
            NATIVE_TYPE_VARIANT     = 0xe,

            NATIVE_TYPE_CURRENCY    = 0xf,

            //DEPRECATED
            NATIVE_TYPE_PTR         = 0x10,

            //DEPRECATED
            NATIVE_TYPE_DECIMAL     = 0x11,

            //DEPRECATED
            NATIVE_TYPE_DATE        = 0x12,

            //COMINTEROP
            NATIVE_TYPE_BSTR        = 0x13,

            NATIVE_TYPE_LPSTR       = 0x14,

            NATIVE_TYPE_LPWSTR      = 0x15,

            NATIVE_TYPE_LPTSTR      = 0x16,

            NATIVE_TYPE_FIXEDSYSSTRING  = 0x17,

            NATIVE_TYPE_OBJECTREF   = 0x18,   //DEPRECATED

            NATIVE_TYPE_IUNKNOWN    = 0x19,   //COMINTEROP

            NATIVE_TYPE_IDISPATCH   = 0x1a,   //COMINTEROP

            NATIVE_TYPE_STRUCT      = 0x1b,

            NATIVE_TYPE_INTF        = 0x1c,   //COMINTEROP

            NATIVE_TYPE_SAFEARRAY   = 0x1d,   //COMINTEROP

            NATIVE_TYPE_FIXEDARRAY  = 0x1e,

            NATIVE_TYPE_INT         = 0x1f,

            NATIVE_TYPE_UINT        = 0x20,

            //DEPRECATED (use NATIVE_TYPE_STRUCT)
            NATIVE_TYPE_NESTEDSTRUCT  = 0x21,

            NATIVE_TYPE_BYVALSTR    = 0x22,   //COMINTEROP

            NATIVE_TYPE_ANSIBSTR    = 0x23,   //COMINTEROP

            // select BSTR or ANSIBSTR depending on platform COMINTEROP
            NATIVE_TYPE_TBSTR       = 0x24,

            // (2-byte boolean value: TRUE = -1, FALSE = 0) COMINTEROP
            NATIVE_TYPE_VARIANTBOOL = 0x25,

            NATIVE_TYPE_FUNC        = 0x26,

            NATIVE_TYPE_ASANY       = 0x28,

            NATIVE_TYPE_ARRAY       = 0x2a,
            NATIVE_TYPE_LPSTRUCT    = 0x2b,

            // Custom marshaler native type. This must be followed
            // by a string of the following format:
            // "Native type name/0Custom marshaler type name/0Optional cookie/0"
            // Or "{Native type GUID}/0Custom marshaler type name/0Optional cookie/0"
            NATIVE_TYPE_CUSTOMMARSHALER = 0x2c,

            // This native type coupled with ELEMENT_TYPE_I4 will map to VT_HRESULT COMINTEROP
            NATIVE_TYPE_ERROR       = 0x2d,


            NATIVE_TYPE_IINSPECTABLE = 0x2e,

            NATIVE_TYPE_HSTRING     = 0x2f,

            NATIVE_TYPE_LPUTF8STR   = 0x30, // utf-8 string

            // first invalid element type
            NATIVE_TYPE_MAX         = 0x50,
        }


        /***********************************************************************************/
        // a COR_ILMETHOD_SECT is a generic container for attributes that are private
        // to a particular method.  The COR_ILMETHOD structure points to one of these
        // (see GetSect()).  COR_ILMETHOD_SECT can decode the Kind of attribute (but not
        // its internal data layout, and can skip past the current attribute to find the
        // Next one.   The overhead for COR_ILMETHOD_SECT is a minimum of 2 bytes.

        public enum CorILMethodSect : byte                            // codes that identify attributes
        {
            CorILMethod_Sect_Reserved    = 0,

            CorILMethod_Sect_EHTable     = 1,

            CorILMethod_Sect_OptILTable  = 2,

            CorILMethod_Sect_KindMask    = 0x3F,        // The mask for decoding the type code

            CorILMethod_Sect_FatFormat   = 0x40,        // fat format

            CorILMethod_Sect_MoreSects   = 0x80,        // there is another attribute after this one
        }

        /************************************/
        /* NOTE this structure must be DWORD aligned!! */
        [StructLayout(LayoutKind.Explicit, Size=32)]
        public struct IMAGE_COR_ILMETHOD_SECT_SMALL
        {
            [FieldOffset(0)]
            public byte Kind;

            [FieldOffset(1)]
            public byte DataSize;
        }

        /************************************/
        /* NOTE this structure must be DWORD aligned!! */

        [StructLayout(LayoutKind.Explicit, Size=32)]
        public struct IMAGE_COR_ILMETHOD_SECT_FAT
        {
            [FieldOffset(0)]
            public byte Kind;

            [FieldOffset(3)]
            public byte DataSize;
        }

        /***********************************************************************************/
        /* If COR_ILMETHOD_SECT_HEADER::Kind() = CorILMethod_Sect_EHTable then the attribute
        is a list of exception handling clauses.  There are two formats, fat or small
        definitions for the Flags field below (for both big and small)
        */
        [Flags]
        public enum CorExceptionFlag : byte
        {
            // This is a typed handler
            COR_ILEXCEPTION_CLAUSE_NONE,

            // Deprecated
            COR_ILEXCEPTION_CLAUSE_OFFSETLEN = 0x0000,

            // Deprecated
            COR_ILEXCEPTION_CLAUSE_DEPRECATED = 0x0000,

            // If this bit is on, then this EH entry is for a filter
            COR_ILEXCEPTION_CLAUSE_FILTER  = 0x0001,

            // This clause is a finally clause
            COR_ILEXCEPTION_CLAUSE_FINALLY = 0x0002,

            // Fault clause (finally that is called on exception only)
            COR_ILEXCEPTION_CLAUSE_FAULT = 0x0004,

            // duplicated clause. This clause was duplicated to a funclet which was pulled out of line
            COR_ILEXCEPTION_CLAUSE_DUPLICATED = 0x0008,
        }

        /***********************************************************************************/
        // Legal values for
        // * code:IMAGE_COR_ILMETHOD_FAT::Flags or
        // * code:IMAGE_COR_ILMETHOD_TINY::Flags_CodeSize fields.
        //
        // The only semantic flag at present is CorILMethod_InitLocals
        enum CorILMethodFlags : ushort
        {
            // call default constructor on all local vars
            CorILMethod_InitLocals      = 0x0010,

            // there is another attribute after this one
            CorILMethod_MoreSects       = 0x0008,

            CorILMethod_CompressedIL    = 0x0040,           // Not used.

            // Indicates the format for the COR_ILMETHOD header
            CorILMethod_FormatShift     = 3,

            CorILMethod_FormatMask      = ((1 << CorILMethod_FormatShift) - 1),

            // use this code if the code size is even
            CorILMethod_TinyFormat      = 0x0002,

            CorILMethod_SmallFormat     = 0x0000,

            CorILMethod_FatFormat       = 0x0003,

            // use this code if the code size is odd
            CorILMethod_TinyFormat1     = 0x0006,
        }


        //*****************************************************************************
        // Non VOS v-table entries.  Define an array of these pointed to by
        // IMAGE_COR20_HEADER.VTableFixups.  Each entry describes a contiguous array of
        // v-table slots.  The slots start out initialized to the meta data token value
        // for the method they need to call.  At image load time, the CLR Loader will
        // turn each entry into a pointer to machine code for the CPU and can be
        // called directly.
        //*****************************************************************************

        public struct IMAGE_COR_VTABLEFIXUP
        {
            // Offset of v-table array in image.
            public ulong       RVA;

            // How many entries at location.
            public ushort      Count;

            // COR_VTABLE_xxx type of entries.
            public ushort      Type;
        }


        //*****************************************************************************
        //*****************************************************************************
        //
        // M E T A - D A T A    D E C L A R A T I O N S
        //
        //*****************************************************************************
        //*****************************************************************************

        //*****************************************************************************
        //
        // Enums for SetOption API.
        //
        //*****************************************************************************

        // flags for MetaDataCheckDuplicatesFor
        [Flags]
        public enum CorCheckDuplicatesFor : uint
        {
            MDDupAll                    = 0xffffffff,

            MDDupENC                    = MDDupAll,

            MDNoDupChecks               = 0x00000000,

            MDDupTypeDef                = 0x00000001,

            MDDupInterfaceImpl          = 0x00000002,

            MDDupMethodDef              = 0x00000004,

            MDDupTypeRef                = 0x00000008,

            MDDupMemberRef              = 0x00000010,

            MDDupCustomAttribute        = 0x00000020,

            MDDupParamDef               = 0x00000040,

            MDDupPermission             = 0x00000080,

            MDDupProperty               = 0x00000100,

            MDDupEvent                  = 0x00000200,

            MDDupFieldDef               = 0x00000400,

            MDDupSignature              = 0x00000800,

            MDDupModuleRef              = 0x00001000,

            MDDupTypeSpec               = 0x00002000,

            MDDupImplMap                = 0x00004000,

            MDDupAssemblyRef            = 0x00008000,

            MDDupFile                   = 0x00010000,

            MDDupExportedType           = 0x00020000,

            MDDupManifestResource       = 0x00040000,

            MDDupGenericParam           = 0x00080000,

            MDDupMethodSpec             = 0x00100000,

            MDDupGenericParamConstraint = 0x00200000,

            // gap for debug junk
            MDDupAssembly               = 0x10000000,

            // This is the default behavior on metadata. It will check duplicates for TypeRef, MemberRef, Signature, TypeSpec and MethodSpec.
            MDDupDefault = MDNoDupChecks | MDDupTypeRef | MDDupMemberRef | MDDupSignature | MDDupTypeSpec | MDDupMethodSpec,
        }


        // flags for MetaDataRefToDefCheck
        public enum CorRefToDefCheck : uint
        {
            // default behavior is to always perform TypeRef to TypeDef and MemberRef to MethodDef/FieldDef optimization
            MDRefToDefDefault           = 0x00000003,

            MDRefToDefAll               = 0xffffffff,

            MDRefToDefNone              = 0x00000000,

            MDTypeRefToDef              = 0x00000001,

            MDMemberRefToDef            = 0x00000002
        }


        // MetaDataNotificationForTokenMovement
        public enum CorNotificationForTokenMovement : uint
        {
            // default behavior is to notify TypeRef, MethodDef, MemberRef, and FieldDef token remaps
            MDNotifyDefault             = 0x0000000f,

            MDNotifyAll                 = 0xffffffff,

            MDNotifyNone                = 0x00000000,

            MDNotifyMethodDef           = 0x00000001,

            MDNotifyMemberRef           = 0x00000002,

            MDNotifyFieldDef            = 0x00000004,

            MDNotifyTypeRef             = 0x00000008,

            MDNotifyTypeDef             = 0x00000010,

            MDNotifyParamDef            = 0x00000020,

            MDNotifyInterfaceImpl       = 0x00000040,

            MDNotifyProperty            = 0x00000080,

            MDNotifyEvent               = 0x00000100,

            MDNotifySignature           = 0x00000200,

            MDNotifyTypeSpec            = 0x00000400,

            MDNotifyCustomAttribute     = 0x00000800,

            MDNotifySecurityValue       = 0x00001000,

            MDNotifyPermission          = 0x00002000,

            MDNotifyModuleRef           = 0x00004000,

            MDNotifyNameSpace           = 0x00008000,

            MDNotifyAssemblyRef         = 0x01000000,

            MDNotifyFile                = 0x02000000,

            MDNotifyExportedType        = 0x04000000,

            MDNotifyResource            = 0x08000000,
        }

        public enum CorSetENC : uint
        {
            MDSetENCOn                  = 0x00000001,   // Deprecated name.

            MDSetENCOff                 = 0x00000002,   // Deprecated name.

            MDUpdateENC                 = 0x00000001,   // ENC mode.  Tokens don't move; can be updated.

            MDUpdateFull                = 0x00000002,   // "Normal" update mode.

            MDUpdateExtension           = 0x00000003,   // Extension mode.  Tokens don't move, adds only.

            MDUpdateIncremental         = 0x00000004,   // Incremental compilation

            MDUpdateDelta               = 0x00000005,   // If ENC on, save only deltas.

            MDUpdateMask                = 0x00000007,
        }

        // flags used in SetOption when pair with MetaDataErrorIfEmitOutOfOrder guid
        public enum CorErrorIfEmitOutOfOrder : uint
        {
            MDErrorOutOfOrderDefault    = 0x00000000,   // default not to generate any error

            MDErrorOutOfOrderNone       = 0x00000000,   // do not generate error for out of order emit

            MDErrorOutOfOrderAll        = 0xffffffff,   // generate out of order emit for method, field, param, property, and event

            MDMethodOutOfOrder          = 0x00000001,   // generate error when methods are emitted out of order

            MDFieldOutOfOrder           = 0x00000002,   // generate error when fields are emitted out of order

            MDParamOutOfOrder           = 0x00000004,   // generate error when params are emitted out of order

            MDPropertyOutOfOrder        = 0x00000008,   // generate error when properties are emitted out of order

            MDEventOutOfOrder           = 0x00000010,   // generate error when events are emitted out of order
        }

        // flags used in SetOption when pair with MetaDataImportOption guid
        public enum CorImportOptions : uint
        {
            MDImportOptionDefault       = 0x00000000,   // default to skip over deleted records

            MDImportOptionAll           = 0xFFFFFFFF,   // Enumerate everything

            MDImportOptionAllTypeDefs   = 0x00000001,   // all of the typedefs including the deleted typedef

            MDImportOptionAllMethodDefs = 0x00000002,   // all of the methoddefs including the deleted ones

            MDImportOptionAllFieldDefs  = 0x00000004,   // all of the fielddefs including the deleted ones

            MDImportOptionAllProperties = 0x00000008,   // all of the properties including the deleted ones

            MDImportOptionAllEvents     = 0x00000010,   // all of the events including the deleted ones

            MDImportOptionAllCustomAttributes = 0x00000020, // all of the custom attributes including the deleted ones

            MDImportOptionAllExportedTypes  = 0x00000040,   // all of the ExportedTypes including the deleted ones
        }

        // flags for MetaDataThreadSafetyOptions
        public enum CorThreadSafetyOptions : uint
        {
            // default behavior is to have thread safety turn off. This means that MetaData APIs will not take reader/writer
            // lock. Clients is responsible to make sure the properly thread synchornization when using MetaData APIs.
            MDThreadSafetyDefault       = 0x00000000,

            MDThreadSafetyOff           = 0x00000000,

            MDThreadSafetyOn            = 0x00000001,
        }


        // flags for MetaDataLinkerOptions
        public enum CorLinkerOptions : uint
        {
            // default behavior is not to keep private types
            MDAssembly          = 0x00000000,

            MDNetModule         = 0x00000001,
        }

        // flags for MetaDataMergeOptions
        public enum MergeFlags : uint
        {
            MergeFlagsNone      =   0,

            MergeManifest       =   0x00000001,

            DropMemberRefCAs    =   0x00000002,

            NoDupCheck          =   0x00000004,

            MergeExportedTypes  =   0x00000008
        }

        // flags for MetaDataPreserveLocalRefs
        public enum CorLocalRefPreservation : uint
        {
            MDPreserveLocalRefsNone     = 0x00000000,

            MDPreserveLocalTypeRef      = 0x00000001,

            MDPreserveLocalMemberRef    = 0x00000002
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct COR_FIELD_OFFSET
        {
            public mdFieldDef  ridOfField;

            public ulong ulOffset;
        }

        //
        // Token tags.
        //
        public enum CorTokenType : uint
        {
            mdtModule               = 0x00000000,       //

            mdtTypeRef              = 0x01000000,       //

            mdtTypeDef              = 0x02000000,       //

            mdtFieldDef             = 0x04000000,       //

            mdtMethodDef            = 0x06000000,       //

            mdtParamDef             = 0x08000000,       //

            mdtInterfaceImpl        = 0x09000000,       //

            mdtMemberRef            = 0x0a000000,       //

            mdtCustomAttribute      = 0x0c000000,       //

            mdtPermission           = 0x0e000000,       //

            mdtSignature            = 0x11000000,       //

            mdtEvent                = 0x14000000,       //

            mdtProperty             = 0x17000000,       //

            mdtMethodImpl           = 0x19000000,       //

            mdtModuleRef            = 0x1a000000,       //

            mdtTypeSpec             = 0x1b000000,       //

            mdtAssembly             = 0x20000000,       //

            mdtAssemblyRef          = 0x23000000,       //

            mdtFile                 = 0x26000000,       //

            mdtExportedType         = 0x27000000,       //

            mdtManifestResource     = 0x28000000,       //

            mdtGenericParam         = 0x2a000000,       //

            mdtMethodSpec           = 0x2b000000,       //

            mdtGenericParamConstraint = 0x2c000000,

            mdtString               = 0x70000000,       //

            mdtName                 = 0x71000000,       //

            mdtBaseType             = 0x72000000,       // Leave this on the high end value. This does not correspond to metadata table
        }

        //
        // Open bits.
        //
        [Flags]
        public enum CorOpenFlags : uint
        {
            ofRead              =   0x00000000,     // Open scope for read

            ofWrite             =   0x00000001,     // Open scope for write.

            ofReadWriteMask     =   0x00000001,     // Mask for read/write bit.

            ofCopyMemory        =   0x00000002,     // Open scope with memory. Ask metadata to maintain its own copy of memory.

            ofReadOnly          =   0x00000010,     // Open scope for read. Will be unable to QI for a IMetadataEmit* interface

            ofTakeOwnership     =   0x00000020,     // The memory was allocated with CoTaskMemAlloc and will be freed by the metadata

            // These are obsolete and are ignored.
            // ofCacheImage     =   0x00000004,     // EE maps but does not do relocations or verify image
            // ofManifestMetadata = 0x00000008,     // Open scope on ngen image, return the manifest metadata instead of the IL metadata
            ofNoTypeLib         =   0x00000080,     // Don't OpenScope on a typelib.

            ofNoTransform       =   0x00001000,     // Disable automatic transforms of .winmd files.

            // Internal bits
            ofReserved1         =   0x00000100,     // Reserved for internal use.

            ofReserved2         =   0x00000200,     // Reserved for internal use.

            ofReserved3         =   0x00000400,     // Reserved for internal use.

            ofReserved          =   0xffffef40      // All the reserved bits.

        }

        // Note that this must be kept in sync with System.AttributeTargets.
        [Flags]
        public enum CorAttributeTargets : ushort
        {
            catAssembly      = 0x0001,

            catModule        = 0x0002,

            catClass         = 0x0004,

            catStruct        = 0x0008,

            catEnum          = 0x0010,

            catConstructor   = 0x0020,

            catMethod        = 0x0040,

            catProperty      = 0x0080,

            catField         = 0x0100,

            catEvent         = 0x0200,

            catInterface     = 0x0400,

            catParameter     = 0x0800,

            catDelegate      = 0x1000,

            catGenericParameter = 0x4000,

            catAll           = catAssembly | catModule | catClass | catStruct | catEnum | catConstructor | catMethod | catProperty | catField | catEvent | catInterface | catParameter | catDelegate | catGenericParameter,

            catClassMembers  = catClass | catStruct | catEnum | catConstructor | catMethod | catProperty | catField | catEvent | catDelegate | catInterface,

        }


        // Keep in sync with AssemblySettingAttributes.cs

        public enum NGenHintEnum : ushort
        {
            NGenDefault             = 0x0000, // No preference specified

            NGenEager               = 0x0001, // NGen at install time

            NGenLazy                = 0x0002, // NGen after install time

            NGenNever               = 0x0003  // Assembly should not be ngened
        }

        public enum LoadHintEnum : ushort
        {
            LoadDefault             = 0x0000, // No preference specified

            LoadAlways              = 0x0001, // Dependency is always loaded

            LoadSometimes           = 0x0002, // Dependency is sometimes loaded

            LoadNever               = 0x0003  // Dependency is never loaded
        }

        public enum CorSaveSize : ushort
        {
            cssAccurate             = 0x0000,               // Find exact save size, accurate but slower.
            cssQuick                = 0x0001,               // Estimate save size, may pad estimate, but faster.
            cssDiscardTransientCAs  = 0x0002,               // remove all of the CAs of discardable types
        }

        //
        // Enum used with NATIVE_TYPE_ARRAY.
        //
        public enum NativeTypeArrayFlags : ushort
        {
            ntaSizeParamIndexSpecified = 0x0001,
            ntaReserved                = 0xfffe      // All the reserved bits.
        }

        //
        // Enum used for HFA type recognition.
        // Supported across architectures, so that it can be used in altjits and cross-compilation.
        public enum CorInfoHFAElemType : byte
        {
            CORINFO_HFA_ELEM_NONE,

            CORINFO_HFA_ELEM_FLOAT,

            CORINFO_HFA_ELEM_DOUBLE,

            CORINFO_HFA_ELEM_VECTOR64,

            CORINFO_HFA_ELEM_VECTOR128,
        }
    }
}
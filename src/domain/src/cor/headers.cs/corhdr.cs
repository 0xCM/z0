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

    /// <summary>
    /// Transpiled (manually) from corhdr.h
    /// </summary>
    public readonly struct Cor
    {
        public struct mdToken
        {
            uint Value;

            [MethodImpl(Inline)]
            mdToken(uint value)
                => Value = value;

            [MethodImpl(Inline)]
            public static implicit operator uint(mdToken src)
                => src.Value;

            [MethodImpl(Inline)]
            public static implicit operator mdToken(uint src)
                => new mdToken(src);
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

        public const CorCallingConvention IMAGE_CEE_CS_CALLCONV_INSTANTIATION = IMAGE_CEE_CS_CALLCONV_GENERICINST;

        // DESCR group for MethodDefs
        public const byte DESCR_GROUP_METHODDEF = 0;

        // DESCR group for MethodImpls
        public const byte DESCR_GROUP_METHODIMPL = 1;

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

            // every type above PTR will be simple type
            ELEMENT_TYPE_PTR            = 0x0f,     // PTR <type>

            ELEMENT_TYPE_BYREF          = 0x10,     // BYREF <type>

            // Please use ELEMENT_TYPE_VALUETYPE. ELEMENT_TYPE_VALUECLASS is deprecated.
            ELEMENT_TYPE_VALUETYPE      = 0x11,     // VALUETYPE <class Token>

            ELEMENT_TYPE_CLASS          = 0x12,     // CLASS <class Token>

            ELEMENT_TYPE_VAR            = 0x13,     // a class type variable VAR <number>

            ELEMENT_TYPE_ARRAY          = 0x14,     // MDARRAY <type> <rank> <bcount> <bound1> ... <lbcount> <lb1> ...

            ELEMENT_TYPE_GENERICINST    = 0x15,     // GENERICINST <generic type> <argCnt> <arg1> ... <argn>

            ELEMENT_TYPE_TYPEDBYREF     = 0x16,     // TYPEDREF  (it takes no args) a typed referece to some other type

            ELEMENT_TYPE_I              = 0x18,     // native integer size

            ELEMENT_TYPE_U              = 0x19,     // native unsigned integer size

            ELEMENT_TYPE_FNPTR          = 0x1b,     // FNPTR <complete sig for the function including calling convention>

            ELEMENT_TYPE_OBJECT         = 0x1c,     // Shortcut for System.Object

            ELEMENT_TYPE_SZARRAY        = 0x1d,     // Shortcut for single dimension zero lower bound array
                                                    // SZARRAY <type>
            ELEMENT_TYPE_MVAR           = 0x1e,     // a method type variable MVAR <number>

            // This is only for binding
            ELEMENT_TYPE_CMOD_REQD      = 0x1f,     // required C modifier : E_T_CMOD_REQD <mdTypeRef/mdTypeDef>

            ELEMENT_TYPE_CMOD_OPT       = 0x20,     // optional C modifier : E_T_CMOD_OPT <mdTypeRef/mdTypeDef>

            // This is for signatures generated internally (which will not be persisted in any way).
            ELEMENT_TYPE_INTERNAL       = 0x21,     // INTERNAL <typehandle>

            // Note that this is the max of base type excluding modifiers
            ELEMENT_TYPE_MAX            = 0x22,     // first invalid element type


            ELEMENT_TYPE_MODIFIER       = 0x40,
            ELEMENT_TYPE_SENTINEL       = 0x01 | ELEMENT_TYPE_MODIFIER, // sentinel for varargs
            ELEMENT_TYPE_PINNED         = 0x05 | ELEMENT_TYPE_MODIFIER,
        }


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

            SERIALIZATION_TYPE_SZARRAY      = ELEMENT_TYPE_SZARRAY, // Shortcut for single dimension zero lower bound array

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

            IMAGE_CEE_CS_CALLCONV_UNMANAGED     = 0x9,  // Unmanaged calling convention encoded as modopts

            IMAGE_CEE_CS_CALLCONV_GENERICINST   = 0xa,  // generic method instantiation

            IMAGE_CEE_CS_CALLCONV_NATIVEVARARG  = 0xb,  // used ONLY for 64bit vararg PInvoke calls

            IMAGE_CEE_CS_CALLCONV_MAX           = 0xc,  // first invalid calling convention


            // The high bits of the calling convention convey additional info
            IMAGE_CEE_CS_CALLCONV_MASK      = 0x0f,  // Calling convention is bottom 4 bits

            IMAGE_CEE_CS_CALLCONV_HASTHIS   = 0x20,  // Top bit indicates a 'this' parameter

            IMAGE_CEE_CS_CALLCONV_EXPLICITTHIS = 0x40,  // This parameter is explicitly in the signature

            IMAGE_CEE_CS_CALLCONV_GENERIC   = 0x10,  // Generic method sig with explicit number of type arguments (precedes ordinary parameter count)
            // 0x80 is reserved for internal use
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


        public enum CorNativeType : byte
        {

            // Kepp this in-synch with ndp\clr\src\BCL\System\runtime\interopservices\attributes.cs
            NATIVE_TYPE_END         = 0x0,    //DEPRECATED

            NATIVE_TYPE_VOID        = 0x1,    //DEPRECATED

            NATIVE_TYPE_BOOLEAN     = 0x2,    // (4 byte boolean value: TRUE = non-zero, FALSE = 0)

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

            NATIVE_TYPE_SYSCHAR     = 0xd,    //DEPRECATED

            NATIVE_TYPE_VARIANT     = 0xe,    //DEPRECATED

            NATIVE_TYPE_CURRENCY    = 0xf,

            NATIVE_TYPE_PTR         = 0x10,   //DEPRECATED

            NATIVE_TYPE_DECIMAL     = 0x11,   //DEPRECATED

            NATIVE_TYPE_DATE        = 0x12,   //DEPRECATED

            NATIVE_TYPE_BSTR        = 0x13,   //COMINTEROP

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

            NATIVE_TYPE_NESTEDSTRUCT  = 0x21, //DEPRECATED (use NATIVE_TYPE_STRUCT)

            NATIVE_TYPE_BYVALSTR    = 0x22,   //COMINTEROP

            NATIVE_TYPE_ANSIBSTR    = 0x23,   //COMINTEROP

            NATIVE_TYPE_TBSTR       = 0x24, // select BSTR or ANSIBSTR depending on platform
                                            //COMINTEROP

            NATIVE_TYPE_VARIANTBOOL = 0x25, // (2-byte boolean value: TRUE = -1, FALSE = 0)
                                            //COMINTEROP
            NATIVE_TYPE_FUNC        = 0x26,

            NATIVE_TYPE_ASANY       = 0x28,

            NATIVE_TYPE_ARRAY       = 0x2a,
            NATIVE_TYPE_LPSTRUCT    = 0x2b,

            NATIVE_TYPE_CUSTOMMARSHALER = 0x2c,  // Custom marshaler native type. This must be followed
                                                // by a string of the following format:
                                                // "Native type name/0Custom marshaler type name/0Optional cookie/0"
                                                // Or
                                                // "{Native type GUID}/0Custom marshaler type name/0Optional cookie/0"
            NATIVE_TYPE_ERROR       = 0x2d, // This native type coupled with ELEMENT_TYPE_I4 will map to VT_HRESULT
                                            //COMINTEROP

            NATIVE_TYPE_IINSPECTABLE = 0x2e,

            NATIVE_TYPE_HSTRING     = 0x2f,

            NATIVE_TYPE_LPUTF8STR   = 0x30, // utf-8 string

            NATIVE_TYPE_MAX         = 0x50, // first invalid element type
        }


        /***********************************************************************************/
        // a COR_ILMETHOD_SECT is a generic container for attributes that are private
        // to a particular method.  The COR_ILMETHOD structure points to one of these
        // (see GetSect()).  COR_ILMETHOD_SECT can decode the Kind of attribute (but not
        // its internal data layout, and can skip past the current attibute to find the
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
        public struct IMAGE_COR_ILMETHOD_SECT_SMALL
        {
            public byte Kind;

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
        */
        public enum CorExceptionFlag : byte                       // definitions for the Flags field below (for both big and small)
        {
            COR_ILEXCEPTION_CLAUSE_NONE,                    // This is a typed handler
            COR_ILEXCEPTION_CLAUSE_OFFSETLEN = 0x0000,      // Deprecated
            COR_ILEXCEPTION_CLAUSE_DEPRECATED = 0x0000,     // Deprecated
            COR_ILEXCEPTION_CLAUSE_FILTER  = 0x0001,        // If this bit is on, then this EH entry is for a filter
            COR_ILEXCEPTION_CLAUSE_FINALLY = 0x0002,        // This clause is a finally clause
            COR_ILEXCEPTION_CLAUSE_FAULT = 0x0004,          // Fault clause (finally that is called on exception only)
            COR_ILEXCEPTION_CLAUSE_DUPLICATED = 0x0008,     // duplicated clause. This clause was duplicated to a funclet which was pulled out of line
        }

    }
}
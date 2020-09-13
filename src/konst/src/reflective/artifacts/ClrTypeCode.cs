//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    using SRM = System.Reflection.Metadata;

    public readonly partial struct ClrTables
    {

    }

    /// <summary>
    /// Represents the type codes that are used in signature encoding.
    /// </summary>
    public enum ClrTypeCode :  uint
    {
        /// <summary>
        /// Represents an invalid or uninitialized type code. It will not appear in valid signatures.
        /// </summary>
        None = 0x0,

        /// <summary>
        /// Identifies <see cref="System.Void"/>
        /// </summary>
        Void = 0x1,

        /// <summary>
        /// Identifies <see cref="bool"/>
        /// </summary>
        Bool8 = 0x02,

        /// <summary>
        /// Identifies <see cref="char"/>
        /// </summary>
        Char16 = CorElementType.ELEMENT_TYPE_CHAR,

        /// <summary>
        /// Identifies <see cref="sbyte"/>
        /// </summary>
        Int8i = CorElementType.ELEMENT_TYPE_I1,

        /// <summary>
        /// Identifies <see cref="byte"/>
        /// </summary>
        Int8u = CorElementType.ELEMENT_TYPE_U1,

        /// <summary>
        /// Identifies <see cref="short"/>
        /// </summary>
        Int16i = CorElementType.ELEMENT_TYPE_I2,

        /// <summary>
        /// Identifies <see cref="ushort"/>
        /// </summary>
        Int16u = CorElementType.ELEMENT_TYPE_U2,

        /// <summary>
        /// Identifies <see cref="ValueType"/>
        /// </summary>
        Struct = CorElementType.ELEMENT_TYPE_VALUETYPE,

        /// <summary>
        /// Identifies a class
        /// </summary>
        Class = CorElementType.ELEMENT_TYPE_CLASS,

        /// <summary>
        /// Identifies <see cref="int"/>
        /// </summary>
        Int32i = CorElementType.ELEMENT_TYPE_I4,

        /// <summary>
        /// Identifies <see cref="uint"/>
        /// </summary>
        Int32u = CorElementType.ELEMENT_TYPE_U4,

        /// <summary>
        /// Identifies <see cref="long"/>
        /// </summary>
        Int64i = CorElementType.ELEMENT_TYPE_I8,

        /// <summary>
        /// Identifies <see cref="ulong"/>
        /// </summary>
        Int64u = CorElementType.ELEMENT_TYPE_U8,

        /// <summary>
        /// Identifies <see cref="float"/>
        /// </summary>
        Float32 = CorElementType.ELEMENT_TYPE_R4,

        /// <summary>
        /// Represents <see cref="double"/>
        /// </summary>
        Float64 = CorElementType.ELEMENT_TYPE_R8,

        /// <summary>
        /// Represents <see cref="string"/>
        /// </summary>
        String = CorElementType.ELEMENT_TYPE_STRING,

        /// <summary>
        /// Represents a unmanaged pointers in signatures. It is followed in the blob by the signature encoding of the underlying type.
        /// </summary>
        Ptr = CorElementType.ELEMENT_TYPE_PTR, // PTR <type>

        /// <summary>
        /// Represents managed pointers (byref return values and parameters) in signatures. It is followed in the blob by the signature encoding of the underlying type.
        /// </summary>
        Ref = CorElementType.ELEMENT_TYPE_BYREF, // BYREF <type>

        // ELEMENT_TYPE_VALUETYPE (0x11) and ELEMENT_TYPE_CLASS (0x12) are unified to ELEMENT_TYPE_HANDLE.

        /// <summary>
        /// Represents a generic type parameter used within a signature.
        /// </summary>
        TypeParameter = CorElementType.ELEMENT_TYPE_VAR, // a class type variable VAR <U1>

        /// <summary>
        /// Identifies an <see cref="System.Array"/> of arbitrary dimension/rank
        /// </summary>
        Array = CorElementType.ELEMENT_TYPE_ARRAY, // MDARRAY <type> <rank> <bcount> <bound1> ... <lbcount> <lb1> ...

        /// <summary>
        /// Identifies a generic closure
        /// </summary>
        GenericClosure = CorElementType.ELEMENT_TYPE_GENERICINST, // GENERICINST <generic type> <argCnt> <arg1> ... <argn>

        /// <summary>
        /// Identifies a <see cref='System.TypedReference'/>
        /// </summary>
        TypedReference = CorElementType.ELEMENT_TYPE_TYPEDBYREF, // TYPEDREF  (it takes no args) a typed reference to some other type

        /// <summary>
        /// Identifies a <see cref="System.IntPtr"/>.
        /// </summary>
        IntI = CorElementType.ELEMENT_TYPE_I,

        /// <summary>
        /// Identifies a <see cref="System.UIntPtr"/>.
        /// </summary>
        IntU = CorElementType.ELEMENT_TYPE_U,

        /// <summary>
        /// Represents function pointer types in signatures.
        /// </summary>
        PtrFx = CorElementType.ELEMENT_TYPE_FNPTR, // FNPTR <complete sig for the function including calling convention>

        /// <summary>
        /// Represents <see cref="object"/>
        /// </summary>
        Object = CorElementType.ELEMENT_TYPE_OBJECT,

        /// <summary>
        /// Identifies a 0-based single dimensional <see cref="System.Array"/>
        /// </summary>
        Cells = CorElementType.ELEMENT_TYPE_SZARRAY,

        /// <summary>
        /// Identifies a generic method parameter
        /// </summary>
        MethodTypeParameter = CorElementType.ELEMENT_TYPE_MVAR, // a method type variable MVAR <U1>

        /// <summary>
        /// Represents a custom modifier applied to a type within a signature that the caller must understand.
        /// </summary>
        Required = CorElementType.ELEMENT_TYPE_CMOD_REQD, // required C modifier : E_T_CMOD_REQD <mdTypeRef/mdTypeDef>

        /// <summary>
        /// Represents a custom modifier applied to a type within a signature that the caller can ignore.
        /// </summary>
        Optional = CorElementType.ELEMENT_TYPE_CMOD_OPT, // optional C modifier : E_T_CMOD_OPT <mdTypeRef/mdTypeDef>

        /// <summary>
        /// Precedes a type <see cref="SRM.EntityHandle"/> in signatures.
        /// </summary>
        /// <remarks>
        /// In raw metadata, this will be encoded as either ELEMENT_TYPE_CLASS (0x12) for reference
        /// types and ELEMENT_TYPE_VALUETYPE (0x11) for value types. This is collapsed to a single
        /// code because Windows Runtime projections can project from class to value type or vice-versa
        /// and the raw code is misleading in those cases.
        /// </remarks>
        TypeHandle = CorElementType.ELEMENT_TYPE_HANDLE, // CLASS | VALUETYPE <class Token>

        /// <summary>
        /// Identifies a marker to indicate the end of fixed arguments and the beginning of variable arguments.
        /// </summary>
        Sentinel = CorElementType.ELEMENT_TYPE_SENTINEL,

        /// <summary>
        /// Identifies a local variable that is pinned by garbage collector
        /// </summary>
        Pinned = CorElementType.ELEMENT_TYPE_PINNED,
    }
}
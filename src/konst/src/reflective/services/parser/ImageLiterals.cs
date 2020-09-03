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
    using System.Diagnostics;

    readonly struct ImageLiterals
    {
        public const int IMAGE_CEE_CS_CALLCONV_DEFAULT = 0x0;

        public const int IMAGE_CEE_CS_CALLCONV_VARARG = 0x5;

        public const int IMAGE_CEE_CS_CALLCONV_FIELD = 0x6;

        public const int IMAGE_CEE_CS_CALLCONV_LOCAL_SIG = 0x7;

        public const int IMAGE_CEE_CS_CALLCONV_PROPERTY = 0x8;

        public const int IMAGE_CEE_CS_CALLCONV_UNMGD = 0x9;

        public const int IMAGE_CEE_CS_CALLCONV_GENERICINST = 0xa;

        public const int IMAGE_CEE_CS_CALLCONV_NATIVEVARARG = 0xb;

        public const int IMAGE_CEE_CS_CALLCONV_MAX = 0xc;

        public const int IMAGE_CEE_CS_CALLCONV_MASK = 0x0f;

        public const int IMAGE_CEE_CS_CALLCONV_HASTHIS = 0x20;

        public const int IMAGE_CEE_CS_CALLCONV_EXPLICITTHIS = 0x40;

        public const int IMAGE_CEE_CS_CALLCONV_GENERIC = 0x10;

        public const int ELEMENT_TYPE_END = 0x0;

        public const int ELEMENT_TYPE_VOID = 0x1;

        public const int ELEMENT_TYPE_BOOLEAN = 0x2;

        public const int ELEMENT_TYPE_CHAR = 0x3;

        public const int ELEMENT_TYPE_I1 = 0x4;

        public const int ELEMENT_TYPE_U1 = 0x5;

        public const int ELEMENT_TYPE_I2 = 0x6;

        public const int ELEMENT_TYPE_U2 = 0x7;

        public const int ELEMENT_TYPE_I4 = 0x8;

        public const int ELEMENT_TYPE_U4 = 0x9;

        public const int ELEMENT_TYPE_I8 = 0xa;

        public const int ELEMENT_TYPE_U8 = 0xb;

        public const int ELEMENT_TYPE_R4 = 0xc;

        public const int ELEMENT_TYPE_R8 = 0xd;

        public const int ELEMENT_TYPE_STRING = 0xe;

        public const int ELEMENT_TYPE_PTR = 0xf;

        public const int ELEMENT_TYPE_BYREF = 0x10;

        public const int ELEMENT_TYPE_VALUETYPE = 0x11;

        public const int ELEMENT_TYPE_CLASS = 0x12;

        public const int ELEMENT_TYPE_VAR = 0x13;

        public const int ELEMENT_TYPE_ARRAY = 0x14;

        public const int ELEMENT_TYPE_GENERICINST = 0x15;

        public const int ELEMENT_TYPE_TYPEDBYREF = 0x16;

        public const int ELEMENT_TYPE_I = 0x18;

        public const int ELEMENT_TYPE_U = 0x19;

        public const int ELEMENT_TYPE_FNPTR = 0x1B;

        public const int ELEMENT_TYPE_OBJECT = 0x1C;

        public const int ELEMENT_TYPE_SZARRAY = 0x1D;

        public const int ELEMENT_TYPE_MVAR = 0x1e;

        public const int ELEMENT_TYPE_CMOD_REQD = 0x1F;

        public const int ELEMENT_TYPE_CMOD_OPT = 0x20;

        public const int ELEMENT_TYPE_INTERNAL = 0x21;

        public const int ELEMENT_TYPE_MAX = 0x22;

        public const int ELEMENT_TYPE_MODIFIER = 0x40;

        public const int ELEMENT_TYPE_SENTINEL = 0x01 | ELEMENT_TYPE_MODIFIER;

        public const int ELEMENT_TYPE_PINNED = 0x05 | ELEMENT_TYPE_MODIFIER;

   public const int mdtModule = 0x00000000;

        public const int mdtTypeRef = 0x01000000;

        public const int mdtTypeDef = 0x02000000;

        public const int mdtFieldDef = 0x04000000;

        public const int mdtMethodDef = 0x06000000;

        public const int mdtParamDef = 0x08000000;

        public const int mdtInterfaceImpl = 0x09000000;

        public const int mdtMemberRef = 0x0a000000;

        public const int mdtCustomAttribute = 0x0c000000;

        public const int mdtPermission = 0x0e000000;

        public const int mdtSignature = 0x11000000;

        public const int mdtEvent = 0x14000000;

        public const int mdtProperty = 0x17000000;

        public const int mdtMethodImpl = 0x19000000;

        public const int mdtModuleRef = 0x1a000000;

        public const int mdtTypeSpec = 0x1b000000;

        public const int mdtAssembly = 0x20000000;

        public const int mdtAssemblyRef = 0x23000000;

        public const int mdtFile = 0x26000000;

        public const int mdtExportedType = 0x27000000;

        public const int mdtManifestResource = 0x28000000;

        public const int mdtGenericParam = 0x2a000000;

        public const int mdtMethodSpec = 0x2b000000;

        public const int mdtGenericParamConstraint = 0x2c000000;

        public const int mdtString = 0x70000000;

        public const int mdtName = 0x71000000;

        public const int mdtBaseType = 0x72000000; // Leave this on the high end value. This does not correspond to metadata table
    }
}
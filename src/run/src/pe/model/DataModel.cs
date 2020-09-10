// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
namespace Z0.DataModels.Pe
{
    using System;
    using System.Runtime.CompilerServices;

    using System.Collections.Generic;
    using System.Text;
    using System.IO;
    using System.Diagnostics;

    using SH = SigHeaderCode;
    using CA = CustomAttributeCode;

    public readonly struct SignatureHeader
    {
        public const byte DefaultCall = 0x00;

        public const byte CCall = 0x01;

        public const byte StdCall = 0x02;

        public const byte ThisCall = 0x03;

        public const byte FastCall = 0x04;

        public const byte VarArgCall = 0x05;

        public const byte Field = 0x06;

        public const byte LocalVar = 0x07;

        public const byte Property = 0x08;

        public const byte GenericInstance = 0x0A;

        public const byte Max = 0x0C;

        public const byte CallingConventionMask = 0x0F;

        public const byte HasThis = 0x20;

        public const byte ExplicitThis = 0x40;

        public const byte Generic = 0x10;

        public const byte SignatureHeaderMask = 0x7F;

        public static bool IsMethodSignature(byte src) {
            return ((SH)src & SH.CallingConventionMask) <= SH.VarArgCall;
        }
        public static bool IsVarArgCallSignature(
            byte src
        ) {
            return ((SH)src & SH.CallingConventionMask) == SH.VarArgCall;
        }
        public static bool IsFieldSignature(
            byte src
        ) {
            return ((SH)src & SH.CallingConventionMask) == SH.Field;
        }
        public static bool IsLocalVarSignature(
            byte src
        ) {
            return ((SH)src & SH.CallingConventionMask) == SH.LocalVar;
        }
        public static bool IsPropertySignature(
            byte src
        ) {
            return ((SH)src & SH.CallingConventionMask) == SH.Property;
        }
        public static bool IsGenericInstanceSignature(
            byte src
        ) {
            return ((SH)src & SH.CallingConventionMask) == SH.GenericInstance;
        }
        public static bool IsExplicitThis(
            byte src
        ) {
            return ((SH)src & SH.ExplicitThis) == SH.ExplicitThis;
        }
        public static bool IsGeneric(byte src) {
            return ((SH)src & SH.Generic) == SH.Generic;
        }
        }

        public unsafe struct MemoryBlock
        {
            public byte* Buffer;

            public int Length;

            public MemoryBlock(byte* buffer,int length)
            {
                this.Buffer = buffer;
                this.Length = length;
            }

            public MemoryBlock(byte* buffer,uint length)
            {
                this.Buffer = buffer;
                this.Length = (int)length;
            }
        }

        public struct SubSection
        {
            public string SectionName;

            public uint Offset;

            public MemoryBlock MemoryBlock;
        }


        public readonly struct TypeDefOrRefTag
        {
            public const int NumberOfBits = 2;

            public const uint LargeRowSize = 0x00000001 << (16 - TypeDefOrRefTag.NumberOfBits);

            public const uint TypeDef = 0x00000000;

            public const uint TypeRef = 0x00000001;

            public const uint TypeSpec = 0x00000002;

            public const uint TagMask = 0x00000003;

            public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.TypeDef, TokenTypeIds.TypeRef, TokenTypeIds.TypeSpec };

            public const TableMask TablesReferenced = TableMask.TypeDef | TableMask.TypeRef | TableMask.TypeSpec;

            public static uint ConvertToToken(uint typeDefOrRefTag) {

            return (uint)TypeDefOrRefTag.TagToTokenTypeArray[typeDefOrRefTag & TypeDefOrRefTag.TagMask] | typeDefOrRefTag >> TypeDefOrRefTag.NumberOfBits;
            }
    }

    public readonly struct HasConstantTag
    {
        public const int NumberOfBits = 2;

        public const uint LargeRowSize = 0x00000001 << (16 - HasConstantTag.NumberOfBits);

        public const uint Field = 0x00000000;

        public const uint Param = 0x00000001;

        public const uint Property = 0x00000002;

        public const uint TagMask = 0x00000003;

        public const TableMask TablesReferenced = TableMask.Field | TableMask.Param | TableMask.Property;

        public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.FieldDef, TokenTypeIds.ParamDef, TokenTypeIds.Property };

        public static uint ConvertToToken(uint hasConstant)
        {
            return (uint)HasConstantTag.TagToTokenTypeArray[hasConstant & HasConstantTag.TagMask] | hasConstant >> HasConstantTag.NumberOfBits;
        }

        public static uint ConvertToTag(uint token)
        {
            uint tokenKind = token & (uint)TokenTypeIds.TokenTypeMask;
            uint rowId = token & (uint)TokenTypeIds.RIDMask;
            if (tokenKind == (uint)TokenTypeIds.FieldDef) {
            return rowId << HasConstantTag.NumberOfBits | HasConstantTag.Field;
            } else if (tokenKind == (uint)TokenTypeIds.ParamDef) {
            return rowId << HasConstantTag.NumberOfBits | HasConstantTag.Param;
            } else if (tokenKind == (uint)TokenTypeIds.Property) {
            return rowId << HasConstantTag.NumberOfBits | HasConstantTag.Property;
            }
            return 0;
        }
    }

    public enum CustomAttributeCode : uint
    {
        NumberOfBits = 2,

        Method = 0x00000000,

        Field = 0x00000001,

        TypeRef = 0x00000002,

        TypeDef = 0x00000003,

        Param = 0x00000004,

        InterfaceImpl = 0x00000005,

        MemberRef = 0x00000006,

        Module = 0x00000007,

        DeclSecurity = 0x00000008,

        Property = 0x00000009,

        Event = 0x0000000A,

        StandAloneSig = 0x0000000B,

        ModuleRef = 0x0000000C,

        TypeSpec = 0x0000000D,

        Assembly = 0x0000000E,

        AssemblyRef = 0x0000000F,

        File = 0x00000010,

        ExportedType = 0x00000011,

        ManifestResource = 0x00000012,

        GenericParameter = 0x00000013,

        GenericParameterConstraint = 0x00000014,

        MethodSpec = 0x00000015,
    }


    public readonly struct HasCustomAttributeTag
    {
        public const int NumberOfBits = 5;

        public const uint LargeRowSize = 0x00000001 << (16 - HasCustomAttributeTag.NumberOfBits);

        public const uint Method = 0x00000000;

        public const uint Field = 0x00000001;

        public const uint TypeRef = 0x00000002;

        public const uint TypeDef = 0x00000003;

        public const uint Param = 0x00000004;

        public const uint InterfaceImpl = 0x00000005;

        public const uint MemberRef = 0x00000006;

        public const uint Module = 0x00000007;

        public const uint DeclSecurity = 0x00000008;

        public const uint Property = 0x00000009;

        public const uint Event = 0x0000000A;

        public const uint StandAloneSig = 0x0000000B;

        public const uint ModuleRef = 0x0000000C;

        public const uint TypeSpec = 0x0000000D;

        public const uint Assembly = 0x0000000E;

        public const uint AssemblyRef = 0x0000000F;

        public const uint File = 0x00000010;

        public const uint ExportedType = 0x00000011;

        public const uint ManifestResource = 0x00000012;

        public const uint GenericParameter = 0x00000013;

        public const uint GenericParameterConstraint = 0x00000014;

        public const uint MethodSpec = 0x00000015;

        public const uint TagMask = 0x0000001F;

        public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.MethodDef, TokenTypeIds.FieldDef, TokenTypeIds.TypeRef, TokenTypeIds.TypeDef, TokenTypeIds.ParamDef,
            TokenTypeIds.InterfaceImpl, TokenTypeIds.MemberRef, TokenTypeIds.Module, TokenTypeIds.Permission, TokenTypeIds.Property, TokenTypeIds.Event,
            TokenTypeIds.Signature, TokenTypeIds.ModuleRef, TokenTypeIds.TypeSpec, TokenTypeIds.Assembly, TokenTypeIds.AssemblyRef, TokenTypeIds.File, TokenTypeIds.ExportedType,
            TokenTypeIds.ManifestResource, TokenTypeIds.GenericParam, TokenTypeIds.GenericParamConstraint, TokenTypeIds.MethodSpec };

        public const TableMask TablesReferenced = TableMask.Method
            | TableMask.Field
            | TableMask.TypeRef
            | TableMask.TypeDef
            | TableMask.Param
            | TableMask.InterfaceImpl
            | TableMask.MemberRef
            | TableMask.Module
            | TableMask.DeclSecurity
            | TableMask.Property
            | TableMask.Event
            | TableMask.StandAloneSig
            | TableMask.ModuleRef
            | TableMask.TypeSpec
            | TableMask.Assembly
            | TableMask.AssemblyRef
            | TableMask.File
            | TableMask.ExportedType
            | TableMask.ManifestResource
            | TableMask.GenericParam
            | TableMask.GenericParamConstraint
            | TableMask.MethodSpec;

        public static uint ConvertToToken(uint hasCustomAttribute)
        {
            return (uint)HasCustomAttributeTag.TagToTokenTypeArray[hasCustomAttribute & HasCustomAttributeTag.TagMask] | hasCustomAttribute >> HasCustomAttributeTag.NumberOfBits;
        }

        public static CA ConvertToTag(uint token)
        {
            var tokenType = (TokenTypeIds)(token & (uint)TokenTypeIds.TokenTypeMask);
            var rowId = token & (uint)TokenTypeIds.RIDMask;
            var shift = (CA)(rowId << 2);
            CA result = tokenType switch {
                TokenTypeIds.MethodDef => shift | CA.Method,
                TokenTypeIds.FieldDef =>  shift | CA.Field,
                TokenTypeIds.TypeRef => shift | CA.TypeRef,
                TokenTypeIds.TypeDef => shift | CA.TypeDef,
                TokenTypeIds.ParamDef => shift | CA.Param,
                TokenTypeIds.InterfaceImpl => shift | CA.InterfaceImpl,
                TokenTypeIds.MemberRef => shift | CA.MemberRef,
                TokenTypeIds.Module => shift | CA.Module,
                TokenTypeIds.Permission => shift | CA.DeclSecurity,
                TokenTypeIds.Property => shift | CA.Property,
                TokenTypeIds.Event => shift | CA.Event,
                TokenTypeIds.Signature => shift | CA.StandAloneSig,
                TokenTypeIds.ModuleRef => shift | CA.ModuleRef,
                TokenTypeIds.TypeSpec => shift | CA.TypeSpec,
                TokenTypeIds.Assembly => shift | CA.Assembly,
                TokenTypeIds.AssemblyRef => shift | CA.AssemblyRef,
                TokenTypeIds.File => shift | CA.File,
                TokenTypeIds.ExportedType => shift | CA.ExportedType,
                TokenTypeIds.ManifestResource => shift | CA.ManifestResource,
                TokenTypeIds.GenericParam => shift | CA.GenericParameter,
                TokenTypeIds.GenericParamConstraint => shift | CA.GenericParameterConstraint,
                TokenTypeIds.MethodSpec => shift | CA.MethodSpec,
                 _ => 0
            };

            return result;
        }
    }

    public readonly struct HasFieldMarshalTag
    {
        public const int NumberOfBits = 1;

        public const uint LargeRowSize = 0x00000001 << (16 - HasFieldMarshalTag.NumberOfBits);

        public const uint Field = 0x00000000;

        public const uint Param = 0x00000001;

        public const uint TagMask = 0x00000001;

        public const TableMask TablesReferenced = TableMask.Field | TableMask.Param;

        public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.FieldDef, TokenTypeIds.ParamDef };

        public static uint ConvertToToken(uint hasFieldMarshal)
        {
            return (uint)HasFieldMarshalTag.TagToTokenTypeArray[hasFieldMarshal & HasFieldMarshalTag.TagMask] | hasFieldMarshal >> HasFieldMarshalTag.NumberOfBits;
        }

        public static uint ConvertToTag(uint token)
        {
            var tokenKind = token & (uint)TokenTypeIds.TokenTypeMask;
            var rowId = token & (uint)TokenTypeIds.RIDMask;
            if (tokenKind == (uint)TokenTypeIds.FieldDef)
                return rowId << HasFieldMarshalTag.NumberOfBits | HasFieldMarshalTag.Field;
            else if (tokenKind == (uint)TokenTypeIds.ParamDef)
                return rowId << HasFieldMarshalTag.NumberOfBits | HasFieldMarshalTag.Param;
            else
                return 0;
        }
    }

    public readonly struct HasDeclSecurityTag
    {
        public const int NumberOfBits = 2;

        public const uint LargeRowSize = 0x00000001 << (16 - HasDeclSecurityTag.NumberOfBits);

        public const uint TypeDef = 0x00000000;

        public const uint Method = 0x00000001;

        public const uint Assembly = 0x00000002;

        public const uint TagMask = 0x00000003;

        public const TableMask TablesReferenced = TableMask.TypeDef | TableMask.Method  | TableMask.Assembly;

        public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.TypeDef, TokenTypeIds.MethodDef, TokenTypeIds.Assembly };

        public static uint ConvertToToken(uint hasDeclSecurity) {
            return (uint)HasDeclSecurityTag.TagToTokenTypeArray[hasDeclSecurity & HasDeclSecurityTag.TagMask] | hasDeclSecurity >> HasDeclSecurityTag.NumberOfBits;
        }
        public static uint ConvertToTag(uint token)
        {
            uint tokenKind = token & (uint)TokenTypeIds.TokenTypeMask;
            uint rowId = token & (uint)TokenTypeIds.RIDMask;
            if (tokenKind == (uint)TokenTypeIds.TypeDef) {
            return rowId << HasDeclSecurityTag.NumberOfBits | HasDeclSecurityTag.TypeDef;
            } else if (tokenKind == (uint)TokenTypeIds.MethodDef) {
            return rowId << HasDeclSecurityTag.NumberOfBits | HasDeclSecurityTag.Method;
            } else if (tokenKind == (uint)TokenTypeIds.Assembly) {
            return rowId << HasDeclSecurityTag.NumberOfBits | HasDeclSecurityTag.Assembly;
            }
            return 0;
        }
    }

    public readonly struct MemberRefParentTag
    {
        public const int NumberOfBits = 3;

        public const uint LargeRowSize = 0x00000001 << (16 - MemberRefParentTag.NumberOfBits);

        public const uint TypeDef = 0x00000000;

        public const uint TypeRef = 0x00000001;

        public const uint ModuleRef = 0x00000002;

        public const uint Method = 0x00000003;

        public const uint TypeSpec = 0x00000004;

        public const uint TagMask = 0x00000007;

        public const TableMask TablesReferenced = TableMask.TypeDef
            | TableMask.TypeRef
            | TableMask.ModuleRef
            | TableMask.Method
            | TableMask.TypeSpec;

        public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.TypeDef, TokenTypeIds.TypeRef, TokenTypeIds.ModuleRef,
            TokenTypeIds.MethodDef, TokenTypeIds.TypeSpec };
        public static uint ConvertToToken(uint memberRef) {
            return (uint)MemberRefParentTag.TagToTokenTypeArray[memberRef & MemberRefParentTag.TagMask] | memberRef >> MemberRefParentTag.NumberOfBits;
        }
    }

    public static class HasSemanticsTag
    {
        public const int NumberOfBits = 1;

        public const uint LargeRowSize = 0x00000001 << (16 - HasSemanticsTag.NumberOfBits);

        public const uint Event = 0x00000000;

        public const uint Property = 0x00000001;

        public const uint TagMask = 0x00000001;

        public const TableMask TablesReferenced = TableMask.Event | TableMask.Property;

        public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.Event, TokenTypeIds.Property };

        public static uint ConvertToToken(uint hasSemantic) {
        return (uint)HasSemanticsTag.TagToTokenTypeArray[hasSemantic & HasSemanticsTag.TagMask] | hasSemantic >> HasSemanticsTag.NumberOfBits;
        }
        public static uint ConvertEventRowIdToTag(uint eventRowId) {
        return eventRowId << HasSemanticsTag.NumberOfBits | HasSemanticsTag.Event;
        }
        public static uint ConvertPropertyRowIdToTag(uint propertyRowId) {
        return propertyRowId << HasSemanticsTag.NumberOfBits | HasSemanticsTag.Property;
        }
    }

    public readonly struct MethodDefOrRefTag
    {
        public const int NumberOfBits = 1;

        public const uint LargeRowSize = 0x00000001 << (16 - MethodDefOrRefTag.NumberOfBits);

        public const uint Method = 0x00000000;

        public const uint MemberRef = 0x00000001;

        public const uint TagMask = 0x00000001;

        public const TableMask TablesReferenced = TableMask.Method | TableMask.MemberRef;

        public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.MethodDef, TokenTypeIds.MemberRef };

        public static uint ConvertToToken(uint methodDefOrRef)
        {
            return (uint)MethodDefOrRefTag.TagToTokenTypeArray[methodDefOrRef & MethodDefOrRefTag.TagMask] | methodDefOrRef >> MethodDefOrRefTag.NumberOfBits;
        }
    }

    public static class MemberForwardedTag
    {
        public const int NumberOfBits = 1;

        public const uint LargeRowSize = 0x00000001 << (16 - MemberForwardedTag.NumberOfBits);

        public const uint Field = 0x00000000;

        public const uint Method = 0x00000001;

        public const uint TagMask = 0x00000001;

        public const TableMask TablesReferenced =
            TableMask.Field
            | TableMask.Method;
        public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.FieldDef, TokenTypeIds.MethodDef };
        public static uint ConvertToToken(uint memberForwarded) {
            return (uint)MemberForwardedTag.TagToTokenTypeArray[memberForwarded & MethodDefOrRefTag.TagMask] | memberForwarded >> MethodDefOrRefTag.NumberOfBits;
        }
        public static uint ConvertMethodDefRowIdToTag(uint methodDefRowId) {
            return methodDefRowId << MemberForwardedTag.NumberOfBits | MemberForwardedTag.Method;
        }
    }

    public static class ImplementationTag
    {
        public const int NumberOfBits = 2;

        public const uint LargeRowSize = 0x00000001 << (16 - ImplementationTag.NumberOfBits);

        public const uint File = 0x00000000;

        public const uint AssemblyRef = 0x00000001;

        public const uint ExportedType = 0x00000002;

        public const uint TagMask = 0x00000003;

        public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.File, TokenTypeIds.AssemblyRef, TokenTypeIds.ExportedType };

        public const TableMask TablesReferenced = TableMask.File | TableMask.AssemblyRef | TableMask.ExportedType;

        public static uint ConvertToToken(uint implementation)
        {
            if (implementation == 0) return 0;
            return (uint)ImplementationTag.TagToTokenTypeArray[implementation & ImplementationTag.TagMask] | implementation >> ImplementationTag.NumberOfBits;
        }
    }

    public static class CustomAttributeTypeTag
    {
        public const int NumberOfBits = 3;
        public const uint LargeRowSize = 0x00000001 << (16 - CustomAttributeTypeTag.NumberOfBits);
        public const uint Method = 0x00000002;
        public const uint MemberRef = 0x00000003;
        public const uint TagMask = 0x0000007;
        public static TokenTypeIds[] TagToTokenTypeArray = { 0, 0, TokenTypeIds.MethodDef, TokenTypeIds.MemberRef, 0 };
        public const TableMask TablesReferenced =
            TableMask.Method
            | TableMask.MemberRef;
        public static uint ConvertToToken(uint customAttributeType) {
            return (uint)CustomAttributeTypeTag.TagToTokenTypeArray[customAttributeType & CustomAttributeTypeTag.TagMask] | customAttributeType >> CustomAttributeTypeTag.NumberOfBits;
        }
    }

    public enum ResolutionScopeKind : byte
    {
        Module = 0x00000000,

        ModuleRef = 0x00000001,

        AssemblyRef = 0x00000002,

        TypeRef = 0x00000003,
    }

    public static class ResolutionScopeTag
    {
        public const int NumberOfBits = 2;

        public const uint LargeRowSize = 0x00000001 << (16 - ResolutionScopeTag.NumberOfBits);

        public const uint Module = 0x00000000;

        public const uint ModuleRef = 0x00000001;

        public const uint AssemblyRef = 0x00000002;

        public const uint TypeRef = 0x00000003;

        public const uint TagMask = 0x00000003;

        public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.Module, TokenTypeIds.ModuleRef, TokenTypeIds.AssemblyRef, TokenTypeIds.TypeRef };

        public const TableMask TablesReferenced = TableMask.Module | TableMask.ModuleRef | TableMask.AssemblyRef | TableMask.TypeRef;

        public static uint ConvertToToken(uint resolutionScope) {
            return (uint)ResolutionScopeTag.TagToTokenTypeArray[resolutionScope & ResolutionScopeTag.TagMask] | resolutionScope >> ResolutionScopeTag.NumberOfBits;
        }
    }

    public static class TypeOrMethodDefTag
    {
        public const int NumberOfBits = 1;

        public const uint LargeRowSize = 0x00000001 << (16 - TypeOrMethodDefTag.NumberOfBits);

        public const uint TypeDef = 0x00000000;

        public const uint MethodDef = 0x00000001;

        public const uint TagMask = 0x0000001;

        public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.TypeDef, TokenTypeIds.MethodDef };

        public const TableMask TablesReferenced =
            TableMask.TypeDef
            | TableMask.Method;

        public static uint ConvertToToken(uint typeOrMethodDef) {
            return (uint)TypeOrMethodDefTag.TagToTokenTypeArray[typeOrMethodDef & TypeOrMethodDefTag.TagMask] | typeOrMethodDef >> TypeOrMethodDefTag.NumberOfBits;
        }

        public static uint ConvertTypeDefRowIdToTag(uint typeDefRowId) {
            return typeDefRowId << TypeOrMethodDefTag.NumberOfBits | TypeOrMethodDefTag.TypeDef;
        }
        public static uint ConvertMethodDefRowIdToTag(uint methodDefRowId) {
            return methodDefRowId << TypeOrMethodDefTag.NumberOfBits | TypeOrMethodDefTag.MethodDef;
        }
    }
}
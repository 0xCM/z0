//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Derivatives.SRM;

    using CA = ClrStorage.CustomAttributeCode;

    partial struct ClrStorage
    {
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

            public const TableMask TablesReferenced
                = TableMask.MethodSpec
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
    }
}
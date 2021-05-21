//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;


    public unsafe partial class SRM
    {

        internal static class HasCustomAttributeTag
        {
            internal const int NumberOfBits = 5;

            internal const int LargeRowSize = 0x00000001 << (16 - NumberOfBits);

            internal const uint MethodDef = 0x00000000;

            internal const uint Field = 0x00000001;

            internal const uint TypeRef = 0x00000002;

            internal const uint TypeDef = 0x00000003;

            internal const uint Param = 0x00000004;

            internal const uint InterfaceImpl = 0x00000005;

            internal const uint MemberRef = 0x00000006;

            internal const uint Module = 0x00000007;

            internal const uint DeclSecurity = 0x00000008;

            internal const uint Property = 0x00000009;

            internal const uint Event = 0x0000000A;

            internal const uint StandAloneSig = 0x0000000B;

            internal const uint ModuleRef = 0x0000000C;

            internal const uint TypeSpec = 0x0000000D;

            internal const uint Assembly = 0x0000000E;

            internal const uint AssemblyRef = 0x0000000F;

            internal const uint File = 0x00000010;

            internal const uint ExportedType = 0x00000011;

            internal const uint ManifestResource = 0x00000012;

            internal const uint GenericParam = 0x00000013;

            internal const uint GenericParamConstraint = 0x00000014;

            internal const uint MethodSpec = 0x00000015;

            internal const uint TagMask = 0x0000001F;

            // Arbitrary value not equal to any of the token types in the array. This includes 0 which is TokenTypeIds.Module.
            internal const uint InvalidTokenType = uint.MaxValue;

            internal static uint[] TagToTokenTypeArray =
            {
                TokenTypeIds.MethodDef,
                TokenTypeIds.FieldDef,
                TokenTypeIds.TypeRef,
                TokenTypeIds.TypeDef,
                TokenTypeIds.ParamDef,
                TokenTypeIds.InterfaceImpl,
                TokenTypeIds.MemberRef,
                TokenTypeIds.Module,
                TokenTypeIds.DeclSecurity,
                TokenTypeIds.Property,
                TokenTypeIds.Event,
                TokenTypeIds.Signature,
                TokenTypeIds.ModuleRef,
                TokenTypeIds.TypeSpec,
                TokenTypeIds.Assembly,
                TokenTypeIds.AssemblyRef,
                TokenTypeIds.File,
                TokenTypeIds.ExportedType,
                TokenTypeIds.ManifestResource,
                TokenTypeIds.GenericParam,
                TokenTypeIds.GenericParamConstraint,
                TokenTypeIds.MethodSpec,

                InvalidTokenType,
                InvalidTokenType,
                InvalidTokenType,
                InvalidTokenType,
                InvalidTokenType,
                InvalidTokenType,
                InvalidTokenType,
                InvalidTokenType,
                InvalidTokenType,
                InvalidTokenType
            };

            internal const TableMask TablesReferenced =
                TableMask.MethodDef
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

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static EntityHandle ConvertToHandle(uint hasCustomAttribute)
            {
                uint tokenType = TagToTokenTypeArray[hasCustomAttribute & TagMask];
                uint rowId = (hasCustomAttribute >> NumberOfBits);

                if (tokenType == InvalidTokenType || ((rowId & ~TokenTypeIds.RIDMask) != 0))
                {
                    return default;
                }

                return Cli.handle(tokenType | rowId);
            }

            internal static uint ConvertToTag(EntityHandle handle)
            {
                uint tokenType = core.uint32(handle) & 0x7F000000u;
                uint rowId = core.uint32(handle) & 0xFFFFFF;
                return (tokenType >> TokenTypeIds.RowIdBitCount) switch
                {
                    TokenTypeIds.MethodDef >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | MethodDef,
                    TokenTypeIds.FieldDef >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | Field,
                    TokenTypeIds.TypeRef >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | TypeRef,
                    TokenTypeIds.TypeDef >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | TypeDef,
                    TokenTypeIds.ParamDef >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | Param,
                    TokenTypeIds.InterfaceImpl >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | InterfaceImpl,
                    TokenTypeIds.MemberRef >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | MemberRef,
                    TokenTypeIds.Module >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | Module,
                    TokenTypeIds.DeclSecurity >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | DeclSecurity,
                    TokenTypeIds.Property >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | Property,
                    TokenTypeIds.Event >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | Event,
                    TokenTypeIds.Signature >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | StandAloneSig,
                    TokenTypeIds.ModuleRef >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | ModuleRef,
                    TokenTypeIds.TypeSpec >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | TypeSpec,
                    TokenTypeIds.Assembly >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | Assembly,
                    TokenTypeIds.AssemblyRef >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | AssemblyRef,
                    TokenTypeIds.File >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | File,
                    TokenTypeIds.ExportedType >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | ExportedType,
                    TokenTypeIds.ManifestResource >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | ManifestResource,
                    TokenTypeIds.GenericParam >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | GenericParam,
                    TokenTypeIds.GenericParamConstraint >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | GenericParamConstraint,
                    TokenTypeIds.MethodSpec >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | MethodSpec,

                    _ => 0,
                };
            }
        }
    }
}
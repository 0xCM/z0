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


        internal static class HasDeclSecurityTag
        {
            internal const int NumberOfBits = 2;
            internal const int LargeRowSize = 0x00000001 << (16 - NumberOfBits);
            internal const uint TypeDef = 0x00000000;
            internal const uint MethodDef = 0x00000001;
            internal const uint Assembly = 0x00000002;
            internal const uint TagMask = 0x00000003;
            internal const TableMask TablesReferenced =
            TableMask.TypeDef
            | TableMask.MethodDef
            | TableMask.Assembly;
            internal const uint TagToTokenTypeByteVector = (TokenTypeIds.TypeDef >> 24) | (TokenTypeIds.MethodDef >> 16) | (TokenTypeIds.Assembly >> 8);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static EntityHandle ConvertToHandle(uint hasDeclSecurity)
            {
                uint tokenType = (TagToTokenTypeByteVector >> ((int)(hasDeclSecurity & TagMask) << 3)) << TokenTypeIds.RowIdBitCount;
                uint rowId = (hasDeclSecurity >> NumberOfBits);

                if (tokenType == 0 || (rowId & ~TokenTypeIds.RIDMask) != 0)
                {
                    //Throw.InvalidCodedIndex();
                }

                return Cli.handle(tokenType | rowId);
            }

            // internal static uint ConvertToTag(EntityHandle handle)
            // {
            //     uint tokenType = handle.Type;
            //     uint rowId = (uint)handle.RowId;
            //     return (tokenType >> TokenTypeIds.RowIdBitCount) switch
            //     {
            //         TokenTypeIds.TypeDef >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | TypeDef,
            //         TokenTypeIds.MethodDef >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | MethodDef,
            //         TokenTypeIds.Assembly >> TokenTypeIds.RowIdBitCount => rowId << NumberOfBits | Assembly,
            //         _ => 0,
            //     };
            // }

        }
    }
}
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
        static class TypeDefOrRefTag
        {
            internal const int NumberOfBits = 2;
            internal const int LargeRowSize = 0x00000001 << (16 - NumberOfBits);
            internal const uint TypeDef = 0x00000000;
            internal const uint TypeRef = 0x00000001;
            internal const uint TypeSpec = 0x00000002;
            internal const uint TagMask = 0x00000003;
            internal const uint TagToTokenTypeByteVector = TokenTypeIds.TypeDef >> 24 | TokenTypeIds.TypeRef >> 16 | TokenTypeIds.TypeSpec >> 8;
            internal const TableMask TablesReferenced = TableMask.TypeDef | TableMask.TypeRef | TableMask.TypeSpec;

            // inlining improves perf of the tight loop in FindSystemObjectTypeDef by 25%
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static EntityHandle ConvertToHandle(uint typeDefOrRefTag)
            {
                uint tokenType = (TagToTokenTypeByteVector >> ((int)(typeDefOrRefTag & TagMask) << 3)) << TokenTypeIds.RowIdBitCount;
                uint rowId = (typeDefOrRefTag >> NumberOfBits);

                if (tokenType == 0 || (rowId & ~TokenTypeIds.RIDMask) != 0)
                {
                    return default;
                }

                return Clr.handle(tokenType | rowId);
            }
        }
    }
}
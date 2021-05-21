//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Reflection.Metadata;
    using System.Reflection.Metadata.Ecma335;

    partial class SRM
    {
        internal static class HasFieldMarshalTag
        {
            internal const int NumberOfBits = 1;

            internal const int LargeRowSize = 0x00000001 << (16 - NumberOfBits);

            internal const uint Field = 0x00000000;

            internal const uint Param = 0x00000001;

            internal const uint TagMask = 0x00000001;

            internal const TableMask TablesReferenced =
                TableMask.Field
                | TableMask.Param;

            internal const uint TagToTokenTypeByteVector = TokenTypeIds.FieldDef >> 24 | TokenTypeIds.ParamDef >> 16;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static EntityHandle ConvertToHandle(uint hasFieldMarshal)
            {
                uint tokenType = (TagToTokenTypeByteVector >> ((int)(hasFieldMarshal & TagMask) << 3)) << TokenTypeIds.RowIdBitCount;
                uint rowId = (hasFieldMarshal >> NumberOfBits);

                if ((rowId & ~TokenTypeIds.RIDMask) != 0)
                    return default;

                return Cli.handle(tokenType | rowId);
            }
        }
    }
}
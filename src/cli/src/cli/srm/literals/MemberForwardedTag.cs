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
        internal static class MemberForwardedTag
        {
            internal const int NumberOfBits = 1;
            internal const int LargeRowSize = 0x00000001 << (16 - NumberOfBits);
            internal const uint Field = 0x00000000;
            internal const uint MethodDef = 0x00000001;
            internal const uint TagMask = 0x00000001;
            internal const TableMask TablesReferenced =
            TableMask.Field
            | TableMask.MethodDef;
            internal const uint TagToTokenTypeByteVector = TokenTypeIds.FieldDef >> 24 | TokenTypeIds.MethodDef >> 16;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static EntityHandle ConvertToHandle(uint memberForwarded)
            {
                uint tokenType = (TagToTokenTypeByteVector >> ((int)(memberForwarded & TagMask) << 3)) << TokenTypeIds.RowIdBitCount;
                uint rowId = (memberForwarded >> NumberOfBits);

                if ((rowId & ~TokenTypeIds.RIDMask) != 0)
                {
                    //Throw.InvalidCodedIndex();
                }

                return Cli.handle(tokenType | rowId);
            }

            // internal static uint ConvertMethodDefToTag(MethodDefinitionHandle methodDef)
            // {
            //     return (uint)methodDef.RowId << NumberOfBits | MethodDef;
            // }
        }
    }
}
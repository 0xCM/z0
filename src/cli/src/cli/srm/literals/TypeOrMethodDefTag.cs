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
        internal static class TypeOrMethodDefTag
        {
            internal const int NumberOfBits = 1;
            internal const int LargeRowSize = 0x00000001 << (16 - NumberOfBits);
            internal const uint TypeDef = 0x00000000;
            internal const uint MethodDef = 0x00000001;
            internal const uint TagMask = 0x0000001;
            internal const uint TagToTokenTypeByteVector = TokenTypeIds.TypeDef >> 24 | TokenTypeIds.MethodDef >> 16;
            internal const TableMask TablesReferenced =
            TableMask.TypeDef
            | TableMask.MethodDef;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static EntityHandle ConvertToHandle(uint typeOrMethodDef)
            {
                uint tokenType = (TagToTokenTypeByteVector >> ((int)(typeOrMethodDef & TagMask) << 3)) << TokenTypeIds.RowIdBitCount;
                uint rowId = (typeOrMethodDef >> NumberOfBits);

                if ((rowId & ~TokenTypeIds.RIDMask) != 0)
                {
                    //Throw.InvalidCodedIndex();
                }

                return Cli.handle(tokenType | rowId);
            }

            // internal static uint ConvertTypeDefRowIdToTag(TypeDefinitionHandle typeDef)
            // {
            //     return (uint)typeDef.RowId << NumberOfBits | TypeDef;
            // }

            // internal static uint ConvertMethodDefToTag(MethodDefinitionHandle methodDef)
            // {
            //     return (uint)methodDef.RowId << NumberOfBits | MethodDef;
            // }
        }
    }
}
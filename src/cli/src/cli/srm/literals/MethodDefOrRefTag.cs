//-----------------------------------------------------------------------------
// Copyright   :  (c) Microsoft/.NET Foundation
// License     :  MIT
// Source      : https://github.com/dotnet/runtime/src/libraries/System.Reflection.Metadata/src/System/Reflection/Metadata/MetadataReader.cs
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Reflection.Metadata;
    using System.Runtime.CompilerServices;

    public unsafe partial class SRM
    {

        internal static class MethodDefOrRefTag
        {
            internal const int NumberOfBits = 1;
            internal const int LargeRowSize = 0x00000001 << (16 - NumberOfBits);
            internal const uint MethodDef = 0x00000000;
            internal const uint MemberRef = 0x00000001;
            internal const uint TagMask = 0x00000001;
            internal const TableMask TablesReferenced =
            TableMask.MethodDef
            | TableMask.MemberRef;
            internal const uint TagToTokenTypeByteVector = TokenTypeIds.MethodDef >> 24 | TokenTypeIds.MemberRef >> 16;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static EntityHandle ConvertToHandle(uint methodDefOrRef)
            {
                uint tokenType = (TagToTokenTypeByteVector >> ((int)(methodDefOrRef & TagMask) << 3)) << TokenTypeIds.RowIdBitCount;
                uint rowId = (methodDefOrRef >> NumberOfBits);

                if ((rowId & ~TokenTypeIds.RIDMask) != 0)
                {
                    //Throw.InvalidCodedIndex();
                }

                return Cli.handle(tokenType | rowId);
            }
        }
    }
}
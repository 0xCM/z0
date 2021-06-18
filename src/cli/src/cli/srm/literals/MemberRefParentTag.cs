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
        internal static class MemberRefParentTag
        {
            internal const int NumberOfBits = 3;
            internal const int LargeRowSize = 0x00000001 << (16 - NumberOfBits);
            internal const uint TypeDef = 0x00000000;
            internal const uint TypeRef = 0x00000001;
            internal const uint ModuleRef = 0x00000002;
            internal const uint MethodDef = 0x00000003;
            internal const uint TypeSpec = 0x00000004;
            internal const uint TagMask = 0x00000007;
            internal const TableMask TablesReferenced =
            TableMask.TypeDef
            | TableMask.TypeRef
            | TableMask.ModuleRef
            | TableMask.MethodDef
            | TableMask.TypeSpec;
            internal const ulong TagToTokenTypeByteVector =
                (ulong)TokenTypeIds.TypeDef >> 24
                | (ulong)TokenTypeIds.TypeRef >> 16
                | (ulong)TokenTypeIds.ModuleRef >> 8
                | (ulong)TokenTypeIds.MethodDef
                | (ulong)TokenTypeIds.TypeSpec << 8;

            [MethodImplAttribute(MethodImplOptions.AggressiveInlining)]
            internal static EntityHandle ConvertToHandle(uint memberRef)
            {
                uint tokenType = unchecked((uint)((TagToTokenTypeByteVector >> ((int)(memberRef & TagMask) << 3)) << TokenTypeIds.RowIdBitCount));
                uint rowId = (memberRef >> NumberOfBits);

                if (tokenType == 0 || (rowId & ~TokenTypeIds.RIDMask) != 0)
                {
                    //Throw.InvalidCodedIndex();
                }

                return Clr.handle(tokenType | rowId);
            }
        }
    }
}
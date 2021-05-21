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
        internal static class HasSemanticsTag
        {
            internal const int NumberOfBits = 1;
            internal const int LargeRowSize = 0x00000001 << (16 - NumberOfBits);
            internal const uint Event = 0x00000000;
            internal const uint Property = 0x00000001;
            internal const uint TagMask = 0x00000001;
            internal const TableMask TablesReferenced =
            TableMask.Event
            | TableMask.Property;
            internal const uint TagToTokenTypeByteVector = TokenTypeIds.Event >> 24 | TokenTypeIds.Property >> 16;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static EntityHandle ConvertToHandle(uint hasSemantic)
            {
                uint tokenType = (TagToTokenTypeByteVector >> ((int)(hasSemantic & TagMask) << 3)) << TokenTypeIds.RowIdBitCount;
                uint rowId = (hasSemantic >> NumberOfBits);

                if ((rowId & ~TokenTypeIds.RIDMask) != 0)
                {
                    //Throw.InvalidCodedIndex();
                }

                return Cli.handle(tokenType | rowId);
            }

            // internal static uint ConvertEventHandleToTag(EventDefinitionHandle eventDef)
            // {
            //     return (uint)eventDef.RowId << NumberOfBits | Event;
            // }

            // internal static uint ConvertPropertyHandleToTag(PropertyDefinitionHandle propertyDef)
            // {
            //     return (uint)propertyDef.RowId << NumberOfBits | Property;
            // }
        }
    }
}
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

    partial struct ClrStorage
    {

        public static class HasSemanticsTag
        {
            public const int NumberOfBits = 1;

            public const uint LargeRowSize = 0x00000001 << (16 - HasSemanticsTag.NumberOfBits);

            public const uint Event = 0x00000000;

            public const uint Property = 0x00000001;

            public const uint TagMask = 0x00000001;

            public const TableMask TablesReferenced = TableMask.Event | TableMask.Property;

            public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.Event, TokenTypeIds.Property };

            public static uint ConvertToToken(uint hasSemantic) {
            return (uint)HasSemanticsTag.TagToTokenTypeArray[hasSemantic & HasSemanticsTag.TagMask] | hasSemantic >> HasSemanticsTag.NumberOfBits;
            }
            public static uint ConvertEventRowIdToTag(uint eventRowId) {
            return eventRowId << HasSemanticsTag.NumberOfBits | HasSemanticsTag.Event;
            }
            public static uint ConvertPropertyRowIdToTag(uint propertyRowId) {
            return propertyRowId << HasSemanticsTag.NumberOfBits | HasSemanticsTag.Property;
            }
        }
    }
}
//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Derivatives.CCI
{
    using System;
    using System.Runtime.CompilerServices;

    using SRM;

    public readonly struct HasFieldMarshalTag
    {
        public const int NumberOfBits = 1;

        public const uint LargeRowSize = 0x00000001 << (16 - HasFieldMarshalTag.NumberOfBits);

        public const uint Field = 0x00000000;

        public const uint Param = 0x00000001;

        public const uint TagMask = 0x00000001;

        public const TableMask TablesReferenced = TableMask.Field | TableMask.Param;

        public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.FieldDef, TokenTypeIds.ParamDef };

        public static uint ConvertToToken(uint hasFieldMarshal)
        {
            return (uint)HasFieldMarshalTag.TagToTokenTypeArray[hasFieldMarshal & HasFieldMarshalTag.TagMask] | hasFieldMarshal >> HasFieldMarshalTag.NumberOfBits;
        }

        public static uint ConvertToTag(uint token)
        {
            var tokenKind = token & (uint)TokenTypeIds.TokenTypeMask;
            var rowId = token & (uint)TokenTypeIds.RIDMask;
            if (tokenKind == (uint)TokenTypeIds.FieldDef)
                return rowId << HasFieldMarshalTag.NumberOfBits | HasFieldMarshalTag.Field;
            else if (tokenKind == (uint)TokenTypeIds.ParamDef)
                return rowId << HasFieldMarshalTag.NumberOfBits | HasFieldMarshalTag.Param;
            else
                return 0;
        }
    }
}
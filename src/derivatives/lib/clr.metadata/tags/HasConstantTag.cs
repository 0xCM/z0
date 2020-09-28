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

    public readonly struct HasConstantTag
    {
        public const int NumberOfBits = 2;

        public const uint LargeRowSize = 0x00000001 << (16 - HasConstantTag.NumberOfBits);

        public const uint Field = 0x00000000;

        public const uint Param = 0x00000001;

        public const uint Property = 0x00000002;

        public const uint TagMask = 0x00000003;

        public const TableMask TablesReferenced = TableMask.Field | TableMask.Param | TableMask.Property;

        public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.FieldDef, TokenTypeIds.ParamDef, TokenTypeIds.Property };

        public static uint ConvertToToken(uint hasConstant)
        {
            return (uint)HasConstantTag.TagToTokenTypeArray[hasConstant & HasConstantTag.TagMask] | hasConstant >> HasConstantTag.NumberOfBits;
        }

        public static uint ConvertToTag(uint token)
        {
            uint tokenKind = token & (uint)TokenTypeIds.TokenTypeMask;
            uint rowId = token & (uint)TokenTypeIds.RIDMask;
            if (tokenKind == (uint)TokenTypeIds.FieldDef) {
            return rowId << HasConstantTag.NumberOfBits | HasConstantTag.Field;
            } else if (tokenKind == (uint)TokenTypeIds.ParamDef) {
            return rowId << HasConstantTag.NumberOfBits | HasConstantTag.Param;
            } else if (tokenKind == (uint)TokenTypeIds.Property) {
            return rowId << HasConstantTag.NumberOfBits | HasConstantTag.Property;
            }
            return 0;
        }
    }

}
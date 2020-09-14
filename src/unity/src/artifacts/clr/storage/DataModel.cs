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

        public readonly struct HasDeclSecurityTag
        {
            public const int NumberOfBits = 2;

            public const uint LargeRowSize = 0x00000001 << (16 - HasDeclSecurityTag.NumberOfBits);

            public const uint TypeDef = 0x00000000;

            public const uint Method = 0x00000001;

            public const uint Assembly = 0x00000002;

            public const uint TagMask = 0x00000003;

            public const TableMask TablesReferenced = TableMask.TypeDef | TableMask.Method  | TableMask.Assembly;

            public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.TypeDef, TokenTypeIds.MethodDef, TokenTypeIds.Assembly };

            public static uint ConvertToToken(uint hasDeclSecurity) {
                return (uint)HasDeclSecurityTag.TagToTokenTypeArray[hasDeclSecurity & HasDeclSecurityTag.TagMask] | hasDeclSecurity >> HasDeclSecurityTag.NumberOfBits;
            }
            public static uint ConvertToTag(uint token)
            {
                uint tokenKind = token & (uint)TokenTypeIds.TokenTypeMask;
                uint rowId = token & (uint)TokenTypeIds.RIDMask;
                if (tokenKind == (uint)TokenTypeIds.TypeDef) {
                return rowId << HasDeclSecurityTag.NumberOfBits | HasDeclSecurityTag.TypeDef;
                } else if (tokenKind == (uint)TokenTypeIds.MethodDef) {
                return rowId << HasDeclSecurityTag.NumberOfBits | HasDeclSecurityTag.Method;
                } else if (tokenKind == (uint)TokenTypeIds.Assembly) {
                return rowId << HasDeclSecurityTag.NumberOfBits | HasDeclSecurityTag.Assembly;
                }
                return 0;
            }
        }

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
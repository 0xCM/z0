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

    public readonly struct HasDeclSecurityTag
    {
        public const int NumberOfBits = 2;

        public const uint LargeRowSize = 0x00000001 << (16 - HasDeclSecurityTag.NumberOfBits);

        public const uint TypeDef = 0x00000000;

        public const uint Method = 0x00000001;

        public const uint Assembly = 0x00000002;

        public const uint TagMask = 0x00000003;

        public const TableMask TablesReferenced = TableMask.TypeDef | TableMask.MethodSpec  | TableMask.Assembly;

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
}
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

    public readonly struct MemberRefParentTag
    {
        public const int NumberOfBits = 3;

        public const uint LargeRowSize = 0x00000001 << (16 - MemberRefParentTag.NumberOfBits);

        public const uint TypeDef = 0x00000000;

        public const uint TypeRef = 0x00000001;

        public const uint ModuleRef = 0x00000002;

        public const uint Method = 0x00000003;

        public const uint TypeSpec = 0x00000004;

        public const uint TagMask = 0x00000007;

        public const TableMask TablesReferenced = TableMask.TypeDef
            | TableMask.TypeRef
            | TableMask.ModuleRef
            | TableMask.MethodSpec
            | TableMask.TypeSpec;

        public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.TypeDef, TokenTypeIds.TypeRef, TokenTypeIds.ModuleRef,
            TokenTypeIds.MethodDef, TokenTypeIds.TypeSpec };
        public static uint ConvertToToken(uint memberRef) {
            return (uint)MemberRefParentTag.TagToTokenTypeArray[memberRef & MemberRefParentTag.TagMask] | memberRef >> MemberRefParentTag.NumberOfBits;
        }
    }
}
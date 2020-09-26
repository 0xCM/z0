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

    public readonly struct TypeDefOrRefTag
    {
        public const int NumberOfBits = 2;

        public const uint LargeRowSize = 0x00000001 << (16 - TypeDefOrRefTag.NumberOfBits);

        public const uint TypeDef = 0x00000000;

        public const uint TypeRef = 0x00000001;

        public const uint TypeSpec = 0x00000002;

        public const uint TagMask = 0x00000003;

        public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.TypeDef, TokenTypeIds.TypeRef, TokenTypeIds.TypeSpec };

        public const TableMask TablesReferenced = TableMask.TypeDef | TableMask.TypeRef | TableMask.TypeSpec;

        public static uint ConvertToToken(uint typeDefOrRefTag)
            => (uint)TypeDefOrRefTag.TagToTokenTypeArray[typeDefOrRefTag & TypeDefOrRefTag.TagMask] | typeDefOrRefTag >> TypeDefOrRefTag.NumberOfBits;
    }
}
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

    public static class TypeOrMethodDefTag
    {
        public const int NumberOfBits = 1;

        public const uint LargeRowSize = 0x00000001 << (16 - TypeOrMethodDefTag.NumberOfBits);

        public const uint TypeDef = 0x00000000;

        public const uint MethodDef = 0x00000001;

        public const uint TagMask = 0x0000001;

        public static TokenTypeIds[] TagToTokenTypeArray = {TokenTypeIds.TypeDef, TokenTypeIds.MethodDef };

        public const TableMask TablesReferenced = TableMask.TypeDef | TableMask.MethodSpec;

        public static uint ConvertToToken(uint typeOrMethodDef)
            => (uint)TypeOrMethodDefTag.TagToTokenTypeArray[typeOrMethodDef & TypeOrMethodDefTag.TagMask] | typeOrMethodDef >> TypeOrMethodDefTag.NumberOfBits;

        public static uint ConvertTypeDefRowIdToTag(uint typeDefRowId)
            => typeDefRowId << TypeOrMethodDefTag.NumberOfBits | TypeOrMethodDefTag.TypeDef;

        public static uint ConvertMethodDefRowIdToTag(uint methodDefRowId)
            => methodDefRowId << TypeOrMethodDefTag.NumberOfBits | TypeOrMethodDefTag.MethodDef;
    }
}
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

    public readonly struct MemberForwardedTag
    {
        public const int NumberOfBits = 1;

        public const uint LargeRowSize = 0x00000001 << (16 - MemberForwardedTag.NumberOfBits);

        public const uint Field = 0x00000000;

        public const uint Method = 0x00000001;

        public const uint TagMask = 0x00000001;

        public const TableMask TablesReferenced = TableMask.Field | TableMask.MethodSpec;

        public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.FieldDef, TokenTypeIds.MethodDef };

        public static uint ConvertToToken(uint memberForwarded)
            => (uint)MemberForwardedTag.TagToTokenTypeArray[memberForwarded & MethodDefOrRefTag.TagMask] | memberForwarded >> MethodDefOrRefTag.NumberOfBits;

        public static uint ConvertMethodDefRowIdToTag(uint methodDefRowId)
            => methodDefRowId << MemberForwardedTag.NumberOfBits | MemberForwardedTag.Method;
    }
}
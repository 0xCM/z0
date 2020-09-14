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
        public readonly struct MethodDefOrRefTag
        {
            public const int NumberOfBits = 1;

            public const uint LargeRowSize = 0x00000001 << (16 - MethodDefOrRefTag.NumberOfBits);

            public const uint Method = 0x00000000;

            public const uint MemberRef = 0x00000001;

            public const uint TagMask = 0x00000001;

            public const TableMask TablesReferenced = TableMask.Method | TableMask.MemberRef;

            public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.MethodDef, TokenTypeIds.MemberRef };

            public static uint ConvertToToken(uint methodDefOrRef)
                => (uint)MethodDefOrRefTag.TagToTokenTypeArray[methodDefOrRef & MethodDefOrRefTag.TagMask] | methodDefOrRef >> MethodDefOrRefTag.NumberOfBits;

        }
    }
}
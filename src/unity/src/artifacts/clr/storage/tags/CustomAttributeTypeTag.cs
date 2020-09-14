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
        public readonly struct CustomAttributeTypeTag
        {
            public const int NumberOfBits = 3;

            public const uint LargeRowSize = 0x00000001 << (16 - CustomAttributeTypeTag.NumberOfBits);

            public const uint Method = 0x00000002;

            public const uint MemberRef = 0x00000003;

            public const uint TagMask = 0x0000007;

            public static TokenTypeIds[] TagToTokenTypeArray = { 0, 0, TokenTypeIds.MethodDef, TokenTypeIds.MemberRef, 0 };

            public const TableMask TablesReferenced =
                TableMask.Method
                | TableMask.MemberRef;
            public static uint ConvertToToken(uint customAttributeType) {
                return (uint)CustomAttributeTypeTag.TagToTokenTypeArray[customAttributeType & CustomAttributeTypeTag.TagMask] | customAttributeType >> CustomAttributeTypeTag.NumberOfBits;
            }
        }
    }
}
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
        public readonly struct ImplementationTag
        {
            public const int NumberOfBits = 2;

            public const uint LargeRowSize = 0x00000001 << (16 - ImplementationTag.NumberOfBits);

            public const uint File = 0x00000000;

            public const uint AssemblyRef = 0x00000001;

            public const uint ExportedType = 0x00000002;

            public const uint TagMask = 0x00000003;

            public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.File, TokenTypeIds.AssemblyRef, TokenTypeIds.ExportedType };

            public const TableMask TablesReferenced = TableMask.File | TableMask.AssemblyRef | TableMask.ExportedType;

            public static uint ConvertToToken(uint implementation)
            {
                if (implementation == 0) return 0;
                return (uint)ImplementationTag.TagToTokenTypeArray[implementation & ImplementationTag.TagMask] | implementation >> ImplementationTag.NumberOfBits;
            }
        }
    }
}
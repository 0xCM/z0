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
        public static class ResolutionScopeTag
        {
            public const int NumberOfBits = 2;

            public const uint LargeRowSize = 0x00000001 << (16 - ResolutionScopeTag.NumberOfBits);

            public const uint Module = 0x00000000;

            public const uint ModuleRef = 0x00000001;

            public const uint AssemblyRef = 0x00000002;

            public const uint TypeRef = 0x00000003;

            public const uint TagMask = 0x00000003;

            public static TokenTypeIds[] TagToTokenTypeArray = { TokenTypeIds.Module, TokenTypeIds.ModuleRef, TokenTypeIds.AssemblyRef, TokenTypeIds.TypeRef };

            public const TableMask TablesReferenced = TableMask.Module | TableMask.ModuleRef | TableMask.AssemblyRef | TableMask.TypeRef;

            public static uint ConvertToToken(uint resolutionScope) {
                return (uint)ResolutionScopeTag.TagToTokenTypeArray[resolutionScope & ResolutionScopeTag.TagMask] | resolutionScope >> ResolutionScopeTag.NumberOfBits;
            }
        }
    }
}
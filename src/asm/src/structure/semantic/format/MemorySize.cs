//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    partial struct AsmFormatServices
    {
        public static string RenderContent(MemorySize src)
            => src switch {
                MemorySize.Int8 => "8i",
                MemorySize.Int16 => "16i",
                MemorySize.Int32 => "32i",
                MemorySize.Int64 => "64i",
                MemorySize.UInt8 => "8u",
                MemorySize.UInt16 => "16u",
                MemorySize.UInt32 => "32u",
                MemorySize.UInt64 => "64u",
                MemorySize.Unknown => string.Empty,
                _   => src.ToString()
            };
    }
}
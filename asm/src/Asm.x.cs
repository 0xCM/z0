//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public static partial class AsmExtend
    {
        public static FileExtension FileExt(this ArchiveFileKind kind)
            => FileExtension.Define(kind.ToString().ToLower());

        public static AsmCode GetAsmCode(this ParsedEncodingRecord encoding, MemoryAddress @base)
            => AsmCode.Define(
                encoding.Uri.OpId, 
                MemoryRange.Define(@base, @base + (MemoryAddress)encoding.Data.Length), 
                encoding.Data);
    }
}
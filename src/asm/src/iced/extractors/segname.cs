//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Asm.IceOpKind;

    partial struct IceExtractors
    {
        /// <summary>
        /// If operand kind represents a memory segment, returns the mnemonic/name for the segment; otheriwise returns empty
        /// </summary>
        /// <param name="src"></param>
        [Op]
        public static Name segname(IceOpKind src)
            => src switch {
                MemorySegSI => "si",
                MemorySegESI => "esi",
                MemorySegRSI => "rsi",
                MemorySegDI => "di",
                MemorySegEDI => "edi",
                MemorySegRDI => "rdi",
                MemoryESDI => "esdi",
                MemoryESEDI => "esedi",
                MemoryESRDI => "esrdi",
            _ => Name.Empty
            };
    }
}
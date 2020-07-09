//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;

    using static OpKind;
    using static Konst;

    partial struct SemanticRender
    {        
        static string RenderSegKind(string symbol)
            => text.empty(symbol) ? EmptyString : text.concat("seg:", Chars.LBracket, symbol, Chars.RBracket);
        
        static string RenderSegKind(OpKind src)
            => RenderSegKind(src switch {
                MemorySegDI => "di",
                MemorySegEDI => "edi",
                MemorySegESI => "esi",
                MemorySegRDI => "rdi",
                MemorySegRSI => "rsi",
                MemorySegSI => "si",
                MemoryESDI => "esdi",
                MemoryESEDI => "esedi",
                MemoryESRDI => "esrdi",
            _ => ""
            });
    }
}
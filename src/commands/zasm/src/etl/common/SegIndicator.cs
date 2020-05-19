//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Asm.Data.OpKind;

    using Asm.Data;

    public readonly struct SegIndicator : ITextual, INullaryKnown
    {   
        public string Identifier {get;}

        public static SegIndicator Empty => Define(string.Empty);     

        public static SegIndicator di => Define(nameof(di));

        public static SegIndicator edi => Define(nameof(edi));

        public static SegIndicator esi => Define(nameof(esi));

        public static SegIndicator rdi => Define(nameof(rdi));

        public static SegIndicator rsi => Define(nameof(rsi));

        public static SegIndicator si => Define(nameof(si));

        public static SegIndicator esdi => Define(nameof(esdi));

        public static SegIndicator esedi => Define(nameof(esedi));

        public static SegIndicator esrdi => Define(nameof(esrdi));

        public static SegIndicator From(OpKind src)
            => src switch {
                MemorySegDI => di,
                MemorySegEDI => edi,
                MemorySegESI => esi,
                MemorySegRDI => rdi,
                MemorySegRSI => rsi,
                MemorySegSI => si,
                MemoryESDI => esdi,
                MemoryESEDI => esedi,
                MemoryESRDI => esrdi,
            _ => Empty
            };

        [MethodImpl(Inline)]
        static SegIndicator Define(string id)
            => new SegIndicator(id);
        
        [MethodImpl(Inline)]
        SegIndicator(string id)
        {
            Identifier = id;
        }

        public bool IsEmpty => text.empty(Identifier);

        public bool IsNonEmpty => !IsEmpty;
        
        public string Format()
            => IsEmpty ? string.Empty : text.concat("seg:", Chars.LBracket, Identifier, Chars.RBracket);

        public override string ToString()
            => Format();
    }
}
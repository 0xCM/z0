//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

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
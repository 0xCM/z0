//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct RegisterModel : ITextual<RegisterModel>
    {
        public readonly int Id;
        public readonly RegisterSymbol Symbol;

        public readonly RegisterWidth Width;
        
        public readonly RegisterSlot Slot;

        [MethodImpl(Inline)]
        internal RegisterModel(int id, RegisterSymbol symbol, RegisterWidth width, RegisterSlot slot)
        {
            Id = id;
            Symbol = symbol;
            Width = width;
            Slot = slot;
        }

        public string Format()
            => Symbol.ToString();

        public override string ToString()
            => Format();
    }
}
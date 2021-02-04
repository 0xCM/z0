//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Part;


    public readonly struct AsmSigOpToken : ITextual, INullity
    {
        public byte Index {get;}

        public Identifier Name {get;}

        public AsmSigOpKind Kind {get;}

        public Name Symbol {get;}

        [MethodImpl(Inline)]
        public AsmSigOpToken(byte index, Identifier name, AsmSigOpKind kind, string symbol)
        {
            Index = index;
            Name = name;
            Kind = kind;
            Symbol = symbol;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Index == 0;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Index != 0;
        }

        public string Format()
            => string.Format("{0,-4} | {1,-12} | {2}", Index, text.ifempty(Name, RP.EmptySymbol), text.ifempty(Symbol, RP.EmptySymbol));

        public override string ToString()
            => Format();

        public static AsmSigOpToken Empty => default;
    }
}
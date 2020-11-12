//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct AsmOpCodeTokens
    {
        readonly TableSpan<AsmOpCodeToken> Data;

        [MethodImpl(Inline)]
        public AsmOpCodeTokens(AsmOpCodeToken[] src)
        {
            Data = src;
        }

        public ref readonly AsmOpCodeToken this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref readonly AsmOpCodeToken this[AsmOpCodeTokenKind index]
        {
            [MethodImpl(Inline)]
            get => ref Data[(byte)index];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
    }

    public readonly struct AsmOpCodeSymbol : ISymbol<char>
    {
        public char Value {get;}

        [MethodImpl(Inline)]
        public AsmOpCodeSymbol(char src)
            => Value = src;

        [MethodImpl(Inline)]
        public static implicit operator AsmOpCodeSymbol(char src)
            => new AsmOpCodeSymbol(src);
    }

    public unsafe readonly struct AsmOpCodeToken
    {
        readonly Ref<char> Source;

        public byte Index {get;}

        public AsmOpCodeTokenKind Id {get;}


        [MethodImpl(Inline)]
        public AsmOpCodeToken(byte index, AsmOpCodeTokenKind id, Ref<char> src)
        {
            Index = index;
            Source = src;
            Id = id;
        }

        public ReadOnlySpan<char> Symbols
        {
            [MethodImpl(Inline)]
            get => cover<char>(Source.Address, Source.CellCount);
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    using api = AsciSymbols;

    /// <summary>
    /// Covers a sequence of asci-encoded bytes
    /// </summary>
    public readonly struct AsciSequence : IAsciSeq
    {
        readonly BinaryCode Data;

        public int Length  {get;}

        public AsciSequence(BinaryCode src)
        {
            Data = src;
            Length = api.length(src.View);
        }

        public int Capacity
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public byte[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public ReadOnlySpan<AsciCode> Codes
        {
            [MethodImpl(Inline)]
            get => recover<byte,AsciCode>(View);
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public TextBlock Text
        {
            [MethodImpl(Inline)]
            get => Format();
        }

        public string Format()
            => AsciSymbols.format(this);

        public override string ToString()
            => Format();
    }
}
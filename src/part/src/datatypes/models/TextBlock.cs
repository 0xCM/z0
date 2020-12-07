//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [Datatype]
    public readonly struct TextBlock : ITextBlock<char>
    {
        public string Text {get;}

        [MethodImpl(Inline)]
        public TextBlock(string src)
            => Text = src;

        public uint Length
        {
            [MethodImpl(Inline)]
            get => (uint)Text.Length;
        }

        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
            get => Text;
        }

        public BitSize StorageWidth
        {
            [MethodImpl(Inline)]
            get => (Text.Length * 2)*8;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Text;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator TextBlock(string src)
            => new TextBlock(src);

        [MethodImpl(Inline)]
        public static implicit operator string(TextBlock src)
            => src.Text;
    }
}
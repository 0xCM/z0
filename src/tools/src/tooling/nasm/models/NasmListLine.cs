//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Tooling
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct NasmListLine : ITextual
    {
        public const byte DataWidth = 40;

        public TextLine Text {get;}

        [MethodImpl(Inline)]
        public NasmListLine(TextLine text)
        {
            Text = text;
        }

        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
            get => Text.Data;
        }

        public string Content
        {
            [MethodImpl(Inline)]
            get => Text.Content;
        }

        public uint LineNumber
        {
            [MethodImpl(Inline)]
            get => Text.LineNumber;
        }
        public string Format()
            => Text.Format();

        public override string ToString()
            => Format();
    }
}
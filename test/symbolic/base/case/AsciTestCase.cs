//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsciTestCase : IAsciTestCase
    {
        public TextBlock Text {get;}

        public Name CaseName {get;}

        readonly Index<TextBlock> StringData;

        [MethodImpl(Inline)]
        public AsciTestCase(Name name, TextBlock text, Index<TextBlock> strings)
        {
            Text = text;
            CaseName = name;
            StringData = strings;
        }

        public ReadOnlySpan<TextBlock> Strings
        {
            [MethodImpl(Inline)]
            get => StringData;
        }

        public ReadOnlySpan<char> Chars
        {
            [MethodImpl(Inline)]
            get => Text.View;
        }

        public int StringCount
        {
            [MethodImpl(Inline)]
            get => Strings.Length;
        }

        public int CharCount
        {
            [MethodImpl(Inline)]
            get => Chars.Length;
        }

        public static implicit operator TestCase<TextBlock>(AsciTestCase src)
            => new TestCase<TextBlock>(src.CaseName, src.StringData);
    }
}
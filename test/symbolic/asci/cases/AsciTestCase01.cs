//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    readonly struct AsciTestCase01 : IAsciTestCase<AsciTestCase01>
    {
        const string s0 = "0123456789";

        const string s1 = "abcdefghijklmnopqrstuvwxyz";

        const string s2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        const string s3 = "!@#$%^&*(){}[]<>";

        const string S
            = s0 + s1 + s2 + s3;

        static string[] StringData
            => new string[4]{s0,s1,s2,s3};

        static Index<TextBlock> Blocks
            => root.map(StringData, s => new TextBlock(s));

        [MethodImpl(Inline)]
        public static implicit operator AsciTestCase(AsciTestCase01 src)
            => new AsciTestCase(nameof(AsciTestCase01), S, Blocks);

        public ReadOnlySpan<string> Strings
            => StringData;

        public ReadOnlySpan<char> Chars
            => S;

        public TextBlock Text
            => S;

        public int StringCount
            => Strings.Length;

        public int CharCount
            => Chars.Length;


        ReadOnlySpan<TextBlock> IAsciTestCase.Strings
            => Blocks.View;

        public Name CaseName => nameof(AsciTestCase01);


        public Index<TextBlock> CaseData
            => Blocks;
    }
}
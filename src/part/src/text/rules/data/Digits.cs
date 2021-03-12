//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static memory;

    partial struct TextRules
    {
        partial struct Data
        {
            public static ReadOnlySpan<char> Digits => span("0123456789");

            public static ReadOnlySpan<char> UppercaseLetters => span("ABCDEFGHIJKLMNOPQRSTUVWXYZ");

            public static ReadOnlySpan<char> LowercaseLetters => span("abcdefghijklmnopqrstuvwxyz");
        }
    }
}

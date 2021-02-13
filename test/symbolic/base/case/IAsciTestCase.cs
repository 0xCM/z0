//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IAsciTestCase : ITestCase
    {
        TextBlock Text {get;}

        ReadOnlySpan<TextBlock> Strings {get;}

        ReadOnlySpan<char> Chars
            => Text.View;

        int StringCount
            => Strings.Length;

        int CharCount
            => Chars.Length;
    }


    public interface IAsciTestCase<T> : IAsciTestCase, ITestCase<TextBlock>
        where T: unmanaged, IAsciTestCase<T>
    {

    }
}
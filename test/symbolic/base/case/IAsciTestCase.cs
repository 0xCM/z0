//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IAsciTestCase : ITestCase
    {        
        string Text {get;}
        
        ReadOnlySpan<string> Strings {get;}

        ReadOnlySpan<char> Chars 
            => Text;

        int StringCount
            => Strings.Length;

        int CharCount
            => Chars.Length;
    }


    public interface IAsciTestCase<T> : IAsciTestCase, ITestCase<T>
        where T: unmanaged, IAsciTestCase<T>
    {        
        
    }
}
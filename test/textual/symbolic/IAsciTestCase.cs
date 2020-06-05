//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public interface IAsciTestCase
    {
        string CaseName {get;}
        
        string Text {get;}
        
        ReadOnlySpan<string> Strings {get;}

        ReadOnlySpan<char> Chars 
            => Text;

        int StringCount
            => Strings.Length;

        int CharCount
            => Chars.Length;
    }

    public interface IAsciTestCase<T> : IAsciTestCase
        where T: unmanaged, IAsciTestCase<T>
    {        
        string IAsciTestCase.CaseName => typeof(T).Name;
    }
}
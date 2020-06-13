//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsciTestCase : IAsciTestCase
    {        
        public string Text {get;}

        public string CaseName {get;}

        readonly string[] StringData;

        [MethodImpl(Inline)]
        public AsciTestCase(string name, string text, string[] strings)
        {
            Text = text;
            CaseName = name;
            StringData = strings;
        }
        
        public ReadOnlySpan<string> Strings
        {
            [MethodImpl(Inline)]
            get => StringData;
        }

        public ReadOnlySpan<char> Chars 
        {
            [MethodImpl(Inline)]
            get => Text;
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
    }
}
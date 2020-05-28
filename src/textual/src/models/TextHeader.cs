//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    
    /// <summary>
    /// Defines header content in a text data file
    /// </summary>
    public readonly struct TextHeader
    {        
        public static TextHeader Empty => new TextHeader();
        
        public readonly string[] HeaderNames;

        public TextHeader(params string[] src)
        {
            HeaderNames = src;
        }

        public string Format(char? sep = null)
            => string.Join(sep ?? Chars.Pipe, HeaderNames);

        public override string ToString()
            => Format();
    }
}
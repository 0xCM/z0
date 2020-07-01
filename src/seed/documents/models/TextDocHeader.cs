//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Defines header content in a text data file
    /// </summary>
    public readonly struct TextDocHeader
    {                
        public readonly string[] Labels;

        [MethodImpl(Inline)]
        public TextDocHeader(params string[] src)  
            => Labels = src;

        public string Format(char? sep = null)
            => string.Join(sep ?? Chars.Pipe, Labels);

        public override string ToString()
            => Format();

        public static TextDocHeader Empty 
            => new TextDocHeader();
    }
}
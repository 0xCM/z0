//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    /// <summary>
    /// Defines header content in a text data file
    /// </summary>
    public sealed class TextHeader
    {        
        string[] Names;

        public TextHeader(params string[] Names)
        {
            this.Names = Names;
        }

        public ReadOnlySpan<string> HeaderNames
            => Names;

        public string Format(char? sep = null)
            => string.Join(sep ?? AsciSym.Pipe, Names);

        public override string ToString()
            => Format();
    }
}
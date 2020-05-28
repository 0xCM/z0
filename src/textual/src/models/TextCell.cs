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
    
    /// <summary>
    /// Defines a text segment in the context of a line in a file
    /// </summary>
    public readonly struct TextCell
    {        
        public uint Row {get;}

        public uint Col {get;}

        public string Content {get;}

        [MethodImpl(Inline)]
        public static implicit operator string(TextCell src)
            => src.Content;
                
        [MethodImpl(Inline)]
        public TextCell(uint Row, uint Col, string Content)
        {
            this.Row = Row;
            this.Col = Col;
            this.Content = insist(Content);
        }        
    }
}
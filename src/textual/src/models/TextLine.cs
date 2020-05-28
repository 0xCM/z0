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
    /// Represents a line of text in the context of a line-oriented text data source
    /// </summary>
    public readonly struct TextLine 
    {            
        public static TextLine Empty => new TextLine(0,string.Empty);

        /// <summary>
        /// The line number of the data source from which the line was extracted
        /// </summary>
        public uint LineNumber {get;}
        
        /// <summary>
        /// The line text, as it was found in the source
        /// </summary>
        public string LineText {get;}

        [MethodImpl(Inline)]
        public static explicit operator TextLine(string text) 
            =>  new TextLine(0, text);

        [MethodImpl(Inline)]
        public static implicit operator string(TextLine line) 
            => line.LineText;

        [MethodImpl(Inline)]
        public TextLine(uint number, string text)
        {
            LineNumber = number;
            LineText = text;
        }
        
        public char? this[int charidx]
        {
            [MethodImpl(Inline)]
            get => charidx + 1 <= LineText.Length ? LineText[charidx] : (char?)null;
        }

        public bool IsEmpty 
            => (LineText?.Length ?? 0) == 0;

        public bool IsBlank
            => string.IsNullOrWhiteSpace(LineText);

        public override string ToString() 
            =>  $"{LineNumber.ToString().PadLeft(10, '0')}:{LineText}";

        public string this[int startpos, int endpos] 
            => LineText.Substring(startpos, endpos - startpos + 1);
    }
}
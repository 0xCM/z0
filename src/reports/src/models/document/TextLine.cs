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
    /// Represents a line of text in the context of a line-oriented text data source
    /// </summary>
    public readonly struct TextLine 
    {            
        public static TextLine Empty => new TextLine(0, string.Empty);

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
            LineText = text ?? string.Empty;
        }
        
        public char this[int charidx]
        {
            [MethodImpl(Inline)]
            get => LineText[charidx];
        }

        public bool StartsWith(char c)
            => IsNonEmpty && LineText[c] == c;

        public bool IsNonEmpty 
        {
            [MethodImpl(Inline)]
            get => !text.empty(LineText);
        }

        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => text.empty(LineText);
        }

        public bool IsBlank 
        {
            [MethodImpl(Inline)]
            get => LineText.Length != 0 && IsEmpty;
        }

        [MethodImpl(Inline)]
        public string[] Split(in TextFormat spec)
            => StartsWith(spec.Delimiter)  
            ? LineText.Substring(1).SplitClean(spec.Delimiter)  
            : LineText.SplitClean(spec.Delimiter);

        public override string ToString() 
            =>  $"{LineNumber.ToString().PadLeft(10, '0')}:{LineText}";

        public string this[int startpos, int endpos] 
            => LineText.Substring(startpos, endpos - startpos + 1);
    }
}
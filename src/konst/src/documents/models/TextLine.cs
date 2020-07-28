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
    public readonly struct TextDocLine 
    {            
        /// <summary>
        /// The line number of the data source from which the line was extracted
        /// </summary>
        public readonly uint LineNumber;
        
        /// <summary>
        /// The line text, as it was found in the source
        /// </summary>
        public readonly string LineText;

        [MethodImpl(Inline)]
        public static explicit operator TextDocLine(string text) 
            =>  new TextDocLine(0, text);

        [MethodImpl(Inline)]
        public static implicit operator string(TextDocLine line) 
            => line.LineText;

        [MethodImpl(Inline)]
        public TextDocLine(uint number, string text)
        {
            LineNumber = number;
            LineText = text ?? EmptyString;
        }
        
        public char this[int charidx]
        {
            [MethodImpl(Inline)]
            get => LineText[charidx];
        }

        public bool IsNonEmpty 
        {
            [MethodImpl(Inline)]
            get => text.nonempty(LineText);
        }

        public bool IsEmpty 
        {
            [MethodImpl(Inline)]
            get => text.blank(LineText);
        }

        public string[] Split(in TextDocFormat spec)
            => IsNonEmpty ? LineText.SplitClean(spec.Delimiter) : sys.empty<string>();
            

        public override string ToString() 
            =>  $"{LineNumber.ToString().PadLeft(10, '0')}:{LineText}";

        public string this[int startpos, int endpos] 
            => LineText.Substring(startpos, endpos - startpos + 1);

        public static TextDocLine Empty 
            => new TextDocLine(0, EmptyString);
    }
}
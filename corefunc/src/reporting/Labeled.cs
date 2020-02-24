//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public static class Labels
    {
        public static Labeled<T> Label<T>(T subject, string label, int lpad = 0, char? lpadChar = null,int rpad = 0, char? rpadChar = null)                
                => new Labeled<T>(subject, label, lpad, lpadChar, rpad, rpadChar);

        public static Labeled<T> Label<T>(T subject, string label,  LabelFormatSpec format)                
                => new Labeled<T>(subject, label, format);
    }
    
    public class LabelFormatSpec
    {
        public LabelFormatSpec()
        {
            LeftPadChar = ' ';
            LeftPadWidth = 0;
            RightPadChar = ' ';
            RightPadWidth = 0;
        }

        public int LeftPadWidth {get; set;}

        public char LeftPadChar {get; set;}

        public int RightPadWidth {get; set;}

        public char RightPadChar {get; set;}

    }    

    /// <summary>
    /// Labels anything
    /// </summary>
    public class Labeled<T> 
    {
        public static implicit operator string(Labeled<T> src)
            => src.ToString();

        public Labeled(T Subject, string Label, 
            int LeftPadCount, char? LeftPadChar,  
            int RightPadCount, char? RightPadChar, 
            Func<T,string> formatter = null
            )
        {
            this.Subject = Subject;
            this.Label = Label;
            this.FormatSpec = new LabelFormatSpec
            {
                LeftPadWidth = LeftPadCount,
                LeftPadChar = LeftPadChar ?? ' ',
                RightPadWidth = RightPadCount,
                RightPadChar = RightPadChar ?? ' '
            };
            this.Formatter = formatter;
        }

        public Labeled(T Subject, string Label, LabelFormatSpec FormatSpec, Func<T,string> formatter = null)
        {
            this.Subject = Subject;
            this.Label = Label;
            this.FormatSpec = FormatSpec;
            this.Formatter = formatter;
        }

        public T Subject {get;}            

        public string Label {get;}

        public LabelFormatSpec FormatSpec {get;}

        Option<Func<T,string>> Formatter {get;}
        
        public string Format()
        {
            var format = $"{Label}: ";
            if(FormatSpec.LeftPadWidth != 0)
                format = format.PadLeft(FormatSpec.LeftPadWidth, FormatSpec.LeftPadChar);
            if(FormatSpec.RightPadWidth != 0)
                format = format.PadRight(FormatSpec.RightPadWidth, FormatSpec.RightPadChar);

            var subjectFormat = Formatter.MapValueOrElse(f => f(Subject), () => Subject.ToString());
            return $"{format}{subjectFormat}";

        }

        public override string ToString()
            => Format();

    }


}
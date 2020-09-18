//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [AttributeUsage(AttributeTargets.Field)]
    public class FormatPatternAttribute : StringLiteralAttribute
    {
        public FormatPatternAttribute(string pattern)
            : base(pattern)
        {

        }

        public FormatPatternAttribute()
            : base("")
        {

        }

        public FormatPatternAttribute(byte args)
        {
            ArgCount = args;
        }

        public FormatPatternAttribute(byte args, string pattern)
            : base(pattern)
        {
            ArgCount = args;

        }

        public byte ArgCount {get;}

        public string PatternText => Text;
    }
}
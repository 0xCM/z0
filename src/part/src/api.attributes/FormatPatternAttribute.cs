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
        public FormatPatternAttribute(string src)
            : base(src)
        {

        }

        public FormatPatternAttribute()
            : base("")
        {

        }
    }
}
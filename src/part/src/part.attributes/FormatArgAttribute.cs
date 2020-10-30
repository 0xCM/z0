//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [AttributeUsage(AttributeTargets.Field)]
    public class FormatArgAttribute : StringLiteralAttribute
    {
        public FormatArgAttribute(byte position, string pattern)
            : base(pattern)
        {
            Position = position;
        }

        public byte Position {get;}

        public string Pattern => base.Text;
    }
}
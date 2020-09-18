//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class NumericFormatCodeAttribute : FormatCodeAttribute
    {
        public NumericFormatCodeAttribute()
        {

        }

        public NumericFormatCodeAttribute(char code)
            : base(FormatCodeKind.Numeric, code)
        {

        }

        public NumericFormatCodeAttribute(string code)
            : base(FormatCodeKind.Numeric, code)
        {

        }

        public NumericFormatCodeAttribute(object code)
            : base(FormatCodeKind.Numeric, code)
        {

        }

    }
}
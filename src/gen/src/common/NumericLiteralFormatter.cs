//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    using F = NumericLiteralField;

    public enum NumericLiteralField : uint
    {
        Name = 0,

        Base = 1,

        Data = 2,

        Text = 3,

    }

    public readonly struct NumericLiteralFormatter : IValueFormatter<NumericLiteral>
    {
        public string Format(in NumericLiteral src)
        {
            var dst = Tabular.Formatter<NumericLiteralField>();
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.Base, src.Base);
            dst.Delimit(F.Data, src.Data);
            dst.Delimit(F.Text, src.Text);
            return dst;
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = NumericLiteralField;
    using R = NumericLiteral;

    public readonly struct NumericLiteralFormatter : IValueFormatter<F,R>
    {
        public static ValueFormatter<F,R> Service
            => DataFormatters.from(default(NumericLiteralFormatter));

        static string Format(Base2 @base, NumericLiteral src)
            => Render.bits(src.Data, src.TypeCode);

        public void Format(in R src, IDatasetFormatter<F> dst)
        {
            dst.Delimit(NumericLiteralField.Name, src.Name);
            dst.Delimit(NumericLiteralField.Base, src.Base);
            dst.Delimit(NumericLiteralField.Data, Format(base2, src));
            dst.Delimit(NumericLiteralField.Text, src.Text);
        }
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using F = NumericLiteralField;
    using R = NumericLiteral;

    public readonly struct NumericLiteralFormatter : ITextValueFormatter<F,R>
    {
        public void Format(in R src, DatasetFormatter<F> dst)
        {
            dst.Delimit(NumericLiteralField.Name, src.Name);
            dst.Delimit(NumericLiteralField.Base, src.Base);
            dst.Delimit(NumericLiteralField.Data, Format(base2, src));
            dst.Delimit(NumericLiteralField.Text, src.Text);
        }

        public string Format(in R src)
        {
            var dst = Formatters.dataset<F>();
            Format(src, dst);
            return dst.Render();
        }

        public string HeaderText
            => Formatters.dataset<F>().HeaderText;

        public void Format(in R src, DatasetFormatter<F> dst, bool eol)
        {
            Format(src, dst);
            if(eol)
                dst.EmitEol();
        }

        static string Format(Base2 @base, NumericLiteral src)
            => BitFormatter.format(src.Data, src.TypeCode);

        void ITextValueFormatter<F,R>.Format(in R src, IDatasetFormatter<F> dst)
        {
            dst.Delimit(NumericLiteralField.Name, src.Name);
            dst.Delimit(NumericLiteralField.Base, src.Base);
            dst.Delimit(NumericLiteralField.Data, Format(base2, src));
            dst.Delimit(NumericLiteralField.Text, src.Text);
        }
    }
}
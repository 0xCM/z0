//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using R = BitMaskRow;
    using F = NumericLiteralField;

    public readonly struct BitMaskFormatter : IValueFormatter<F,R>
    {
        public void Format(in R src, DatasetFormatter<F> dst)
        {
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.Base, src.Base);
            dst.Delimit(F.Data, Format(base2, src));
            dst.Delimit(F.Text, src.Text);
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

        static string Format(Base2 @base, BitMaskRow src)
            => Render.bits(src.Data, src.TypeCode);

        void IValueFormatter<F,R>.Format(in R src, IDatasetFormatter<F> dst)
        {
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.Base, src.Base);
            dst.Delimit(F.Data, Format(base2, src));
            dst.Delimit(F.Text, src.Text);
        }
    }
}
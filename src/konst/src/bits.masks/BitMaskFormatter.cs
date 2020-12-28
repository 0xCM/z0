//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using R = BitMaskInfo;
    using F = NumericLiteralField;

    public readonly struct BitMaskFormatter : ITextValueFormatter<F,R>
    {
        public void Format(in R src, DatasetFormatter<F> dst)
            => render(src,dst);

        public string Format(in R src)
        {
            var dst = Formatters.dataset<F>();
            Format(src, dst);
            return dst.Render();
        }

        public string HeaderText
            => Formatters.dataset<F>().HeaderText;

        void ITextValueFormatter<F,R>.Format(in R src, IDatasetFormatter<F> dst)
            => render(src,dst);

        [MethodImpl(Inline), Op]
        static void render(in BitMaskInfo src, IDatasetFormatter<F> dst)
        {
            dst.Delimit(F.Name, src.Name);
            dst.Delimit(F.Base, src.Base);
            dst.Delimit(F.Data, format(base2, src));
            dst.Delimit(F.Text, src.Text);
        }

        static string format(Base2 @base, BitMaskInfo src)
            => BitFormatter.format(src.Data, src.TypeCode);
    }
}
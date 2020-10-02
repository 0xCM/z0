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
            => BitMasks.render(src,dst);

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

        void IValueFormatter<F,R>.Format(in R src, IDatasetFormatter<F> dst)
            => BitMasks.render(src,dst);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;

    using static Konst;

    public readonly struct ValueFormatter<F,T>
        where F : unmanaged, Enum
        where T : struct
    {
        readonly IValueFormatter<F,T> Formatter;

        [MethodImpl(Inline)]
        public ValueFormatter(IValueFormatter<F,T> formatter)
        {
            Formatter = formatter;
        }

        [MethodImpl(Inline)]
        public string Format(in T src)
            => Formatter.Format(src);

        public string HeaderText
            => Datasets.header<F>().Render();
    }
}
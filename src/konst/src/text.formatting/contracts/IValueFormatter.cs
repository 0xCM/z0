//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public interface IValueFormatter<T> : ITextFormatter<T>
        where T : struct
    {
        string Format(in T src);

        string IFormatter<T,string>.Format(T src)
            => Format(src);

        string HeaderText {get;}
    }

    public interface IValueFormatter<F,T> : IValueFormatter<T>
        where F : unmanaged, Enum
        where T : struct
    {
        void Format(in T src, IDatasetFormatter<F> dst);

        void Format(in T src, IDatasetFormatter<F> dst, bool eol)
        {
            Format(src, dst);
            if(eol)
                dst.EmitEol();
        }

        string IValueFormatter<T>.Format(in T src)
        {
            var dst = Formatters.dataset<F>();
            Format(src, dst);
            return dst.Render();
        }

        string IValueFormatter<T>.HeaderText
            => Formatters.dataset<F>().HeaderText;
    }
}
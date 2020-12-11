//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITextValueFormatter<T> : ITextFormatter<T>
        where T : struct
    {
        string Format(in T src);

        string IFormatter<T,string>.Format(T src)
            => Format(src);

        string HeaderText {get;}
    }
}
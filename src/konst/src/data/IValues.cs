//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public interface IValues<F,T> : INullity
        where F : IValues<F,T>, new()
    {
        ReadOnlySpan<T> View {get;}

        Span<T> Edit {get;}

        ref T this[long index]
        {
            get => ref Edit[(int)index];
        }

        ref T this[ulong index]
        {
            get => ref Edit[(int)index];
        }

        bool INullity.IsEmpty
            => View.IsEmpty;
    }
}
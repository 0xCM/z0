// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;

    using static memory;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IIndex<T> : IMeasured, IEnumerable<T>, ITextual
    {
        T[] Storage {get;}

        char CellDelimiter
            => Chars.Semicolon;
        string ITextual.Format()
            => string.Format("({0}:{1})*", typeof(T).Name, Storage?.Length ?? 0);
        Span<T> Terms
            => Storage;

        Span<T> Edit
            => Storage;

        ReadOnlySpan<T> View
            => Storage;

        int IMeasured.Length
            => Storage?.Length ?? 0;

        ref T this[int index]
            => ref seek(Storage,index);

        ref T Lookup(int index)
            => ref seek(Storage, index);

        ref T First
            => ref first(Storage);

        ref T Last
            => ref seek(Storage,Length - 1);

        bool INullity.IsEmpty
            => Length == 0;

        IEnumerator IEnumerable.GetEnumerator()
            => Storage.GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => Storage.ToList().GetEnumerator();
    }

    public interface IIndex<I,T> : IIndex<T>
        where I : unmanaged
    {
        ref T this[I index] {get;}

        ref T IIndex<T>.this[int index]
            => ref this[memory.@as<int,I>(index)];

        ref T Lookup(I index)
            => ref this[index];
    }

    public interface IIndex<H,I,T> : IIndex<I,T>
        where I : unmanaged
        where H : struct, IIndex<H,I,T>
    {

    }
}
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IIndex<T> : IMeasured, IEnumerable<T>
    {
        T[] Storage {get;}

        Span<T> Terms
            => Storage;

        int IMeasured.Length
            => Storage.Length;

        ref T this[int index]
            => ref Storage[index];

        ref T Lookup(int index)
            => ref this[index];

        ref T First
            => ref this[0];

        ref T Last
            => ref this[Length - 1];

        bool INullity.IsEmpty
            => false;

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
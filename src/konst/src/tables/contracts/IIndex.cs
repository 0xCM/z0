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

        Span<T> Terms {get;}

        int IMeasured.Length
            => Storage.Length;

        Deferred<T> Deferred
            => new Deferred<T>(Storage);

        ref T this[int index] {get;}

        ref T Lookup(int index)
            => ref this[index];

        ref T First
            => ref this[0];

        ref T Last
            => ref this[Length - 1];

        bool INullity.IsEmpty
            => false;

        IEnumerator IEnumerable.GetEnumerator()
            => Deferred.Content.GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => Deferred.ToList().GetEnumerator();
    }

    public interface IIndex<I,T> : IIndex<T>
        where I : unmanaged
    {
        ref T this[I index]
            => ref this[z.i32(index)];

        ref T Lookup(I index)
            => ref this[index];
    }

    public interface IIndex<H,I,T> : IIndex<I,T>
        where I : unmanaged
        where H : struct, IIndex<H,I,T>
    {

    }
}
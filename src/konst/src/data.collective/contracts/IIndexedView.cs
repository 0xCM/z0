//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IIndexedView<T> : IMeasured
    {
        ref readonly T Lookup(int index);

        ref readonly T this[int index]
            => ref Lookup(index);
    }

    [Free]
    public interface IIndexedView<E,T> : IIndexedView<T>
        where E : unmanaged, Enum
    {
        ref readonly T Lookup(E index);

        ref readonly T this[E index]
            => ref Lookup(index);

        ref readonly T IIndexedView<T>.Lookup(int index)
            => ref Lookup(Enums.literal<E>(index));
    }
}
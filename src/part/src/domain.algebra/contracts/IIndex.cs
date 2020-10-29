//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a <typeparamref name='K'/> indexed sequence of at most <typeparamref name='M'/> readonly <typeparamref name='T'/> terms
    /// </summary>
    /// <typeparam name="K">The accessor type</typeparam>
    /// <typeparam name="M">The measure type</typeparam>
    /// <typeparam name="T">The term type</typeparam>
    [Free]
    public interface IConstIndex<K,M,T> : IMeasured<M>
        where K : unmanaged
        where M : unmanaged
    {
        ref readonly T this[K index] {get;}

        ref readonly T Lookup(K index)
            => ref this[index];
    }

    /// <summary>
    /// Characterizes a <typeparamref name='K'/> indexed sequence of at most <typeparamref name='M'/> mutable <typeparamref name='T'/> terms
    /// </summary>
    /// <typeparam name="K">The accessor type</typeparam>
    /// <typeparam name="M">The measure type</typeparam>
    /// <typeparam name="T">The term type</typeparam>
    [Free]
    public interface IIndex<K,M,T> : IConstIndex<K,M,T>
        where K : unmanaged
        where M : unmanaged
    {
        new ref T this[K index] {get;}

        new ref T Lookup(K index)
            => ref this[index];

        ref readonly T IConstIndex<K,M,T>.this[K index]
            => ref Lookup(index);

        ref readonly T IConstIndex<K,M,T>.Lookup(K index)
            => ref Lookup(index);
    }
}
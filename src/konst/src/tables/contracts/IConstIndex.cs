// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IConstIndex<T> : IMeasured
    {
        ref readonly T this[int index] {get;}

        ref readonly T this[ulong index]
            => ref this[(int)index];

        ref readonly T Lookup(int index)
            => ref this[index];

        ref readonly T Lookup(ulong index)
            => ref this[index];
    }

    /// <summary>
    /// Characterizes a <typeparamref name='K'/> indexed sequence of readonly <typeparamref name='T'/> terms
    /// </summary>
    /// <typeparam name="K">The accessor type</typeparam>
    /// <typeparam name="M">The measure type</typeparam>
    /// <typeparam name="T">The term type</typeparam>
    [Free]
    public interface IConstIndex<H,K,T> : IConstIndex<T>
        where K : unmanaged
        where H : struct, IConstIndex<H,K,T>
    {
        ref readonly T this[K index] {get;}

        ref readonly T Lookup(K index)
            => ref this[index];
    }
}
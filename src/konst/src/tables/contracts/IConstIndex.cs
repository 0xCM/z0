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
}
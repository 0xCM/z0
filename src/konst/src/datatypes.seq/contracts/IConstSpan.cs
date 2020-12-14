// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IMaterialied<T> : IFinite, IContented<T>, IContentIndex<T>
    {

    }

    [Free]
    public interface IMaterialized<F,T> : IMaterialied<T>
        where T : IFiniteDeferral<T>
        where F : IMaterialized<F,T>, new()
    {
        /// <summary>
        /// Replaces materialized content forced from a source
        /// </summary>
        /// <param name="src"></param>
        F Redefine(T src);
    }

    [Free]
    public interface IConstSpan<F,T> : IMeasured, INullary<F,T>
        where F : IConstSpan<F,T>, new()
    {
        ReadOnlySpan<T> Data {get;}

        ReadOnlySpan<T>.Enumerator GetEnumerator()
            => Data.GetEnumerator();

        bool INullity.IsEmpty
            => Data.Length == 0;

        ref readonly T this[int index]
            => ref Data[index];

        ref readonly T Lookup(int index)
            => ref this[index];

        int IMeasured.Length
            => Data.Length;
    }
}
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IConstSpan<F,T> : IMeasured, IReified<F>, INullary<F,T>
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
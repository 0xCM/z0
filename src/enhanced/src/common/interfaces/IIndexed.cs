// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;

    using static Konst;

    public interface IDataIndex<T> : IMeasured
    {
    
    }

    public interface IReadOnlyIndex<T> : IDataIndex<T>
    {
        ref readonly T this[int index] {get;}  

        ref readonly T Lookup(int index) 
            => ref this[index];    
    }

    /// <summary>
    /// Characterizes a finite container over sequentially-indexed discrete content - an array
    /// </summary>
    /// <typeparam name="T">The element type</typeparam>
    public interface IIndex<T> : IContented<T[]>, IMeasured, IEnumerable<T>
    {
        IEnumerator IEnumerable.GetEnumerator()
            => Content.GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => Content.ToList().GetEnumerator();

        int IMeasured.Length
            => Content?.Length ?? 0;

        ref T this[int index]
            => ref Content[index];

        ref T Lookup(int index) 
            => ref this[index];
    }
    
    public interface IIndex<F,T> : IIndex<T>, IReified<F>, INullary<F,T>
        where F : IIndex<F,T>, new()
    {
        bool INullity.IsEmpty 
            => Content?.Length == 0;
    }

    public interface INonEmptyIndex<T> : IIndex<T>
    {
        ref T Head {get;}

        ref T Tail {get;}
    }
}
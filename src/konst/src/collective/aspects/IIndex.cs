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

    public interface IConstIndex<T> : IDataIndex<T>
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
   
    public interface INonEmptyIndex<T> : IIndex<T>
    {
        ref T Head 
            => ref this[0];

        ref T Tail 
            => ref this[Length - 1];
    }

    /// <summary>
    /// Characterizes a reifed finite nonempty index
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    /// <typeparam name="T">The sequence element type</typeparam>
    public interface IIndex<F,T> : IIndex<T>, IReified<F>, INullary<F,T>, INonEmptyIndex<T>, IReversible<F,T> 
        where F : IIndex<F,T>, new()
    {
        bool INullity.IsEmpty 
            => Content?.Length == 0;

        F IReversible<F,T>.Reverse()
        {
            Array.Reverse(Content);
            return (F)this;
        }
    }    
}
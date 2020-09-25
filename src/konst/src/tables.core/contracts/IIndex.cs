// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Security;

    using static Konst;
    
    public interface IIndex<T> : IMeasured, IEnumerable<T>
    {
        ref T this[int index] {get;}  

        ref T Lookup(int index) 
            => ref this[index];    

        ref T First
            => ref this[0];

        ref T Last 
            => ref this[Length - 1];

        bool INullity.IsEmpty 
            => false;

        IEnumerable<T> Deferred
        {
            get
            {  var count = Count;
                if(count != 0) 
                {
                    for(var i=0; i<count; i++)
                        yield return z.skip(First,i);

                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => Deferred.GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => Deferred.ToList().GetEnumerator();
    }
       
    /// <summary>
    /// Characterizes a reified finite nonempty index
    /// </summary>
    /// <typeparam name="S">The reifying type</typeparam>
    /// <typeparam name="T">The sequence element type</typeparam>
    public interface IIndex<F,T> : IContentIndex<T>, IReified<F>, INullary<F,T>, IReversible<F,T> 
        where F : IIndex<F,T>, new()
    {
        bool INullity.IsEmpty 
            => false;

        F IReversible<F,T>.Reverse()
        {
            Array.Reverse(Content);
            return (F)this;
        }
    }    
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Collections;

    using static Seed;

    public interface IEnumerableArray<T> : IEnumerable<T>
    {
        T[] Data {get;}

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => Data.AsEnumerable().GetEnumerator();
        
        IEnumerator IEnumerable.GetEnumerator() 
            => Data.GetEnumerator();
    }
}
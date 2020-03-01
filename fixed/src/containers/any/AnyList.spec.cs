//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Root;


    public interface IAnyList<T>
    {

    }

    public interface IAnyListProvider<T> : IEnumerable<T>
    {
        AnyList<T> Items {get;}

        IEnumerator IEnumerable.GetEnumerator()
            => Items.GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => Items.GetEnumerator();
    }

    public interface IAnyListProvider<P,T> : IAnyListProvider<T>
        where P : IAnyListProvider<P,T>, new()
    {
        Func<T[],P> Factory {get;}

        public static P Empty => Create();

        public static P Create(params T[] src) => Empty.Factory(src);
    }

}
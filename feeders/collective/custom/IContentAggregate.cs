//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public interface IContentAggregate 
    {
        IEnumerable<object> Items {get;}

    }

    public interface IContentAggregate<T> : IContentAggregate, IEnumerable<T>
    {
        new IEnumerable<T> Items {get;}

        IEnumerable<object> IContentAggregate.Items
            => Items.Cast<object>();

        IEnumerator IEnumerable.GetEnumerator()
            => Items.GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
            => Items.ToList().GetEnumerator();
    }
}
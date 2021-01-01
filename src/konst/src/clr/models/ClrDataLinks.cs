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

    /// <summary>
    /// Defines a collection of directed member associations
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public sealed class ClrDataLinks<S,T> : IEnumerable<ClrDataLink>
    {
        HashSet<ClrDataLink> Associations {get;}

        public ClrDataLinks(IEnumerable<ClrDataLink> associations)
            => Associations = associations.ToHashSet();

        public IEnumerator<ClrDataLink> GetEnumerator()
            => Associations.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => Associations.GetEnumerator();
    }
}
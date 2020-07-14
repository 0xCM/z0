//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;

    /// <summary>
    /// Defines a collection of directed member associations
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public sealed class DataMemberArrows<S,T> : IEnumerable<DataMemberArrow>
    {
        HashSet<DataMemberArrow> Associations { get; }

        public DataMemberArrows(IEnumerable<DataMemberArrow> associations)
            => Associations = associations.ToHashSet();

        public IEnumerator<DataMemberArrow> GetEnumerator()
            => Associations.GetEnumerator();
        
        IEnumerator IEnumerable.GetEnumerator()
            => Associations.GetEnumerator();
    }
}
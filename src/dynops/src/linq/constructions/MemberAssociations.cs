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

    using static Seed;
    using static Memories;

    /// <summary>
    /// Defines a collection of directed member associations
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public sealed class MemberAssociations<S,T> : IEnumerable<MemberAssociation>
    {
        HashSet<MemberAssociation> Associations { get; }

        public MemberAssociations(IEnumerable<MemberAssociation> associations)
            => Associations = associations.ToHashSet();

        public IEnumerator<MemberAssociation> GetEnumerator()
            => Associations.GetEnumerator();
        
        IEnumerator IEnumerable.GetEnumerator()
            => Associations.GetEnumerator();
    }
}
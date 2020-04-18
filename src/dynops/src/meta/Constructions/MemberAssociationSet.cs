//-------------------------------------------------------------------------------------------
// MetaCore
// Author: Chris Moore, 0xCM@gmail.com
// License: MIT
//-------------------------------------------------------------------------------------------
namespace Meta.Core
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;

    using Z0;
    using static Z0.Seed;
    using static Z0.Memories;

    /// <summary>
    /// Defines a collection of <see cref="MemberAssociation"/> values directed from <typeparamref name="S"/> to <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="S">The source type</typeparam>
    /// <typeparam name="T">The target type</typeparam>
    public sealed class MemberAssociationSet<S,T> : IEnumerable<MemberAssociation>
    {
        HashSet<MemberAssociation> Associations { get; }

        public MemberAssociationSet(IEnumerable<MemberAssociation> associations)
            => Associations = associations.ToHashSet();

        public IEnumerator<MemberAssociation> GetEnumerator()
            => Associations.GetEnumerator();
        
        IEnumerator IEnumerable.GetEnumerator()
            => Associations.GetEnumerator();
    }
}
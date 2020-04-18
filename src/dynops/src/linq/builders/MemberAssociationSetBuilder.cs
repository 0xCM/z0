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
    using System.Linq.Expressions;
    using System.Reflection;

    using Z0;
    using static Z0.Seed;
    using static Z0.Memories;
    using static Z0.XPressive;
    using static Z0.XFunc;

    public static class MemberAssociationSetBuilder
    {
        public static MemberAssociationSetBuilder<S, T> Build<S, T>()
            => new MemberAssociationSetBuilder<S, T>();
    }

    public class MemberAssociationSetBuilder<S, T>
    {
        public static implicit operator MemberAssociationSet<S, T>(MemberAssociationSetBuilder<S, T> builder)
            => builder.Complete();

        HashSet<MemberAssociation> Associations { get; } 
            = new HashSet<MemberAssociation>();

        public MemberAssociationSetBuilder<S, T> Associate(Expression<Func<S, object>> s, Expression<Func<T, object>> t)
        {
            Associations.Add(MemberAssociation.Associate(s, t));
            return this;
        }

        public MemberAssociationSetBuilder<S, T> Associate(params
            (Expression<Func<S, object>> SourceMember, Expression<Func<T, object>> TargetMember)[] pairs)
        {
            foreach (var association in pairs.Select(p => MemberAssociation.Associate(p.SourceMember, p.TargetMember)))
                Associations.Add(association);
            return this;
        }

        public MemberAssociationSet<S, T> Complete()
            => new MemberAssociationSet<S, T>(Associations);
    }
}
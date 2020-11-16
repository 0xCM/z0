//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    using static MemberDependencies;

    public static class MemberDependencies
    {
        public static ClrDataLink<S,T> define<S,T>(Expression<Func<S,object>> s, Expression<Func<T,object>> t)
            => new ClrDataLink<S,T>(s.GetDataMember(), t.GetDataMember());

        public static MemberDependencyBuilder<S,T> build<S,T>()
            => new MemberDependencyBuilder<S,T>();
    }

    public class MemberDependencyBuilder<S,T>
    {
        public static implicit operator ClrDataLinks<S,T>(MemberDependencyBuilder<S, T> builder)
            => builder.Complete();

        HashSet<ClrDataLink> Arrows {get;}
            = new HashSet<ClrDataLink>();

        public MemberDependencyBuilder<S,T> Include(Expression<Func<S, object>> s, Expression<Func<T,object>> t)
        {
            Arrows.Add(define(s, t));
            return this;
        }

        public MemberDependencyBuilder<S,T> Include(params
            (Expression<Func<S,object>> SourceMember, Expression<Func<T, object>> TargetMember)[] pairs)
        {
            foreach (var association in pairs.Select(p => define(p.SourceMember, p.TargetMember)))
                Arrows.Add(association);
            return this;
        }

        public ClrDataLinks<S,T> Complete()
            => new ClrDataLinks<S,T>(Arrows);
    }
}
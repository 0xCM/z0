//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;

    public interface IScope
    {
        IScope Parent {get;}

        IScope NewChild();

        bool IsRoot
            => Parent == null || object.ReferenceEquals(this,Parent);
    }

    public interface IScope<T> : IScope
        where T : IScope
    {
        new T Parent {get;}

        new T NewChild();

        IScope IScope.NewChild()
            => NewChild();

        IScope IScope.Parent
            => Parent;

        IReadOnlyList<T> Children {get;}
    }

    public abstract class Scope<T> : IScope<T>
        where T : IScope
    {
        public T Parent {get; protected set;}

        List<T> _Children {get;}

        public bool IsRoot
            => Parent == null || object.ReferenceEquals(this,Parent);

        public IReadOnlyList<T> Children
            => _Children;

        protected Scope(T parent)
            : this()
        {
            Parent = parent;
        }

        protected Scope()
        {
            _Children = new();
        }

        public abstract T NewChild();

        protected T AddChild(T child)
        {
            _Children.Add(child);
            return child;
        }
    }

    public sealed class Scope : Scope<Scope>
    {
        public Scope(Scope parent)
            : base(parent)
        {

        }

        public Scope()
        {
            Parent = this;
        }

        public override Scope NewChild()
            => AddChild(new Scope(this));
    }
}
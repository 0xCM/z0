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

    public abstract class ScopedContext<T> : IScopedContext<T>
        where T : IScopeContext
    {
        public T Parent {get; protected set;}

        public Scope Scope {get; protected set;}

        List<T> _Children {get;}

        public bool IsRoot
            => Parent == null || object.ReferenceEquals(this,Parent);

        public IReadOnlyList<T> Children
            => _Children;

        protected ScopedContext(Scope scope, T parent)
            : this()
        {
            Parent = parent;
            Scope = scope;
        }

        protected ScopedContext()
        {
            _Children = new();
        }

        public abstract T NewChild(Scope scope);

        protected T AddChild(T child)
        {
            _Children.Add(child);
            return child;
        }
    }
}
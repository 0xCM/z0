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

    public abstract class ScopeContext<T> : IScopeContext<T>
        where T : IScopeContext
    {
        public T Parent {get; protected set;}

        List<T> _Children {get;}

        public bool IsRoot
            => Parent == null || object.ReferenceEquals(this,Parent);

        public IReadOnlyList<T> Children
            => _Children;

        protected ScopeContext(T parent)
            : this()
        {
            Parent = parent;
        }

        protected ScopeContext()
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
}
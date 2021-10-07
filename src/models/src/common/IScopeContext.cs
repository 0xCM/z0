//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IScopeContext
    {
        Scope Scope {get;}

        IScopeContext Parent {get;}

        IScopeContext NewChild(Scope scope);

        bool IsRoot
            => Parent == null || object.ReferenceEquals(this,Parent);
    }

    public interface IScopedContext<T> : IScopeContext
        where T : IScopeContext
    {
        new T Parent {get;}

        new T NewChild(Scope scope);

        IScopeContext IScopeContext.NewChild(Scope scope)
            => NewChild(scope);

        IScopeContext IScopeContext.Parent
            => Parent;
    }
}
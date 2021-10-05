//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IScopeContext
    {
        IScopeContext Parent {get;}

        IScopeContext NewChild();

        bool IsRoot
            => Parent == null || object.ReferenceEquals(this,Parent);
    }

    public interface IScopeContext<T> : IScopeContext
        where T : IScopeContext
    {
        new T Parent {get;}

        new T NewChild();

        IScopeContext IScopeContext.NewChild()
            => NewChild();

        IScopeContext IScopeContext.Parent
            => Parent;
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public sealed class ScopeContext : ScopedContext<ScopeContext>
    {
        public ScopeContext(Scope scope, ScopeContext parent)
            : base(scope, parent)
        {

        }

        public ScopeContext()
        {
            Parent = this;
        }

        public override ScopeContext NewChild(Scope scope)
            => AddChild(new ScopeContext(scope, this));
    }
}
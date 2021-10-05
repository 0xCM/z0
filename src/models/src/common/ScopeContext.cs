//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public sealed class ScopeContext : ScopeContext<ScopeContext>
    {
        public ScopeContext(ScopeContext parent)
            : base(parent)
        {

        }

        public ScopeContext()
        {
            Parent = this;
        }

        public override ScopeContext NewChild()
            => AddChild(new ScopeContext(this));
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [PartExecutor]
    public abstract class PartExecutor<P> : IPartExecutor<P>
        where P : PartExecutor<P>, new()
    {
        public PartId PartId {get;}

        protected PartExecutor()
        {
            PartId = typeof(P).Assembly.Id();
        }

        public abstract void Run();

        public virtual void Run(ExecutorContext context)
            => Run();
    }
}
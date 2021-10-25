//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Expr
{
    public interface IModelContext : IContext<IModelContext>
    {
        IPolyrand Random {get;}
    }

    public abstract class ModelContext<T,C> : IModelContext
        where T : ModelContext<T,C>, new()
    {
        public IPolyrand Random {get; protected set;}

        public static T create(C context)
        {
            var dst = new T();
            dst.Initialize(context);
            return dst;
        }

        protected abstract void Initialize(C context);
    }
}
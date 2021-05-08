//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public abstract class ApiExpr : IApiExpr
    {
        dynamic IApiExpr.Content
            => Untyped;

        protected abstract dynamic Untyped {get;}
    }

    public abstract class ApiExpr<T> : ApiExpr, IApiExpr<T>
        where T : struct
    {

        public abstract T Content {get;}

        protected sealed override dynamic Untyped
            => Content;
    }

    public abstract class ApiExpr<H,T> : ApiExpr<T>
        where H : ApiExpr<H,T>, new()
        where T : struct
    {

    }
}
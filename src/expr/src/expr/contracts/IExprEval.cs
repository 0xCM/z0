//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IExprEval
    {
        dynamic Evaluate(IExpr src);
    }
    
    [Free]
    public interface IExprEval<T> : IExprEval
    {
        new T Evaluate(IExpr src);

        dynamic IExprEval.Evaluate(IExpr src)
            => Evaluate(src);        
    }

    [Free]
    public interface IExprEval<S,T>
        where S : IExpr
    {
        T Evaluate(S src);        
    }    
}
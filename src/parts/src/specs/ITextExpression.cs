//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ITextExpression<F> : IExpressional<F,string>
        where F : struct, ITextExpression<F>
    {
        string Text => Body;
    }
}
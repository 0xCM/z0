//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    public interface INullityOperator : IOperator
    {

    }

    public interface INullityOperator<F> : INullityOperator, IOperator<F>
        where F : INullityOperator<F>
    {

    }

}
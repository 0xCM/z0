//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    public interface IOperator
    {
        string Name { get; }

        string Symbol { get; }

        IOperatorApplication Apply(params object[] args);

        string FormatApply(params object[] args);
    }





}
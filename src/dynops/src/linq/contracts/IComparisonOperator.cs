﻿//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Dynamics
{
    public interface IComparisonOperator : IBinaryOperator
    {

    }

    public interface IComparisonOperator<F> : IComparisonOperator, IBinaryOperator<F>
        where F : IComparisonOperator<F>
    {

    }    
}
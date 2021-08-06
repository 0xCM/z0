//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IEvaluation
    {

    }

    public interface IEvaluation<S,T> : IEvaluation
    {
        S Source {get;}

        T Result {get;}
    }
}
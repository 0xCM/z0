//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface ICorrelated
    {
        CorrelationToken Ct 
            => CorrelationToken.create();
    }

    public interface ICorrelated<F> : ICorrelated
        where F : struct, ICorrelated
    {

    }
}
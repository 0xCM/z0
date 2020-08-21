//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static z;

    public interface ICorrelated
    {
        CorrelationToken Ct
            => correlate(0ul);
    }

    public interface ICorrelated<F> : ICorrelated
        where F : struct, ICorrelated
    {

    }
}
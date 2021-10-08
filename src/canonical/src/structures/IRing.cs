//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    public interface IRing<T> : IAddtiveGroup<T>, IMultiplicativeMonoid<T>, IDistributive<T>
        where T : new()

    {

    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ICorrelated
    {
        CorrelationToken Correlation => CorrelationToken.Empty;
    }
}
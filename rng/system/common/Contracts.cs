//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Concurrent;
    using System.Collections.Generic;

    using static zfunc;

    public interface IDistribution<T> : IEnumerable<T>
        where T : unmanaged
    {
        IEnumerable<T> Sample();
    }

    public interface IDistribution<S,T> : IDistribution<T> 
        where S : IDistributionSpec
        where T : unmanaged
    {
        
    }
}
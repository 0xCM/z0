//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
    public interface IDistributionSpec
    {
        DistKind DistKind {get;}        
    }

    /// <summary>
    /// Characterizes a distribution
    /// </summary>
    /// <typeparam name="T">The sample value type</typeparam>
    public interface IDistributionSpec<T> : IDistributionSpec
        where T : unmanaged
    {
        
    }
}
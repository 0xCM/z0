//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace System
{
    using System.Collections.Generic;
    using Z0;

    /// <summary>
    /// Characterizes a random source that can be navigated
    /// </summary>
    /// <typeparam name="T">The primal element type</typeparam>
    public interface INavigableRng<T> : IBoundPointSource<T>, IRandomNav
        where T : struct
    {

    }

}
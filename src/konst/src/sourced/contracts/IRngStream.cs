//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    /// <summary>
    /// Characterizes a stream of random values of parametric type
    /// </summary>
    /// <typeparam name="T">The random value type</typeparam>
    public interface IRngStream<T> : IRngPointSource<T>, IValueStream<T> 
        where T : struct
    {

    }
}
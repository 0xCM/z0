//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace System
{
    using System.Collections.Generic;
    using Z0;

    /// <summary>
    /// Characterizes source capable of producing an interminable sequence of pseudorandom bounded points 
    /// of any numeric type among: sbyte, byte, short, ushort, int, uint, long, ulong, float, double
    /// </summary>
   public interface IPolyrand : IPolySource,
        IBoundPointSource<sbyte>,
        IBoundPointSource<byte>,
        IBoundPointSource<short>,
        IBoundPointSource<ushort>,
        IBoundPointSource<int>, 
        IBoundPointSource<uint>, 
        IBoundPointSource<long>,
        IBoundPointSource<ulong>, 
        IBoundPointSource<float>,
        IBoundPointSource<double> 
    {
        /// <summary>
        /// Retrieves the random stream navigator, if supported
        /// </summary>
        Option<IRandomNav> Navigator {get;}    
    }

}
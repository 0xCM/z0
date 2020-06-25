//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    /// <summary>
    /// Characterizes source capable of producing an interminable sequence of pseudorandom bounded points 
    /// of any numeric type among: sbyte, byte, short, ushort, int, uint, long, ulong, float, double
    /// </summary>
    public interface IPolyrand : IPolySource,
        IRngBoundPointSource<sbyte>,
        IRngBoundPointSource<byte>,
        IRngBoundPointSource<short>,
        IRngBoundPointSource<ushort>,
        IRngBoundPointSource<int>, 
        IRngBoundPointSource<uint>, 
        IRngBoundPointSource<long>,
        IRngBoundPointSource<ulong>, 
        IRngBoundPointSource<float>,
        IRngBoundPointSource<double> 
    {
        /// <summary>
        /// Retrieves the random stream navigator, if supported
        /// </summary>
        Option<IRngNav> Navigator {get;}    
    } 

    /// <summary>
    /// Characterizes a type that provides access to a stateful and parametric-polymorphic 
    /// pseudorandom number generator
    /// </summary>
    public interface IPolyrandProvider 
    {
        IPolyrand Random {get;}
    }
}
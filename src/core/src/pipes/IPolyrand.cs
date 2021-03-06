//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes source capable of producing an interminable sequence of pseudorandom bounded points
    /// of any numeric type among: sbyte, byte, short, ushort, int, uint, long, ulong, float, double
    /// </summary>
    [Free]
    public interface IPolyrand : IRngSource, IPolySource, IPolySourced
    {
        /// <summary>
        /// Retrieves the random stream navigator, if supported
        /// </summary>
        Option<IRngNav> Navigator {get;}

        IPolySource IPolySourced.Source
            => this;
    }

    /// <summary>
    /// Characterizes a type that provides access to a stateful and parametric-polymorphic
    /// pseudorandom number generator
    /// </summary>
    [Free]
    public interface IPolyrandProvider : ISourceProvider<IPolyrand>
    {
        IPolyrand Random {get;}

        IPolyrand ISourceProvider<IPolyrand>.Source
            => Random;
    }
}
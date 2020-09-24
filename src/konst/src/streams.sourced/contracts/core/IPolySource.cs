//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    /// <summary>
    /// Characterizes a fountain of generic points
    /// </summary>
    [Free]
    public interface IPolySource : IDomainValues, IValueSource
    {
        /// <summary>
        /// Returns the default domain used when producing random points for a parametrically-identified type
        /// </summary>
        /// <typeparam name="T">The point type</typeparam>
        Interval<T> Domain<T>()
            where T : unmanaged;
    }

    [Free]
    public interface IPolySource<T> : IDomainValues<T>, IValueSource<T>
        where T : struct
    {

    }

    [Free]
    public interface IPolySourced : IPolySource,
        IPolySource<sbyte>,
        IPolySource<byte>,
        IPolySource<short>,
        IPolySource<ushort>,
        IPolySource<int>,
        IPolySource<uint>,
        IPolySource<long>,
        IPolySource<ulong>,
        IPolySource<float>,
        IPolySource<double>
    {

    }

    public interface IPolySourceProvider
    {
        IPolySourced Source {get;}
    }
}
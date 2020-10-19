//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

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
}
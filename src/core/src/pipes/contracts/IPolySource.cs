//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IPolySource : IRangeSource,
        IRangeSource<sbyte>,
        IRangeSource<byte>,
        IRangeSource<short>,
        IRangeSource<ushort>,
        IRangeSource<int>,
        IRangeSource<uint>,
        IRangeSource<long>,
        IRangeSource<ulong>,
        IRangeSource<float>,
        IRangeSource<double>
    {

    }
}
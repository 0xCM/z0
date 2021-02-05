//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IPolyStream : IDomainSource,
        IDomainSource<sbyte>,
        IDomainSource<byte>,
        IDomainSource<short>,
        IDomainSource<ushort>,
        IDomainSource<int>,
        IDomainSource<uint>,
        IDomainSource<long>,
        IDomainSource<ulong>,
        IDomainSource<float>,
        IDomainSource<double>
    {

    }
}
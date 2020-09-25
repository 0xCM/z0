//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public unsafe interface IPointedMap<S,T>
        where S : unmanaged
    {
        T Map(S* pSrc);
    }

    [Free]
    public interface IPointedMap<H,S,T> : IPointedMap<S,T>
        where S : unmanaged
        where H : struct, IPointedMap<H,S,T>
    {

    }
}
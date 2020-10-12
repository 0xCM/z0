//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITableDispatcher<F,T,D,S,Y>
        where F : unmanaged
        where T : struct
        where D : unmanaged
        where S : unmanaged
    {
        void Dispatch(T[] src, Y[] dst);
    }
}
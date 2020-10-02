//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ITableDispatcher<F,T,D,S,Y>
        where F : unmanaged
        where T : struct, ITable<F,T,D>
        where D : unmanaged
        where S : unmanaged
    {
        void Process(T[] src, Y[] dst);
    }
}
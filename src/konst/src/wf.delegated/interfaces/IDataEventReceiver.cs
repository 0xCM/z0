//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDataEventReceiver : ISink<IDataEvent>
    {

    }

    [Free]
    public interface IDataEventReceiver<T> : IDataEventReceiver
        where T : struct, IDataEvent<T>
    {
        void Deposit(in T src);

        void ISink<IDataEvent>.Deposit(IDataEvent src)
            => Deposit((T)src);
    }
}
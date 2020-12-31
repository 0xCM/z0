//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IRecordSink<T> : ISink<T>
        where T : struct
    {
        void Deposit(in T src);

        void ISink<T>.Deposit(T src)
            => Deposit(in src);
    }
}
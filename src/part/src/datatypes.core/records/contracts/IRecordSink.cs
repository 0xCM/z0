//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    public interface IRecordSink
    {
        void Deposit(IRecord src);
    }

    [Free]
    public interface IRecordSink<T> : IRecordSink, ISink<T>
        where T : struct, IRecord<T>
    {
        void Deposit(in T src);

        void ISink<T>.Deposit(T src)
            => Deposit(in src);

        void IRecordSink.Deposit(IRecord src)
            => Deposit((T)src);
    }
}
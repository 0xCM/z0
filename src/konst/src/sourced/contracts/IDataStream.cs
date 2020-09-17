//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    using System;

    [Free]
    public interface IDataStream<I,T> : IValueSource<T>
        where T : struct
        where I : unmanaged
    {
        ref T Next(ref T dst);

        ReadOnlySpan<T> Read(I count);

        ref T Read(I count, ref T dst);

        void Read(I count, Span<T> dst);
    }

    [Free]
    public interface IDataStream<T> : IDataStream<uint,T>
        where T : struct
    {

    }

    [Free]
    public interface IDataStream : IValueSource
    {
        ref T Next<T>(ref T dst)
            where T : struct;

        ReadOnlySpan<T> Read<T,I>(I count)
            where T : struct
            where I : unmanaged;

        ref T Read<T,I>(I count, ref T dst)
            where T : struct
            where I : unmanaged;

        void Read<T,I>(I count, Span<T> dst)
            where T : struct
            where I : unmanaged;
    }
}
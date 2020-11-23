//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDataDecoder<T,S>
        where S : struct
        where T : struct
    {
        void Decode(ReadOnlySpan<T> src, Span<S> dst);
    }

    [Free]
    public interface IDataEncoder<S,T>
        where S : struct
        where T : struct
    {
        ByteSize Encode(ReadOnlySpan<S> src, Span<T> dst);

    }

    [Free]
    public interface IDataCoder<S,T> : IDataEncoder<S,T>, IDataDecoder<T,S>
        where S : struct
        where T : struct
    {

    }
}
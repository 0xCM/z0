//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IValueDecoder<T,S>
        where S : struct
        where T : struct
    {
        void Decode(ReadOnlySpan<T> src, Span<S> dst);
    }

    [Free]
    public interface IValueEncoder<S,T>
        where S : struct
        where T : struct
    {
        ByteSize Encode(ReadOnlySpan<S> src, Span<T> dst);

    }

    [Free]
    public interface IValueTransformer<S,T> : IValueEncoder<S,T>, IValueDecoder<T,S>
        where S : struct
        where T : struct
    {

    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IDataTypeFormatter<S> : IValueFormatter<S>
        where S : struct, IDataType<S>
    {
        Span<byte> IFormatter<S>.Format(in S src)
            => memory.bytes(src.Storage);
    }

    [Free]
    public interface IDataTypeFormatter<S,T> : IFormatter<S,T>
        where S : struct, IDataType<S>
    {
        void Format(in S src, out T dst);

        T IFormatter<S,T>.Format(S src)
        {
            Format(src, out var dst);
            return dst;
        }
    }
}
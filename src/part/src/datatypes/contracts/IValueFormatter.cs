//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IValueFormatter<S> : DataFormatter<S>
        where S : struct
    {
        Span<byte> DataFormatter<S>.Format(in S src)
            => memory.bytes(src);
    }
}
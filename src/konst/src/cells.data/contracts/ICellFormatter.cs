//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICellFormatter<T>
    {
        BinaryCode Format(in T src);
    }

    [Free]
    public interface ICellFormatter<S,T> : ICellFormatter<S>
    {
        new ref readonly T Format(in S src);

        BinaryCode ICellFormatter<S>.Format(in S src)
            => new BinaryCode(Array.Empty<byte>());
    }
}
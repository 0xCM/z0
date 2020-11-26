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
    public interface IDataFormatter<S,T> : IFormatter<S,T>
        where S : struct
    {
        T Format(in S src);

        T IFormatter<S,T>.Format(S src)
            => Format(src);
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public delegate ParseResult2<S> ParseFunction<S,T>(in S src, out T dst);


    [Free]
    public delegate ParseResult2<string> TextParseFunction<T>(string src, out T dst);
}
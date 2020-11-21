//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public delegate T FormatFunction<S,T>(in S src);

    [Free]
    public delegate string TextFormatFunction<S>(in S src);

    [Free]
    public interface IFormatFunction<S,T>
    {
        T Format(in S src);
    }

    [Free]
    public interface ITextFormatFunction<S> : IFormatFunction<S,string>
    {

    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IFormatFunction
    {
        Type SourceType {get;}
    }

    [Free]
    public interface IFormatFunction<T> : IFormatFunction
    {
        Type IFormatFunction.SourceType => typeof(T);
    }
}
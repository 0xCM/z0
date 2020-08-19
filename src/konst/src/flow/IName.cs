//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IName : ITextual
    {

    }

    [Free]
    public interface IName<S> : IName, IContented<S>
    {

    }

    [Free]
    public interface IName<S,T> : IName, IDataFlow<S,T>
    {

    }

    [Free]
    public interface IName<H,S,T> : IName<S,T>
        where H : struct, IName<H,S,T>
    {

    }
}
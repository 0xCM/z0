//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IAppArg : ITextual
    {

    }

    [Free]
    public interface IAppArg<T> : IAppArg, IContented<T>
        where T : struct
    {

    }
}
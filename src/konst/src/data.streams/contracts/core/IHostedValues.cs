//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface IHostedValues<H,T> : IValueSource<T>
        where T : struct
        where H : struct, IHostedValues<H,T>
    {

    }
}
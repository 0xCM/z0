//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdVars
    {
        Index<ICmdVar> Members();
    }

    [Free]
    public interface ICmdVars<H> : ICmdVars
        where H : ICmdVars<H>, new()
    {

    }
}
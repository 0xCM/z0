//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdScriptPattern : ITextual
    {
        CmdHostId CmdHost {get;}
    }

    [Free]
    public interface ICmdScriptPattern<T> : ICmdScriptPattern
        where T : struct, ICmdScriptPattern
    {

    }

    [Free]
    public interface ICmdScriptPattern<H,T> : ICmdScriptPattern<T>, IContented<T>
        where H : struct, ICmdScriptPattern<H,T>
        where T : struct, ICmdScriptPattern
    {

    }
}
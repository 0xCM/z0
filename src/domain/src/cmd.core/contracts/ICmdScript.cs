//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdScript : ITextual
    {
        CmdToolId CmdId {get;}
    }

    [Free]
    public interface ICmdScript<T> : ICmdScript
        where T : struct, ICmdScript
    {

    }

    [Free]
    public interface ICmdScript<H,T> : ICmdScript<T>, IContented<T>
        where H : struct, ICmdScript<H,T>
        where T : struct, ICmdScript
    {

    }
}
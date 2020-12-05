//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdResult
    {
        CmdId Id {get;}

        bool Succeeded {get;}
    }

    [Free]
    public interface ICmdResult<P> : ICmdResult
        where P : struct
    {
        P Payload {get;}
    }

    [Free]
    public interface ICmdResult<C,P> : ICmdResult<P>
        where P : struct
        where C : struct, ICmdSpec<C>
    {
        CmdId ICmdResult.Id
            => default(C).CmdId;
    }
}
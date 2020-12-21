//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free]
    public interface ICmdResult : ITextual
    {
        CmdId Id {get;}

        string Message {get;}

        bool Succeeded {get;}

        string ITextual.Format()
            => Message;
    }

    [Free]
    public interface ICmdResult<P> : ICmdResult
    {
        P Payload {get;}
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct CmdResult<P> : ICmdResult<P>
    {
        public CmdId Id {get;}

        public bool Succeeded {get;}

        public P Payload {get;}

        public string Message {get;}

        [MethodImpl(Inline)]
        public CmdResult(CmdId id, bool success)
        {
            Id = id;
            Payload = default;
            Succeeded = success;
            Message = CmdResult.DefaultMsg(id, success);
        }

        [MethodImpl(Inline)]
        public CmdResult(CmdId id, bool success, P payload, string msg = EmptyString)
        {
            Id = id;
            Payload = payload;
            Succeeded = success;
            Message = text.ifempty(msg, CmdResult.DefaultMsg(id, success));
        }

        [MethodImpl(Inline)]
        public CmdResult(CmdId id, Exception e)
        {
            Id = id;
            Payload = default;
            Succeeded = false;
            Message = e.ToString();
        }

        [MethodImpl(Inline)]
        public string Format()
            => Message;


        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdResult(CmdResult<P> src)
            => new CmdResult(src.Id, src.Succeeded, src.Message);

        public static CmdResult<P> Empty
            => default;
    }
}
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public struct CmdResult<C> : ICmdResult<C>
        where C : struct, ICmdSpec
    {
        public C Cmd {get;}

        public CmdId Id  => Cmd.CmdId;

        public bool Succeeded {get;}

        public string Message {get;}

        [MethodImpl(Inline)]
        public CmdResult(C cmd, bool success, string msg = EmptyString)
        {
            Cmd = cmd;
            Succeeded = success;
            Message = text.ifempty(msg, CmdResult.DefaultMsg(Cmd.CmdId, success));
        }

        [MethodImpl(Inline)]
        public CmdResult(C cmd, Exception e)
        {
            Cmd = cmd;
            Succeeded = false;
            Message = e.ToString();
        }

        [MethodImpl(Inline)]
        public string Format()
            => Message;


        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator CmdResult(CmdResult<C> src)
            => new CmdResult(src.Id, src.Succeeded, src.Message);

        public static CmdResult<C> Empty
            => default;
    }
}
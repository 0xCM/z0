//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct CmdResult : ITextual
    {
        public CmdId CmdId {get;}

        public bool Succeeded {get;}

        public BinaryCode Payload {get;}

        public string Message {get;}

        [MethodImpl(Inline)]
        public CmdResult(CmdId id, bit success)
        {
            CmdId = id;
            Payload = default;
            Succeeded = success;
            Message = string.Format("{0} execution {1}", CmdId, Succeeded ? "succeeded" : "failed");
        }

        [MethodImpl(Inline)]
        public CmdResult(CmdId id, bit success, byte[] payload)
        {
            CmdId = id;
            Payload = payload;
            Succeeded = success;
            Message = string.Format("{0} execution {1}", CmdId, Succeeded ? "succeeded" : "failed");
        }

        [MethodImpl(Inline)]
        public CmdResult(CmdId id, bit success, string message)
        {
            CmdId = id;
            Payload = default;
            Succeeded = success;
            Message = text.ifempty(message, string.Format("{0} execution {1}", CmdId, Succeeded ? "succeeded" : "failed"));
        }

        [MethodImpl(Inline)]
        public CmdResult(ICmdSpec cmd, bit success, byte[] content, string message)
        {
            CmdId = cmd.CmdId;
            Payload = content;
            Succeeded = success;
            Message = text.ifempty(message, string.Format("{0} execution {1}", CmdId, Succeeded ? "succeeded" : "failed"));
        }

        [MethodImpl(Inline)]
        public CmdResult(ICmdSpec cmd, bit success, string message)
        {
            CmdId = cmd.CmdId;
            Payload = default;
            Succeeded = success;
            Message = text.ifempty(message, string.Format("{0} execution {1}", CmdId, Succeeded ? "succeeded" : "failed"));
        }

        [MethodImpl(Inline)]
        public string Format()
            => Message;

        public static CmdResult Empty
            => default;
    }
}
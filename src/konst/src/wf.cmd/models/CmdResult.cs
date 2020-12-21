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

        public string Message {get;}

        [MethodImpl(Inline)]
        public CmdResult(CmdId id, bit success)
        {
            CmdId = id;
            Succeeded = success;
            Message = DefaultMsg(id, success);
        }

        [MethodImpl(Inline)]
        public CmdResult(CmdId id, bit success, string message)
        {
            CmdId = id;
            Succeeded = success;
            Message = text.ifempty(message, DefaultMsg(id,success));
        }

        [MethodImpl(Inline)]
        public CmdResult(CmdId id, Exception e)
        {
            CmdId = id;
            Succeeded = false;
            Message = e.ToString();
        }

        internal static string DefaultMsg(CmdId id, bit success)
            => string.Format("{0} execution {1}", id, success ? "succeeded" : "failed");

        [MethodImpl(Inline)]
        public string Format()
            => Message;

        public override string ToString()
            => Format();

        public static CmdResult Empty
            => default;
    }
}
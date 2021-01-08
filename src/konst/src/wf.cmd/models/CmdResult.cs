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

        public dynamic Payload {get;}

        public string Message {get;}

        [MethodImpl(Inline)]
        public CmdResult(CmdId id, bit success)
        {
            CmdId = id;
            Succeeded = success;
            Message = DefaultMsg(id, success);
            Payload = Succeeded;
        }

        [MethodImpl(Inline)]
        public CmdResult(CmdId id, bit success, dynamic payload)
        {
            CmdId = id;
            Succeeded = success;
            Message = DefaultMsg(id, success);
            Payload = payload;
        }

        [MethodImpl(Inline)]
        public CmdResult(CmdId id, bit success, string message)
        {
            CmdId = id;
            Succeeded = success;
            Message = text.ifempty(message, DefaultMsg(id,success));
            Payload = Succeeded;
        }

        [MethodImpl(Inline)]
        public CmdResult(CmdId id, Exception e)
        {
            CmdId = id;
            Succeeded = false;
            Message = e.ToString();
            Payload = Succeeded;
        }


        [MethodImpl(Inline)]
        public static CmdResult FromOutcome<T>(CmdId id, Outcome<T> result)
            => new CmdResult(id, result.Ok, result.Message);

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

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static CmdResult ToCmdResult<T>(this Outcome<T> result, CmdId id)
            => CmdResult.FromOutcome(id,result);

        [MethodImpl(Inline)]
        public static CmdResult ToCmdResult<T>(this Outcome<T> result, ICmdSpec cmd)
            => CmdResult.FromOutcome(cmd.CmdId,result);

    }
}
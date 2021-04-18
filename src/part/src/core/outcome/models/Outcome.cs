//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Defines the outcome of an operation/process
    /// </summary>
    public readonly struct Outcome : IOutcome
    {
        public bool Ok {get;}

        public string Message {get;}

        public ulong MessageCode {get;}

        public bool Fail => !Ok;

        [MethodImpl(Inline)]
        public Outcome(bool success)
        {
            Ok = success;
            Message = success ? "Good" : "Bad";
            MessageCode = memory.u8(Ok);
        }

        [MethodImpl(Inline)]
        public Outcome(bool success, AppMsg message)
        {
            Ok = success;
            Message = message.Format();
            MessageCode = memory.u8(Ok);
        }

        [MethodImpl(Inline)]
        public Outcome(bool success, string message)
        {
            Ok = success;
            Message = message;
            MessageCode = memory.u8(Ok);
        }

        [MethodImpl(Inline)]
        public Outcome(AppMsgData data)
        {
            Ok = !(data.Kind == LogLevel.Error);
            Message = AppMsg.define(data).Format();
            MessageCode = memory.u8(Ok);
        }

        [MethodImpl(Inline)]
        public Outcome(Exception e)
        {
            Ok = false;
            Message = AppMsg.error(e).Format();
            MessageCode = memory.u8(Ok);
        }

        [MethodImpl(Inline)]
        public Outcome(Exception e, string msg)
        {
            Ok = false;
            Message = string.Format("{0} - {1}", msg, AppMsg.error(e).Format());
            MessageCode = memory.u8(Ok);
        }

        [MethodImpl(Inline)]
        Outcome(ulong code)
        {
            Ok = false;
            Message = EmptyString;
            MessageCode = code;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => MessageCode == ulong.MaxValue;
        }

        public static Outcome Empty
        {
            [MethodImpl(Inline)]
            get => new Outcome(ulong.MaxValue);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Message;

        public override string ToString()
            => Format();

        public void Require()
        {
            if(Fail)
                throw new Exception(Message ?? "An eggregious blunder");
        }

        [MethodImpl(Inline)]
        public static implicit operator Outcome(bool success)
            => new Outcome(success);

        [MethodImpl(Inline)]
        public static implicit operator Outcome(Exception e)
            => new Outcome(e);

        [MethodImpl(Inline)]
        public static implicit operator Outcome((Exception e, string msg) src)
            => new Outcome(src.e,src.msg);

        [MethodImpl(Inline)]
        public static implicit operator Outcome(AppMsgData data)
            => new Outcome(data);

        [MethodImpl(Inline)]
        public static implicit operator Outcome((bool success, AppMsg msg) src)
            => new Outcome(src.success, src.msg);

        [MethodImpl(Inline)]
        public static implicit operator Outcome((bool success, string msg) src)
            => new Outcome(src.success, src.msg);

        [MethodImpl(Inline)]
        public static bool operator true(Outcome src)
            => src.Ok == true;

        [MethodImpl(Inline)]
        public static bool operator false(Outcome src)
            => src.Ok == false;

        [MethodImpl(Inline)]
        public static implicit operator bool(Outcome src)
            => src.Ok;
    }
}
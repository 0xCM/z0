//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Defines the outcome of an operation/process
    /// </summary>
    public readonly struct Outcome : IOutcome
    {
        public bool Ok {get;}

        public string Message {get;}

        public bool Fail => !Ok;

        [MethodImpl(Inline)]
        public Outcome(bool success)
        {
            Ok = success;
            Message = success ? "Good" : "Bad";
        }

        [MethodImpl(Inline)]
        public Outcome(bool success, AppMsg message)
        {
            Ok = success;
            Message = message.Format();
        }

        [MethodImpl(Inline)]
        public Outcome(bool success, string message)
        {
            Ok = success;
            Message = message;
        }

        [MethodImpl(Inline)]
        public Outcome(AppMsg message)
        {
            Ok = !(message.Kind == LogLevel.Error);
            Message = message.Format();
        }

        [MethodImpl(Inline)]
        public Outcome(AppMsgData data)
        {
            Ok = !(data.Kind == LogLevel.Error);
            Message = AppMsg.define(data).Format();
        }

        [MethodImpl(Inline)]
        public Outcome(Exception e)
        {
            Ok = false;
            Message = AppMsg.error(e).Format();
        }


        [MethodImpl(Inline)]
        public string Format()
            => Message;

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Outcome(bool success)
            => new Outcome(success);

        [MethodImpl(Inline)]
        public static implicit operator Outcome(Exception e)
            => new Outcome(e);

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
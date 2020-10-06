//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Outcome
    {
        public readonly bool Ok;

        public readonly AppMsg Message;

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
        public static bool operator true(Outcome src)
            => src.Ok == true;

        [MethodImpl(Inline)]
        public static bool operator false(Outcome src)
            => src.Ok == false;

        [MethodImpl(Inline)]
        public Outcome(bool success)
        {
            Ok = success;
            Message = success ? AppMsg.info("Good") : AppMsg.error("Bad");
        }

        [MethodImpl(Inline)]
        public Outcome(bool success, AppMsg message)
        {
            Ok = success;
            Message = message;
        }

        [MethodImpl(Inline)]
        public Outcome(AppMsg message)
        {
            Ok = !(message.Kind == LogLevel.Error);
            Message = message;
        }

        [MethodImpl(Inline)]
        public Outcome(AppMsgData data)
        {
            Ok = !(data.Kind == LogLevel.Error);
            Message = AppMsg.define(data);
        }

        [MethodImpl(Inline)]
        public Outcome(Exception e)
        {
            Ok = false;
            Message = AppMsg.error(e);
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out bool success, out AppMsg msg)
        {
            success = Ok;
            msg = Message;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Message.Format();

        public override string ToString()
            => Format();
    }
}
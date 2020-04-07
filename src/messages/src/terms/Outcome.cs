//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct Outcome
    {
        public readonly bool Success;

        public readonly AppMsg Message;

        public static implicit operator Outcome(bool success)
            => new Outcome(success);
        
        public static implicit operator Outcome((bool success, AppMsg msg) src)
            => new Outcome(src.success, src.msg);

        [MethodImpl(Inline)]
        public static bool operator true(Outcome src)
            => src.Success == true;

        [MethodImpl(Inline)]
        public static bool operator false(Outcome src)
            => src.Success == false;

        [MethodImpl(Inline)]
        public Outcome(bool success)
        {
            this.Success = success;
            this.Message = success ? AppMsg.Info("Good") : AppMsg.Error("Bad");
        }

        [MethodImpl(Inline)]
        public Outcome(bool success, AppMsg message)
        {
            this.Success = success;
            this.Message = message;
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out bool success, out AppMsg msg)
        {
            success = Success;
            msg = Message;
        }

        public string Format()
            => Message.Format();

        public override string ToString()
            => Format();
    }
}
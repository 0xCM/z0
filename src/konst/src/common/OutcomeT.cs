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
    /// Describes an operation result
    /// </summary>
    public readonly struct Outcome<T> : ITextual
    {
        const string Success = nameof(Success);

        const string Fail = nameof(Fail);

        public readonly bool Ok;

        public readonly T Data;

        public readonly Option<Exception> Error;

        [MethodImpl(Inline)]
        public static implicit operator Outcome<T>(T data)
            => new Outcome<T>(true, data);

        [MethodImpl(Inline)]
        public static implicit operator Outcome<T>(Exception error)
            => new Outcome<T>(error);

        // [MethodImpl(Inline)]
        // public static implicit operator Outcome<T>((bool ok, T data) src)
        //     => new Outcome<T>(src.ok, src.data);

        [MethodImpl(Inline)]
        public Outcome(bool ok, T data)
        {
            Ok = ok;
            Data = data;
            Error = default;
        }

        [MethodImpl(Inline)]
        public Outcome(Exception e, T data = default)
        {
            Ok = false;
            Data = data;
            Error = e;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format("{0}: {1}", Ok ? Success : Fail, Ok ? (object)Data : (object) Error);
    }
}
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

        public readonly ulong MessageCode;

        [MethodImpl(Inline)]
        public static bool operator true(Outcome<T> src)
            => src.Ok == true;

        [MethodImpl(Inline)]
        public static bool operator false(Outcome<T> src)
            => src.Ok == false;

        [MethodImpl(Inline)]
        public static implicit operator Outcome<T>(T data)
            => new Outcome<T>(true, data);

        [MethodImpl(Inline)]
        public static implicit operator Outcome<T>(Exception error)
            => new Outcome<T>(error);

        [MethodImpl(Inline)]
        public Outcome(bool ok, T data, ulong code = default)
        {
            Ok = ok;
            Data = data;
            Error = default;
            MessageCode = code;
        }

        [MethodImpl(Inline)]
        public Outcome(ulong code)
        {
            Ok = false;
            Data = default;
            Error = default;
            MessageCode = code;
        }

        [MethodImpl(Inline)]
        public Outcome(Exception e, T data = default)
        {
            Ok = false;
            Data = data;
            Error = e;
            MessageCode = default;
        }


        [MethodImpl(Inline)]
        public string Format()
            => text.format("{0}: {1}", Ok ? Success : Fail, Ok ? (object)Data : (object) Error);
    }
}
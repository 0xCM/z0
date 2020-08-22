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
        const string  FormatPattern = "{0}: {1}";

        const string Success = nameof(Success);

        const string Fail = nameof(Fail);

        public readonly bool Ok;

        public readonly T Data;

        [MethodImpl(Inline)]
        public static implicit operator Outcome<T>((bool ok, T data) src)
            => new Outcome<T>(src.ok, src.data);

        [MethodImpl(Inline)]
        public Outcome(bool ok, T data)
        {
            Ok = ok;
            Data = data;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format("{0}: {1}", Ok ? Success : Fail, Data);
    }
}
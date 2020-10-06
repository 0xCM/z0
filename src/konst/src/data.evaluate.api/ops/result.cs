//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Eval
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static EvalResult result<T>(int seq, in T id, Duration duration, Exception error)
            => new EvalResult(seq, $"{id}", false, duration, error);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static EvalResult result<T>(int seq, in T id, Duration duration, bool succeeded)
            => new EvalResult(seq, $"{id}", succeeded, duration, $"{succeeded}");

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static EvalResult result<T>(int seq, in T id, Duration duration, object message, bool succeeded)
            => new EvalResult(seq,$"{id}", succeeded, duration, message);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static EvalResult result<T>(uint seq, in T id, Duration duration, Exception error)
            => new EvalResult((int)seq, $"{id}", false, duration, error);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static EvalResult result<T>(uint seq, in T id, Duration duration, bool succeeded)
            => new EvalResult((int)seq, $"{id}", succeeded, duration, "Ok");

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static EvalResult result<T>(uint seq, in T id, Duration duration, object message, bool succeeded)
            => new EvalResult((int)seq,$"{id}",  succeeded, duration, message);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static EvalResult result<T>(int seq, in T id, Duration duration, AppMsg message)
            => new EvalResult(seq,$"{id}", message.Kind != LogLevel.Error, duration, message);
    }
}
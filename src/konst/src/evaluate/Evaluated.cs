//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public static class Evaluated
    {

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static UnaryEvaluations<T> unary<T>(in Span<T> src, in PairEvalOutcomes<T> dst)
            where T : unmanaged
                => new UnaryEvaluations<T>(src, dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BinaryEvaluations<T> binary<T>(in Pairs<T> src, in PairEvalOutcomes<T> dst)
            where T : unmanaged
                => new BinaryEvaluations<T>(src, dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static PairEvalOutcomes<T> pairs<T>(in Pair<string> labels, in Pairs<T> dst)
            where T : unmanaged
                => new PairEvalOutcomes<T>(labels, dst);

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
            => new EvalResult(seq,$"{id}", message.Kind != MessageKind.Error, duration, message);
    }
}
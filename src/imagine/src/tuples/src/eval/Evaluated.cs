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
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static UnaryEvaluations<T> unary<T>(in Span<T> src, in PairEvalOutcomes<T> dst)
            where T : unmanaged
                => new UnaryEvaluations<T>(src, dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static BinaryEvaluations<T> binary<T>(in Pairs<T> src, in PairEvalOutcomes<T> dst)
            where T : unmanaged
                => new BinaryEvaluations<T>(src, dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static PairEvalOutcomes<T> pairs<T>(in Pair<string> labels, in Pairs<T> dst)
            where T : unmanaged
                => new PairEvalOutcomes<T>(labels, dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static EvalResult result<T>(int seq, in T id, Duration duration, Exception error)
            => new EvalResult(seq, $"{id}", false, duration, error != null? AppMsg.Error(error) : AppMsg.Empty);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static EvalResult result<T>(int seq, in T id, Duration duration, bool succeeded)
            => new EvalResult(seq, $"{id}", succeeded, duration, AppMsg.Empty);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static EvalResult result<T>(int seq, in T id, Duration duration, AppMsg message)
            => new EvalResult(seq,$"{id}", message.Kind != AppMsgKind.Error, duration, message);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static EvalResult result<T>(uint seq, in T id, Duration duration, Exception error)
            => new EvalResult((int)seq, $"{id}", false, duration, error != null? AppMsg.Error(error) : AppMsg.Empty);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static EvalResult result<T>(uint seq, in T id, Duration duration, bool succeeded)
            => new EvalResult((int)seq, $"{id}", succeeded, duration, AppMsg.Empty);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static EvalResult result<T>(uint seq, in T id, Duration duration, AppMsg message)
            => new EvalResult((int)seq,$"{id}", message.Kind != AppMsgKind.Error, duration, message);
    }
}
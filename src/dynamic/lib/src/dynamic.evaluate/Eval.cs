//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using K = EvalAspectKey;
    using R = EvalResult;

    [ApiHost]
    public readonly struct Eval
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static R result<T>(int seq, in T id, Duration duration, Exception error)
            => new R(seq, $"{id}", false, duration, error.ToString());

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static R result<T>(int seq, in T id, Duration duration, bool succeeded)
            => new R(seq, $"{id}", succeeded, duration, $"{succeeded}");

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static R result<T>(int seq, in T id, Duration duration, object message, bool succeeded)
            => new EvalResult(seq,$"{id}", succeeded, duration, message?.ToString());

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static R result<T>(uint seq, in T id, Duration duration, Exception error)
            => new R((int)seq, $"{id}", false, duration, error.ToString());

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static R result<T>(uint seq, in T id, Duration duration, bool succeeded)
            => new R((int)seq, $"{id}", succeeded, duration, "Ok");

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static R result<T>(uint seq, in T id, Duration duration, object message, bool succeeded)
            => new R((int)seq,$"{id}",  succeeded, duration, message?.ToString());

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static R result<T>(int seq, in T id, Duration duration, AppMsg message)
            => new R(seq,$"{id}", message.Kind != LogLevel.Error, duration, message.Format());

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static PairEvalResults<T> pairs<T>(in Pair<string> labels, in Pairs<T> dst)
            where T : unmanaged
                => new PairEvalResults<T>(labels, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryEvaluations<T> unary<T>(in Span<T> src, in PairEvalResults<T> dst)
            where T : unmanaged
                => new UnaryEvaluations<T>(src, dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static BinaryEvaluations<T> binary<T>(in Pairs<T> src, in PairEvalResults<T> dst)
            where T : unmanaged
                => new BinaryEvaluations<T>(src, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryEvalContext<T> context<T>(in EvalContext src, in UnaryEvaluations<T> content)
            where T : unmanaged
                => new UnaryEvalContext<T>(src, content);

        [MethodImpl(Inline)]
        public static UnaryEvalContext<T> context<T>(BufferTokens buffers, ApiMemberCode code, in UnaryEvaluations<T> content)
            where T : unmanaged
                => context<T>(new EvalContext(buffers, code), content);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static BinaryEvalContext<T> context<T>(in EvalContext src, in BinaryEvaluations<T> content)
            where T : unmanaged
                => new BinaryEvalContext<T>(src, content);

        [MethodImpl(Inline)]
        public static BinaryEvalContext<T> context<T>(BufferTokens buffers, ApiMemberCode code, in BinaryEvaluations<T> content)
            where T : unmanaged
                => context<T>(new EvalContext(buffers,code), content);
    }
}
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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static UnaryEvalContext<T> context<T>(in EvalContext src, in UnaryEvaluations<T> content)
            where T : unmanaged
                => new UnaryEvalContext<T>(src, content);

        [MethodImpl(Inline)]
        public static UnaryEvalContext<T> context<T>(BufferTokens buffers, ApiMemberCode code, in UnaryEvaluations<T> content)
            where T : unmanaged
                => context<T>(new EvalContext(buffers,code), content);

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
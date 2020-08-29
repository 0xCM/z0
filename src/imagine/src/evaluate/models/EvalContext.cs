//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EvalContext
    {
        [MethodImpl(Inline)]
        public static UnaryEvalContext<T> unary<T>(in EvalContext context, in UnaryEvaluations<T> content)
            where T : unmanaged
                    => new UnaryEvalContext<T>(context, content);

        [MethodImpl(Inline)]
        public static UnaryEvalContext<T> unary<T>(BufferTokens buffers, X86ApiMember code, in UnaryEvaluations<T> content)
            where T : unmanaged
                => unary<T>(new EvalContext(buffers,code), content);

        [MethodImpl(Inline)]
        public static BinaryEvalContext<T> binary<T>(in EvalContext context, in BinaryEvaluations<T> content)
            where T : unmanaged
                => new BinaryEvalContext<T>(context, content);

        [MethodImpl(Inline)]
        public static BinaryEvalContext<T> binary<T>(BufferTokens buffers, X86ApiMember code, in BinaryEvaluations<T> content)
            where T : unmanaged
                => binary<T>(new EvalContext(buffers,code), content);

        public readonly BufferTokens Buffers;

        public readonly X86ApiMember ApiCode;

        public IdentifiedCode ApiBits
        {
            [MethodImpl(Inline)]
            get => ApiCode.Encoded;
        }

        public ApiMember Member
        {
            [MethodImpl(Inline)]
            get =>  ApiCode.Member;
        }

        [MethodImpl(Inline)]
        public EvalContext(BufferTokens buffers, X86ApiMember code)
        {
            Buffers = buffers;
            ApiCode = code;
        }
    }
}
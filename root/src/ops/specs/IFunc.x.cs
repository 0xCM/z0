//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class IFuncExtensions
    {
        [MethodImpl(Inline)]
        public static bool IsOperator(this IFunc f)
            => (f.Kind & FunctionKind.Operator) != 0;

        [MethodImpl(Inline)]
        public static bool IsEmitter(this IFunc f)
            => (f.Kind & FunctionKind.Emitter) != 0;

        [MethodImpl(Inline)]
        public static bool IsMeasure(this IFunc f)
            => (f.Kind & FunctionKind.Measure) != 0;

        [MethodImpl(Inline)]
        public static bool IsUnary(this IFunc f)
            => (f.Kind & FunctionKind.UnaryFunc) != 0;

        [MethodImpl(Inline)]
        public static bool IsBinary(this IFunc f)
            => (f.Kind & FunctionKind.BinaryFunc) != 0;

        [MethodImpl(Inline)]
        public static bool IsVectorized(this IFunc f)
            => (f.Kind & FunctionKind.Vectorized) != 0;

        [MethodImpl(Inline)]
        public static bool IsPredicate(this IFunc f)
            => (f.Kind & FunctionKind.Predicate) != 0;

        [MethodImpl(Inline)]
        public static bool AcceptsImmediate(this IFunc f)
            => (f.Kind & FunctionKind.Imm) != 0;

        [MethodImpl(Inline)]
        public static bool AcceptsV128(this IFunc f)
            => (f.Kind & FunctionKind.V128) != 0;

        [MethodImpl(Inline)]
        public static bool AcceptsV256(this IFunc f)
            => (f.Kind & FunctionKind.V256) != 0;
    }
}
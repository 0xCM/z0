//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Security;

    public static class TaxonomyX
    {

        public static bool IsOperator(this IFunc f)
            => (f.Kind & FunctionKind.Operator) != 0;

        public static bool IsEmitter(this IFunc f)
            => (f.Kind & FunctionKind.Emitter) != 0;

        public static bool IsMeasure(this IFunc f)
            => (f.Kind & FunctionKind.Measure) != 0;

        public static bool IsUnary(this IFunc f)
            => (f.Kind & FunctionKind.UnaryFunc) != 0;

        public static bool IsBinary(this IFunc f)
            => (f.Kind & FunctionKind.BinaryFunc) != 0;

        public static bool IsVectorized(this IFunc f)
            => (f.Kind & FunctionKind.Vectorized) != 0;

        public static bool IsPredicate(this IFunc f)
            => (f.Kind & FunctionKind.Predicate) != 0;

        public static bool AcceptsImmediate(this IFunc f)
            => (f.Kind & FunctionKind.Imm) != 0;

        public static bool AcceptsV128(this IFunc f)
            => (f.Kind & FunctionKind.V128) != 0;

        public static bool AcceptsV256(this IFunc f)
            => (f.Kind & FunctionKind.V256) != 0;
        
        public static bool IsImm8Resolver(this IFunc f)
            => f is Imm8Resolver;

    }


}
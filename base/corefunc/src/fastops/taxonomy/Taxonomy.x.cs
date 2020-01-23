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
            => (f.Kind & HKFunctionKind.Operator) != 0;

        public static bool IsEmitter(this IFunc f)
            => (f.Kind & HKFunctionKind.Emitter) != 0;

        public static bool IsMeasure(this IFunc f)
            => (f.Kind & HKFunctionKind.Measure) != 0;

        public static bool IsUnary(this IFunc f)
            => (f.Kind & HKFunctionKind.UnaryFunc) != 0;

        public static bool IsBinary(this IFunc f)
            => (f.Kind & HKFunctionKind.BinaryFunc) != 0;

        public static bool IsVectorized(this IFunc f)
            => (f.Kind & HKFunctionKind.Vectorized) != 0;

        public static bool IsPredicate(this IFunc f)
            => (f.Kind & HKFunctionKind.Predicate) != 0;

        public static bool AcceptsImmediate(this IFunc f)
            => (f.Kind & HKFunctionKind.Imm) != 0;

        public static bool AcceptsV128(this IFunc f)
            => (f.Kind & HKFunctionKind.V128) != 0;

        public static bool AcceptsV256(this IFunc f)
            => (f.Kind & HKFunctionKind.V256) != 0;
        
        public static bool IsImm8Resolver(this IFunc f)
            => f is Imm8Resolver;

    }


}
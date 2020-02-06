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
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;

    public static class HKX
    {
        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsKind(this MethodInfo m, HK.Vec hk, bool total = false)        
            => FunctionType.vectorized(m,total);

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind(this MethodInfo m, HK.Vec128 hk, bool total)        
            => FunctionType.vectorized(m,128,total);

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind(this MethodInfo m, HK.Vec256 hk, bool total)        
            => FunctionType.vectorized(m,256,total);

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> OfKind(this IEnumerable<MethodInfo> src, HK.Vec128 hk, bool total = false)
            => src.Where(m => m.IsKind(hk,total));

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> OfKind(this IEnumerable<MethodInfo> src, HK.Vec256 hk, bool total = false)
            => src.Where(m => m.IsKind(hk,total));

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
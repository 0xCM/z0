//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;
    using System.Reflection;

    using static Root;

    public static class FastX
    {
        /// <summary>
        /// Determines whether a method has intrinsic parameters or return type
        /// </summary>
        /// <param name="m">The method to examine</param>
        public static bool IsKind(this MethodInfo m, VKT.Vec hk, bool total = false)        
            => m.IsVectorized(total);

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind(this MethodInfo m, VKT.Vec128 hk, bool total)        
            => m.IsVectorized(128,total);

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> OfKind(this IEnumerable<MethodInfo> src, VKT.Vec128 hk, bool total = false)
            => src.Where(m => m.IsKind(hk,total));

        /// <summary>
        /// Selects methods from a stream that accept and/or return intrinsic vectors
        /// </summary>
        /// <param name="src">The methods to examine</param>
        public static IEnumerable<MethodInfo> OfKind(this IEnumerable<MethodInfo> src, VKT.Vec256 hk, bool total = false)
            => src.Where(m => m.IsKind(hk,total));

        /// <summary>
        /// Determines whether a method has intrinsic paremeters or return type of specified width
        /// </summary>
        /// <param name="m">The method to examine</param>
        /// <param name="width">The required vector width</param>
        /// <param name="total">Whether all parameters and return type must be intrinsic</param>
        public static bool IsKind(this MethodInfo m, VKT.Vec256 hk, bool total)        
            => m.IsVectorized(256,total);


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

        public static string FormatBits<T>(this T src)
            where T : unmanaged, IFixed
                => BitConvert.GetBytes(in src).FormatBits();

        public static string Format<T>(this T src, NumericKind kind)
            where T : unmanaged, IFixed
        {
            var dst = BitConvert.GetBytes(in src);
            switch(kind)
            {
                case NumericKind.I8:
                    return dst.As<sbyte>().FormatList();
                case NumericKind.U8:
                    return dst.As<byte>().FormatList();
                case NumericKind.I16:
                    return dst.As<short>().FormatList();
                case NumericKind.U16:
                    return dst.As<ushort>().FormatList();
                case NumericKind.I32:
                    return dst.As<int>().FormatList();
                case NumericKind.U32:
                    return dst.As<uint>().FormatList();
                case NumericKind.I64:
                    return dst.As<long>().FormatList();
                case NumericKind.U64:
                    return dst.As<ulong>().FormatList();
                case NumericKind.F32:
                    return dst.As<float>().FormatList();
                case NumericKind.F64:
                    return dst.As<double>().FormatList();
                default:
                    throw unsupported(kind);
            }
        }

        /// <summary>
        /// Extracts an index-identified segmented identity part from an operation identity
        /// </summary>
        /// <param name="src">The source identity</param>
        /// <param name="partidx">The 0-based part index</param>
        public static Option<SegmentedIdentity> Segment(this OpIdentity src, int partidx)
            => Identity.segment(src,partidx);
 
        public static string TestCaseName(this MethodInfo method)
            => Identity.testcase(method);

    }
}
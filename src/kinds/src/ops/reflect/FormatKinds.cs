//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class XTend
    {
        /// <summary>
        /// Determines whether the kind has a nonzero value
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline)]
        public static bool IsSome(this FixedWidth src)
            => src != 0;

        [MethodImpl(Inline)]
        public static string Format(this ComparisonKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this ComparisonKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        public static string Format(this OpKindId id)
            => id.ToString().ToLower();

        public static string Format(this OpKindId? id)
            => id.HasValue ? id.Value.Format() : "unkinded";

        [MethodImpl(Inline)]
        public static string Format(this ArithmeticOpKind kind)
            => kind switch {
                ArithmeticOpKind.Inc => "++",
                ArithmeticOpKind.Dec => "--",
                ArithmeticOpKind.Negate => "-",
                _ => kind.ToString()
            };

        [MethodImpl(Inline)]
        public static string Format<T>(this ArithmeticOpKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";
             
        public static string Format(this BitShiftKind kind)        
            => kind switch {
                BitShiftKind.Sll => "<<",
                BitShiftKind.Srl => ">>",
                BitShiftKind.Rotl => "<<>",
                BitShiftKind.Rotr => ">><",
                _ => kind.ToString()
            };

        public static string Format<S,T>(this BitShiftKind kind, S arg1, T arg2)
            => $"{arg1} {kind.Format()} {arg2}"; 
 


        [MethodImpl(Inline)]
        public static string Format(this BitLogicKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this BitLogicKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";
    }
}
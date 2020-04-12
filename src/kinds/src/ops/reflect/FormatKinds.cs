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
        public static string Format(this BinaryComparisonKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryComparisonKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        public static string Format(this OpKindId id)
            => id.ToString().ToLower();

        public static string Format(this OpKindId? id)
            => id.HasValue ? id.Value.Format() : "unkinded";

        [MethodImpl(Inline)]
        public static string Format(this BinaryArithmeticKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryArithmeticKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";
             
        [MethodImpl(Inline)]
        public static TernaryBitLogicKind Next(this TernaryBitLogicKind src)
            => src != TernaryBitLogicKind.XFF 
                ? (TernaryBitLogicKind)((uint)(src) + 1u)
                : TernaryBitLogicKind.X00; 

        public static string Format(this TernaryBitLogicKind kind)
            => kind.ToString();

        public static string Format<T>(this TernaryBitLogicKind kind, T arg1, T arg2, T arg3)
            => $"{kind.Format()}({arg1}, {arg2}, {arg3})";

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
        public static string Format(this UnaryBitLogicKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this UnaryBitLogicKind kind, T arg)
            => $"{kind.Format()}({arg})";

        [MethodImpl(Inline)]
        public static string Format(this UnaryArithmeticKind kind)
            => kind switch {
                UnaryArithmeticKind.Inc => "++",
                UnaryArithmeticKind.Dec => "--",
                UnaryArithmeticKind.Negate => "-",
                _ => kind.ToString()
            };

        [MethodImpl(Inline)]
        public static string Format<T>(this UnaryArithmeticKind kind, T arg)
            => $"{kind.Format()}({arg})";

        [MethodImpl(Inline)]
        public static string Format(this BinaryBitLogicKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryBitLogicKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";
    }
}
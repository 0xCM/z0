//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class OpSubjectFormatting
    {
        [MethodImpl(Inline)]
        public static string Format(this ComparisonOpKindId kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this ComparisonOpKindId kind, T arg1, T arg2)
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
        public static TernaryBitLogicOpKind Next(this TernaryBitLogicOpKind src)
            => src != TernaryBitLogicOpKind.XFF 
                ? (TernaryBitLogicOpKind)((uint)(src) + 1u)
                : TernaryBitLogicOpKind.X00; 

        public static string Format(this TernaryBitLogicOpKind kind)
            => kind.ToString();

        public static string Format<T>(this TernaryBitLogicOpKind kind, T arg1, T arg2, T arg3)
            => $"{kind.Format()}({arg1}, {arg2}, {arg3})";

        public static string Format(this ShiftOpKindId kind)        
            => kind switch {
                ShiftOpKindId.Sll => "<<",
                ShiftOpKindId.Srl => ">>",
                ShiftOpKindId.Rotl => "<<>",
                ShiftOpKindId.Rotr => ">><",
                _ => kind.ToString()
            };

        public static string Format<S,T>(this ShiftOpKindId kind, S arg1, T arg2)
            => $"{arg1} {kind.Format()} {arg2}"; 
 
         [MethodImpl(Inline)]
        public static string Format(this UnaryBitLogicOpKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this UnaryBitLogicOpKind kind, T arg)
            => $"{kind.Format()}({arg})";

        [MethodImpl(Inline)]
        public static string Format(this UnaryArithmeticKindId kind)
            => kind switch {
                UnaryArithmeticKindId.Inc => "++",
                UnaryArithmeticKindId.Dec => "--",
                UnaryArithmeticKindId.Negate => "-",
                _ => kind.ToString()
            };

        [MethodImpl(Inline)]
        public static string Format<T>(this UnaryArithmeticKindId kind, T arg)
            => $"{kind.Format()}({arg})";

        [MethodImpl(Inline)]
        public static string Format(this BinaryBitLogicOpKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryBitLogicOpKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

    }
}
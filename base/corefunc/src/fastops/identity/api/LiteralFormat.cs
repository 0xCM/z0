//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public static class LiteralFormatting
    {
        public static string Format(this VectorKind k)
            => k.IsSome() ? k.ToString() : string.Empty;

        public static string Format(this BlockKind k)
            => k.IsSome() ? k.ToString() : string.Empty;

        [MethodImpl(Inline)]
        public static string Format(this NumericKind k)
            => $"{k.Width()}{k.Indicator().Format()}";

        [MethodImpl(Inline)]
        public static string Format(this SpanKind kind)
            => kind.IsSome() ? (kind == SpanKind.Mutable ? IDI.Span : IDI.ImSpan) : string.Empty;

        public static string Format(this ParamVariance src)
            => src.IsSome() ? (AsciSym.Tilde + src.Keyword()) : string.Empty;      

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
        public static string Format(this BinaryArithmeticKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryArithmeticKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        [MethodImpl(Inline)]
        public static string Format(this BinaryBitLogicKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format(this ComparisonKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryBitLogicKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        [MethodImpl(Inline)]
        public static string Format<T>(this ComparisonKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        [MethodImpl(Inline)]
        public static string Format(this TernaryBitLogicKind kind)
            => kind.ToString();

        [MethodImpl(Inline)]
        public static string Format<T>(this TernaryBitLogicKind kind, T arg1, T arg2, T arg3)
            => $"{kind.Format()}({arg1}, {arg2}, {arg3})";

        public static string Format(this ShiftOpKind kind)        
            => kind switch {
                ShiftOpKind.Sll => "<<",
                ShiftOpKind.Srl => ">>",
                ShiftOpKind.Rotl => "<<>",
                ShiftOpKind.Rotr => ">><",
                _ => kind.ToString()
            };

        public static string Format<S,T>(this ShiftOpKind kind, S arg1, T arg2)
            => $"{arg1} {kind.Format()} {arg2}"; 
    }
}
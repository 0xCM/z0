//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using static zfunc;


    public static class KindFormat
    {
        [MethodImpl(Inline)]
        public static string Format<T>(this UnaryLogicOpKind kind, T arg)
            => $"{kind.Format()}({arg})";

        [MethodImpl(Inline)]
        public static string Format(this UnaryLogicOpKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format(this UnaryBitwiseOpKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this UnaryBitwiseOpKind kind, T arg)
            => $"{kind.Format()}({arg})";

        [MethodImpl(Inline)]
        public static string Format(this UnaryArithmeticOpKind kind)
            => kind switch {
                UnaryArithmeticOpKind.Inc => "++",
                UnaryArithmeticOpKind.Dec => "--",
                UnaryArithmeticOpKind.Negate => "-",
                _ => kind.ToString()
            };

        [MethodImpl(Inline)]
        public static string Format<T>(this UnaryArithmeticOpKind kind, T arg)
            => $"{kind.Format()}({arg})";

        [MethodImpl(Inline)]
        public static string Format(this BinaryArithmeticOpKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryArithmeticOpKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        [MethodImpl(Inline)]
        public static string Format(this BinaryLogicOpKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format(this BinaryBitwiseOpKind kind)
            => kind.ToString().ToLower();


        [MethodImpl(Inline)]
        public static string Format(this ComparisonKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryLogicOpKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryBitwiseOpKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";


        [MethodImpl(Inline)]
        public static string Format<T>(this ComparisonKind kind, T arg1, T arg2)
            => $"{kind.Format()}({arg1}, {arg2})";

        [MethodImpl(Inline)]
        public static string Format(this TernaryOpKind kind)
            => kind.ToString();

        [MethodImpl(Inline)]
        public static string Format<T>(this TernaryOpKind kind, T arg1, T arg2, T arg3)
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
 
        public static string FormatTuple(IEnumerable<IOperator> terms)            
            => parenthetical(string.Join(',',terms.Select(t => t.Format()))); 
    }
}
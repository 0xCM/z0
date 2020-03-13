//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Root;
    
    /// <summary>
    /// Classifies unary arithmetic operators
    /// </summary>
    public enum UnaryArithmeticKind : byte
    {
        None = 0,

        Inc = 1,

        Dec = 2,

        Negate = 3,

        Abs,

        Square,

        Sqrt,
    }    

    partial class ClassifierFormat
    {
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
    }
}
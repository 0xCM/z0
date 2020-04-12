//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Classifies unary logic operators
    /// </summary>
    public enum UnaryLogicKind : byte
    {
        None = 0,
        
        /// <summary>
        /// The unary operator that always returns false
        /// </summary>
        False = 0b00,

        /// <summary>
        /// Logial NOT
        /// </summary>
        Not = 0b01,        

        /// <summary>
        /// The identity operator
        /// </summary>
        Identity = 0b10,
        
        /// <summary>
        /// The unary operator that always returns true
        /// </summary>
        True = 0b11,        
    }  

    public static partial class XTend
    {
        [MethodImpl(Inline)]
        public static string Format(this UnaryLogicKind kind)
            => kind.ToString().ToLower();

        [MethodImpl(Inline)]
        public static string Format<T>(this UnaryLogicKind kind, T arg)
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

        [MethodImpl(Inline)]
        public static string Format<T>(this BinaryArithmeticKind kind, T arg1, T arg2)
            => $"{kind.ToString().ToLower()}({arg1}, {arg2})";
    }
}
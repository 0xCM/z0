//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static CalculatorCode;

    using E = BinaryOpEvaluator;

    public readonly struct CalcNative
    {
        /// <summary>
        /// Executes the code defined by <see cref="mul_ᐤ8uㆍ8uᐤ" over caller-supplied operands/>
        /// </summary>
        /// <param name="f">The function selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        public static byte eval(Kinds.Mul f, byte x, byte y)
            => E.eval(f, mul_ᐤ8uㆍ8uᐤ, x,y);

        /// <summary>
        /// Executes the code defined by <see cref="sub_ᐤ8uㆍ8uᐤ" over caller-supplied operands/>
        /// </summary>
        /// <param name="f">The function selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        public static byte eval(Kinds.Sub f, byte x, byte y)
            => E.eval(f,sub_ᐤ8uㆍ8uᐤ, x, y );

        /// <summary>
        /// Executes the code defined by <see cref="and_ᐤ8uㆍ8uᐤ" over caller-supplied operands/>
        /// </summary>
        /// <param name="f">The function selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        public static byte eval(BitLogicKinds.And f, byte x, byte y)
            => E.eval(f, and_ᐤ8uㆍ8uᐤ, x, y);
    }
}
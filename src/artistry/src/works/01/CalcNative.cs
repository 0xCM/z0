//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static CalculatorCode;

    public readonly struct CalcNative
    {
        /// <summary>
        /// Executes the code defined by <see cref="mul_ᐤ8uㆍ8uᐤ" over caller-supplied operands/>
        /// </summary>
        /// <param name="f">The function selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        public static byte eval(Kinds.Mul f, byte x, byte y)
            => Evaluator.eval(x,y, mul_ᐤ8uㆍ8uᐤ);

        /// <summary>
        /// Executes the code defined by <see cref="sub_ᐤ8uㆍ8uᐤ" over caller-supplied operands/>
        /// </summary>
        /// <param name="f">The function selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        public static byte eval(Kinds.Sub f, byte x, byte y)
            => Evaluator.eval(x, y, sub_ᐤ8uㆍ8uᐤ);

        /// <summary>
        /// Executes the code defined by <see cref="and_ᐤ8uㆍ8uᐤ" over caller-supplied operands/>
        /// </summary>
        /// <param name="f">The function selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        public static byte eval(Kinds.And f, byte x, byte y)
            => Evaluator.eval(x, y, and_ᐤ8uㆍ8uᐤ);
    }
}
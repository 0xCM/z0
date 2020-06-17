//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using M = CalcManaged;
    using N = CalcNative;

    public readonly struct CalculatorCheck
    {
        /// <summary>
        /// Tests whether the disassembled code, when executed, agrees with the reference implemenation
        /// </summary>
        /// <param name="kind">The function selector</param>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        public static bit check(Kinds.And f, byte x, byte y)
        {
            var expect = M.mul(x,y);
            var actual = N.eval(f, x, y);
            return actual == expect;
        }
    }
}
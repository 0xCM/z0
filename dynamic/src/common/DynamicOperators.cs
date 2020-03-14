//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;

    public static class DynamicOperators
    {
        /// <summary>
        /// Creates a 128-bit vectorized unary operator with an embedded immediate value from a non-generic 
        /// source method that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        public static DynamicDelegate V128EmbedUnaryImm(this MethodInfo src, byte imm8)
            => Dynop.CreateImmV128UnaryOp(src, imm8);

        /// <summary>
        /// Creates a 128-bit vectorized unary operator with an embedded immediate value from a non-generic 
        /// source method that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        public static DynamicDelegate V256EmbedUnaryImm(this MethodInfo src, byte imm8)
            => Dynop.CreateImmV256UnaryOp(src, imm8);
    }
}
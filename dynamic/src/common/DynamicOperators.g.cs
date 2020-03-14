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

    public static class DynamicOperatorsG
    {
        /// <summary>
        /// Creates a 128-bit parametric vectorized unary operator with an embedded immediate value from a 
        /// source method that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static DynamicDelegate<UnaryOp<Vector128<T>>> V128EmbedUnaryImm<T>(this MethodInfo src, byte imm)
            where T : unmanaged
                => Dynop.CreateImmV128UnaryOp<T>(src,imm);

        /// <summary>
        /// Creates a parametric 128-bit vectorized unary operator that adapts a like-kinded operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static DynamicDelegate<UnaryOp<Vector256<T>>> V256EmbedUnaryImm<T>(this MethodInfo src, byte imm)        
            where T : unmanaged
                => Dynop.CreateImmV256UnaryOp<T>(src,imm);

        /// <summary>
        /// Creates a parametric 128-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static DynamicDelegate<BinaryOp<Vector128<T>>> V128EmbedBinaryImm<T>(this MethodInfo src, byte imm)
            where T : unmanaged
                => Dynop.CreateImmV128BinaryOp<T>(src,imm);

        /// <summary>
        /// Creates a parametric 256-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static DynamicDelegate<BinaryOp<Vector256<T>>> V256BEmbedBinaryImm<T>(this MethodInfo src, byte imm)        
            where T : unmanaged                   
                => Dynop.CreateImmV256BinaryOp<T>(src,imm);
    }
}

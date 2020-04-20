//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;

    using static Seed;

    using K = Kinds;

    public interface IDynamicVImm
    {
        /// <summary>
        /// Creates a 128-bit vectorized parametric unary operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]            
        DynamicDelegate<UnaryOp<Vector128<T>>> CreateImmV128UnaryOp<T>(MethodInfo src, byte imm)
            where T : unmanaged;

        /// <summary>
        /// Creates a parametric 128-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        DynamicDelegate<BinaryOp<Vector128<T>>> CreateImmV128BinaryOp<T>(MethodInfo src, byte imm)
            where T : unmanaged;

        /// <summary>
        /// Creates a parametric 128-bit vectorized unary operator that adapts a like-kinded operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        DynamicDelegate<UnaryOp<Vector256<T>>> CreateImmV256UnaryOp<T>(MethodInfo src, byte imm)        
            where T : unmanaged;


        /// <summary>
        /// Creates a parametric 256-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        DynamicDelegate<BinaryOp<Vector256<T>>> CreateV256BinaryOpImm<T>(MethodInfo src, byte imm)        
            where T : unmanaged;

        Option<DynamicDelegate> EmbedVUnaryOpImm(MethodInfo src, byte imm8, OpIdentity id);

        Option<DynamicDelegate> EmbedVUnaryOpImm(MethodInfo src, byte imm8);

        Option<DynamicDelegate> EmbedVBinaryOpImm(MethodInfo src, byte imm8, OpIdentity id);

        Option<DynamicDelegate> EmbedVBinaryOpImm(MethodInfo src, byte imm8);

        //Option<DynamicDelegate> EmbedV256UnaryOpImm(MethodInfo src, byte imm8, OpIdentity id);
    }   
}
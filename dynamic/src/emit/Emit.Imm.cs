//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Root;

    partial class Dynop
    {
        /// <summary>
        /// Creates a non-parametric 256-bit vectorized unary operator that adapts a like-kinded operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]            
        public static DynamicDelegate EmitImmV256UnaryOp(MethodInfo src, byte imm)
            => EmitImmV256UnaryOpProducer(src)(imm);

        static Func<byte,DynamicDelegate> EmitImmV256UnaryOpProducer(MethodInfo src)
            => imm8 => EmitImmV256UnaryOp(Identity.identify(src), src,imm8, src.ParameterTypes().First());

        /// <summary>
        /// Creates a non-parametric 128-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]            
        public static DynamicDelegate EmitImmV128BinaryOp(MethodInfo src, byte imm)
            => EmitImmV128BinaryOpProducer(src)(imm);

        static Func<byte,DynamicDelegate> EmitImmV128BinaryOpProducer(MethodInfo src)
            => imm8 => EmitImmV128BinaryOp(Identity.identify(src), src, imm8, src.ParameterTypes().First());

        /// <summary>
        /// Creates a non-parametric 256-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]            
        public static DynamicDelegate EmitImmV256BinaryOp(MethodInfo src, byte imm)
            => EmitImmV256BinaryOpProducer(src)(imm);

        static Func<byte,DynamicDelegate> EmitImmV256BinaryOpProducer(MethodInfo src)
            => imm8 => EmitImmV256BinaryOp(Identity.identify(src),src, imm8, src.ParameterTypes().First());

        /// <summary>
        /// Creates a vectorized binary operator with an immediate capture
        /// </summary>
        /// <param name="k">The kind selector</param>
        /// <param name="method">The method that defines a unary operator that accepts an immediate value in the third operand</param>
        /// <param name="baseid">The identity upon which the dynamic immediate will be predicated</param>
        /// <param name="imm">The immediate value to capture</param>
        public static DynamicDelegate EmitImmVBinaryOp(VKT.Vec k, MethodInfo method, OpIdentity baseid, byte imm)
            => EmitImmVBinaryOpProducer(k,method,baseid)(imm);

         /// <summary>
        /// Creates a parametric 256-bit vectorized unary operator that adapts a like-kinded operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="k">The kind selector</param>
        /// <param name="method">The method that defines a unary operator that accepts an immediate value in the second operand</param>
        /// <param name="baseid">The identity upon which the dynamic immediate will be predicated</param>
        /// <param name="imm">The immediate value to capture</param>
        public static DynamicDelegate EmitImmVUnaryOp(VKT.Vec k, MethodInfo method, OpIdentity baseid, byte imm)
            => EmitImmVUnaryOpProducer(k,method,baseid)(imm);

        /// <summary>
        /// Creates a non-parametric 128-bit vectorized unary operator that adapts a like-kinded operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]            
        public static DynamicDelegate EmitImmV128UnaryOp(MethodInfo src, byte imm)
            => EmitImmV128UnaryOpProducer(src)(imm);

        static Func<byte,DynamicDelegate> EmitImmV128UnaryOpProducer(MethodInfo src)
            => imm8 => EmitImmV128UnaryOp(Identity.identify(src), src, imm8, src.ParameterTypes().First());
    }
}
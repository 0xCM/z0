//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static Root;

    partial class Dynop
    {

        public static DynamicDelegate<BinaryOp<Vector128<T>>> CreateImmVBinaryOp<T>(VKT.Vec128<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector128<T>);                        
            var wrapper = DynamicSignature(reified.Name, reified.DeclaringType, operand, operand, operand);            
            wrapper.GetILGenerator().EmitImmBinaryCall(reified,imm8);
            return DynamicDelegate.Create<BinaryOp<Vector128<T>>>(wrapper, id.WithImm8(imm8), reified);
        }

        public static DynamicDelegate<BinaryOp<Vector256<T>>> CreateImmVBinaryOp<T>(VKT.Vec256<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector256<T>);  
            var wrapper = DynamicSignature(reified.Name, reified.DeclaringType, operand, operand, operand);            
            var gen = wrapper.GetILGenerator();
            wrapper.GetILGenerator().EmitImmBinaryCall(reified,imm8);
            return DynamicDelegate.Create<BinaryOp<Vector256<T>>>(wrapper, id.WithImm8(imm8), reified);
        }

        public static DynamicDelegate<UnaryBlockedOp128<T>> CreateImmBlockedUnaryOp<T>(N128 w, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Block128<T>); 
            var dst = DynamicSignature(reified.Name, reified.DeclaringType, @return: operand, args: array(operand, operand));            
            var gen = dst.GetILGenerator();
            gen.Emit(OpCodes.Ldarg_0);
            gen.EmitImmLoad(imm8);
            gen.Emit(OpCodes.Ldarg_1);
            gen.EmitCall(OpCodes.Call, reified, null);
            gen.Emit(OpCodes.Ret);
            return DynamicDelegate.Create<UnaryBlockedOp128<T>>(dst, id.WithImm8(imm8), reified);
        }

        public static DynamicDelegate<UnaryOp<Vector128<T>>> CreateImmVUnaryOp<T>(VKT.Vec128<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector128<T>); 
            var dst = DynamicSignature(reified.Name, reified.DeclaringType, operand, operand);            
            dst.GetILGenerator().EmitImmUnaryCall(reified, imm8);
            return DynamicDelegate.Create<UnaryOp<Vector128<T>>>(dst, id.WithImm8(imm8), reified);
        }

        public static DynamicDelegate<UnaryOp<Vector256<T>>> CreateImmVUnaryOp<T>(VKT.Vec256<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector256<T>);                        
            var dst = DynamicSignature(reified.Name, reified.DeclaringType, operand, operand);            
            dst.GetILGenerator().EmitImmUnaryCall(reified,imm8);
            return DynamicDelegate.Create<UnaryOp<Vector256<T>>>(dst, id.WithImm8(imm8), reified);
        }

        /// <summary>
        /// Creates a 128-bit vectorized parametric unary operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]            
        public static DynamicDelegate<UnaryOp<Vector128<T>>> CreateImmV128UnaryOp<T>(MethodInfo src, byte imm)
            where T : unmanaged
        {
            static Func<byte,DynamicDelegate<UnaryOp<Vector128<T>>>> producer(OpIdentity id, MethodInfo src)
                => imm8 => CreateImmVUnaryOp(VK.vk128<T>(),id, src,imm8);
            
            return producer(Identity.identify(src), src)(imm);
        }

        /// <summary>
        /// Creates a parametric 128-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static DynamicDelegate<BinaryOp<Vector128<T>>> CreateImmV128BinaryOp<T>(MethodInfo src, byte imm)
            where T : unmanaged
        {
            static Func<byte,DynamicDelegate<BinaryOp<Vector128<T>>>> producer(OpIdentity id, MethodInfo src)            
                => imm8 => CreateImmVBinaryOp(VK.vk128<T>(), id, src,imm8);

            return producer(Identity.identify(src), src)(imm);
        }

        /// <summary>
        /// Creates a parametric 128-bit vectorized unary operator that adapts a like-kinded operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static DynamicDelegate<UnaryOp<Vector256<T>>> CreateImmV256UnaryOp<T>(MethodInfo src, byte imm)        
            where T : unmanaged
        {
            static Func<byte,DynamicDelegate<UnaryOp<Vector256<T>>>> producer(MethodInfo src, OpIdentity id)
                => imm8 => CreateImmVUnaryOp(VK.vk256<T>(), id, src, imm8);

            return producer(src,Identity.identify(src))(imm);
        }

        /// <summary>
        /// Creates a parametric 256-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static DynamicDelegate<BinaryOp<Vector256<T>>> CreateImmV256BinaryOp<T>(MethodInfo src, byte imm)        
            where T : unmanaged
        {            
            static Func<byte,DynamicDelegate<BinaryOp<Vector256<T>>>> producer(MethodInfo src, OpIdentity id)
                => imm8 => CreateImmVBinaryOp(VK.vk256<T>(), id, src, imm8);

            return producer(src,Identity.identify(src))(imm);
        }

    }

}
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
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;
    using System.Linq;

    using static Core;
    using static VectorKinds;

    partial class Dynop
    {
        public static DynamicDelegate<BinaryOp<Vector128<T>>> EmbedVBinaryOpImm<T>(Vec128Kind<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var wrapped = src.Reify(typeof(T));
            var tId = id.WithImm8(imm8);
            var tOperand = typeof(Vector128<T>);
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand, tOperand);            
            target.GetILGenerator().EmitImmBinaryCall(wrapped,imm8);
            return DynamicDelegate.Create<BinaryOp<Vector128<T>>>(tId, wrapped, target);
        }

        public static DynamicDelegate<BinaryOp<Vector256<T>>> EmbedImmVBinaryOpImm<T>(Vec256Kind<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var wrapped = src.Reify(typeof(T));
            var tId = id.WithImm8(imm8);
            var tOperand = typeof(Vector256<T>);  
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand, tOperand);            
            target.GetILGenerator().EmitImmBinaryCall(wrapped,imm8);
            return DynamicDelegate.Create<BinaryOp<Vector256<T>>>(tId, wrapped, target);
        }

        public static DynamicDelegate<UnaryBlockedOp128<T>> EmbedBlockedUnaryOpImm<T>(N128 w, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var wrapped = src.Reify(typeof(T));
            var tId = id.WithImm8(imm8);
            var tOperand = typeof(Block128<T>); 
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, @return: tOperand, args: array(tOperand, tOperand));            
            var gTarget = target.GetILGenerator();
            gTarget.Emit(OpCodes.Ldarg_0);
            gTarget.EmitImmLoad(imm8);
            gTarget.Emit(OpCodes.Ldarg_1);
            gTarget.EmitCall(OpCodes.Call, wrapped, null);
            gTarget.Emit(OpCodes.Ret);
            return DynamicDelegate.Create<UnaryBlockedOp128<T>>(tId, wrapped, target);
        }

        public static DynamicDelegate<UnaryOp<Vector128<T>>> EmbedVUnaryOpImm<T>(Vec128Kind<T> k, OpIdentity baseid, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var wrapped = src.Reify(typeof(T));
            var tId = baseid.WithImm8(imm8);
            var tOperand = typeof(Vector128<T>); 
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand);            
            target.GetILGenerator().EmitImmUnaryCall(wrapped, imm8);
            return DynamicDelegate.Create<UnaryOp<Vector128<T>>>(tId, wrapped, target);
        }

        public static DynamicDelegate<UnaryOp<Vector256<T>>> EmbedVUnaryOpImm<T>(Vec256Kind<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var wrapped = src.Reify(typeof(T));
            var tId = id.WithImm8(imm8);
            var tOperand = typeof(Vector256<T>);                        
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand);            
            target.GetILGenerator().EmitImmUnaryCall(wrapped, imm8);
            return DynamicDelegate.Create<UnaryOp<Vector256<T>>>(tId, wrapped, target);
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
                => EmbedVUnaryOpImm(vk128<T>(), Identity.identify(src), src, imm);

        /// <summary>
        /// Creates a parametric 128-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static DynamicDelegate<BinaryOp<Vector128<T>>> CreateImmV128BinaryOp<T>(MethodInfo src, byte imm)
            where T : unmanaged
                => EmbedVBinaryOpImm(vk128<T>(), Identity.identify(src), src, imm);

        /// <summary>
        /// Creates a parametric 128-bit vectorized unary operator that adapts a like-kinded operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static DynamicDelegate<UnaryOp<Vector256<T>>> CreateImmV256UnaryOp<T>(MethodInfo src, byte imm)        
            where T : unmanaged
                => EmbedVUnaryOpImm(vk256<T>(), Identity.identify(src), src, imm);

        /// <summary>
        /// Creates a parametric 256-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static DynamicDelegate<BinaryOp<Vector256<T>>> EmbedV256BinaryOpImm<T>(MethodInfo src, byte imm)        
            where T : unmanaged
                => EmbedImmVBinaryOpImm(vk256<T>(), Identity.identify(src), src, imm);

        public static DynamicDelegate<UnaryOp<Vector128<T>>> EmbedV128UnaryOpImm<T>(MethodInfo src, byte imm8, OpIdentity? baseid = null)
            where T : unmanaged
        {
            var idSrc = baseid ?? src.Identify();
            var tCell = typeof(T);
            var wrapped = src.Reify(typeof(T));
            var idTarget = idSrc.WithImm8(imm8);
            var tOperand = typeof(Vector128<T>); 
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand);            
            target.GetILGenerator().EmitImmUnaryCall(wrapped, imm8);
            return DynamicDelegate.Create<UnaryOp<Vector128<T>>>(idTarget, wrapped, target);
        }

        public static DynamicDelegate EmbedV128BinaryOpImm(MethodInfo src, byte imm8, OpIdentity? baseid = null)
        {
            var idSrc = baseid ?? src.Identify();
            var tCell = src.ReturnType.SuppliedTypeArgs().Single();            
            var wrapped = src.Reify(tCell);
            var idTarget = idSrc.WithImm8(imm8);
            var tOperand = typeof(Vector128<>).MakeGenericType(tCell);  
            var tWrapper = typeof(BinaryOp<>).MakeGenericType(tOperand);
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand, tOperand);            
            target.GetILGenerator().EmitImmBinaryCall(wrapped, imm8);
            return DynamicDelegate.Create(idTarget, wrapped, target, tWrapper);
        }

        public static DynamicDelegate EmbedV256BinaryOpImm(MethodInfo src, byte imm8, OpIdentity? baseid = null)
        {
            var idSrc = baseid ?? src.Identify();
            var tCell = src.ReturnType.SuppliedTypeArgs().Single();
            var wrapped = src.Reify(tCell);
            var idTarget = idSrc.WithImm8(imm8);
            var tOperand = typeof(Vector256<>).MakeGenericType(tCell);  
            var tWrapper = typeof(BinaryOp<>).MakeGenericType(tOperand);
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand, tOperand);            
            target.GetILGenerator().EmitImmBinaryCall(wrapped, imm8);
            return DynamicDelegate.Create(idTarget, wrapped, target, tWrapper);
        }

        /// <summary>
        /// Creates a non-parametric vectorized unary operator that adapts a like-kinded 
        /// operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static DynamicDelegate EmbedVUnaryOpImm(MethodInfo src, byte imm8, OpIdentity? baseid = null)
        {
            var tCell = src.ReturnType.SuppliedTypeArgs().Single();
            var id = baseid ?? src.Identify();
            require(NumericKinds.test(tCell));
            var wrapped = src.Reify(tCell);
            var wrapperId = id.WithImm8(imm8);
            var tOperand = src.ReturnType;
            var tWrapper =typeof(UnaryOp<>).MakeGenericType(tOperand); 
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand); 
            target.GetILGenerator().EmitImmUnaryCall(wrapped, imm8);
            return DynamicDelegate.Create(wrapperId, wrapped, target, tWrapper);            
        }

        public static DynamicDelegate EmbedVBinaryOpImm(MethodInfo src, byte imm8, OpIdentity? baseid = null)
        {
            var tCell = src.ReturnType.SuppliedTypeArgs().Single();
            var id = baseid ?? src.Identify();
            require(NumericKinds.test(tCell));
            var wrapped = src.Reify(tCell);
            var wrapperId = id.WithImm8(imm8);
            var tOperand = typeof(Vector256<>).MakeGenericType(tCell);  
            var tWrapper = typeof(BinaryOp<>).MakeGenericType(tOperand);
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand, tOperand);            
            target.GetILGenerator().EmitImmBinaryCall(wrapped, imm8);
            return DynamicDelegate.Create(wrapperId, wrapped, target, tWrapper);
        }
    }
}
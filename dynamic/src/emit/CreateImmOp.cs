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

    using static Root;

    partial class Dynop
    {
        public static DynamicDelegate<BinaryOp<Vector128<T>>> CreateImmVBinaryOp<T>(VKT.Vec128<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var wrapped = src.Reify(typeof(T));
            var tId = id.WithImm8(imm8);
            var tOperand = typeof(Vector128<T>);
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand, tOperand);            
            target.GetILGenerator().EmitImmBinaryCall(wrapped,imm8);
            return DynamicDelegate.Create<BinaryOp<Vector128<T>>>(tId, wrapped, target);
        }

        public static DynamicDelegate<BinaryOp<Vector256<T>>> CreateImmVBinaryOp<T>(VKT.Vec256<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var wrapped = src.Reify(typeof(T));
            var tId = id.WithImm8(imm8);
            var tOperand = typeof(Vector256<T>);  
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand, tOperand);            
            target.GetILGenerator().EmitImmBinaryCall(wrapped,imm8);
            return DynamicDelegate.Create<BinaryOp<Vector256<T>>>(tId, wrapped, target);
        }

        public static DynamicDelegate<UnaryBlockedOp128<T>> CreateImmBlockedUnaryOp<T>(N128 w, OpIdentity id, MethodInfo src, byte imm8)
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

        public static DynamicDelegate CreateImmV128UnaryOp(MethodInfo src, byte imm8)
        {
            var tCell = src.ReturnType.SuppliedTypeArgs().Single();
            return CreateImmV128UnaryOp(src, tCell, imm8);
        }

        public static DynamicDelegate CreateImmV128UnaryOp(MethodInfo src, Type celltype, byte imm8)
        {
            var wrapped = src.Reify(celltype);
            var tId = Identity.identify(src).WithImm8(imm8);
            var tOperand = typeof(Vector128<>).MakeGenericType(celltype);
            var tOp = typeof(UnaryOp<>).MakeGenericType(tOperand);
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand);            
            target.GetILGenerator().EmitImmUnaryCall(wrapped, imm8);
            return DynamicDelegate.Create(tId, wrapped, target, tOp);
        }

        public static DynamicDelegate CreateImmV256UnaryOp(MethodInfo src, byte imm8)
        {
            var tCell = src.ReturnType.SuppliedTypeArgs().Single();
            var wrapped = src.Reify(tCell);
            var tId = Identity.identify(src).WithImm8(imm8);
            var tOperand = typeof(Vector256<>).MakeGenericType(tCell);
            var tOp = typeof(UnaryOp<>).MakeGenericType(tOperand);
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand);            
            target.GetILGenerator().EmitImmUnaryCall(wrapped, imm8);
            return DynamicDelegate.Create(tId, wrapped, target, tOp);
        }

        public static DynamicDelegate<UnaryOp<Vector128<T>>> CreateImmVUnaryOp<T>(VKT.Vec128<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var wrapped = src.Reify(typeof(T));
            var tId = id.WithImm8(imm8);
            var tOperand = typeof(Vector128<T>); 
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand);            
            target.GetILGenerator().EmitImmUnaryCall(wrapped, imm8);
            return DynamicDelegate.Create<UnaryOp<Vector128<T>>>(tId, wrapped, target);
        }

        public static DynamicDelegate<UnaryOp<Vector256<T>>> CreateImmVUnaryOp<T>(VKT.Vec256<T> k, OpIdentity id, MethodInfo src, byte imm8)
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
        {
            static Func<byte,DynamicDelegate<UnaryOp<Vector128<T>>>> producer(OpIdentity id, MethodInfo src)
                => imm8 => CreateImmVUnaryOp(VK.vk128<T>(), id, src, imm8);
                        
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
                => imm8 => CreateImmVBinaryOp(VK.vk128<T>(), id, src, imm8);

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
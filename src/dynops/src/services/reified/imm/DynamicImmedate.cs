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

    using static Seed; 
    using static Memories;
    using static Kinds;

    static class DynamicImmediate
    {
        public static DynamicMethod DynamicSignature(string name, Type owner, Type @return, params Type[] args)
            => new DynamicMethod(name: name, 
                attributes: MethodAttributes.Public | MethodAttributes.Static,  
                callingConvention: CallingConventions.Standard,
                returnType: @return, 
                parameterTypes: args, 
                owner: owner,
                skipVisibility: false);               

        public static DynamicDelegate EmbedV128UnaryOpImm(MethodInfo src, byte imm8, OpIdentity id)
        {
            require(src.ReturnType.IsVector(), $"Method {src.Name} does not return a vector value");
            var tCell = src.ReturnType.SuppliedTypeArgs().Single();            
            var wrapped = src.Reify(tCell);
            var idTarget = id.WithImm8(imm8);
            var tOperand = typeof(Vector128<>).MakeGenericType(tCell);  
            var tWrapper = typeof(UnaryOp<>).MakeGenericType(tOperand);
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand);            
            target.GetILGenerator().EmitImmUnaryCall(wrapped, imm8);
            return DynamicDelegate.Create(idTarget, wrapped, target, tWrapper);
        }

        public static DynamicDelegate EmbedV256UnaryOpImm(MethodInfo src, byte imm8, OpIdentity id)
        {
            require(src.ReturnType.IsVector(), $"Method {src.Name} does not return a vector value");
            var tCell = src.ReturnType.SuppliedTypeArgs().Single();
            var wrapped = src.Reify(tCell);
            var idTarget = id.WithImm8(imm8);
            var tOperand = typeof(Vector256<>).MakeGenericType(tCell);  
            var tWrapper = typeof(UnaryOp<>).MakeGenericType(tOperand);
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand);            
            target.GetILGenerator().EmitImmUnaryCall(wrapped, imm8);
            return DynamicDelegate.Create(idTarget, wrapped, target, tWrapper);
        }

        public static DynamicDelegate EmbedV128BinaryOpImm(MethodInfo src, byte imm8, OpIdentity id)
        {
            require(src.ReturnType.IsVector(), $"Method {src.Name} does not return a vector value");
            var tCell = src.ReturnType.SuppliedTypeArgs().Single();            
            var wrapped = src.Reify(tCell);
            var idTarget = id.WithImm8(imm8);
            var tOperand = typeof(Vector128<>).MakeGenericType(tCell);  
            var tWrapper = typeof(BinaryOp<>).MakeGenericType(tOperand);
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand, tOperand);            
            target.GetILGenerator().EmitImmBinaryCall(wrapped, imm8);
            return DynamicDelegate.Create(idTarget, wrapped, target, tWrapper);
        }

        public static DynamicDelegate EmbedV256BinaryOpImm(MethodInfo src, byte imm8, OpIdentity id)
        {
            require(src.ReturnType.IsVector(), $"Method {src.Name} does not return a vector value");
            var tCell = src.ReturnType.SuppliedTypeArgs().Single();
            var wrapped = src.Reify(tCell);
            var idTarget = id.WithImm8(imm8);
            var tOperand = typeof(Vector256<>).MakeGenericType(tCell);  
            var tWrapper = typeof(BinaryOp<>).MakeGenericType(tOperand);
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand, tOperand);            
            target.GetILGenerator().EmitImmBinaryCall(wrapped, imm8);
            return DynamicDelegate.Create(idTarget, wrapped, target, tWrapper);
        }

        public static Option<DynamicDelegate> EmbedVUnaryOpImm(MethodInfo src, byte imm8, OpIdentity id)
        {
            try
            {
                var width = VectorType.width(src.ReturnType);            
                return width switch{
                    TypeWidth.W128 => EmbedV128UnaryOpImm(src, imm8, id),
                    TypeWidth.W256 => EmbedV256UnaryOpImm(src, imm8, id),
                    _ => none<DynamicDelegate>()
                };
            }
            catch(Exception e)
            {
                term.error(e);
                return none<DynamicDelegate>();
            }
        }

        public static Option<DynamicDelegate> EmbedVBinaryOpImm(MethodInfo src, byte imm8, OpIdentity id)
        {
            try
            {
                var width = VectorType.width(src.ReturnType);
                return width switch{
                    TypeWidth.W128 => EmbedV128BinaryOpImm(src, imm8, id),
                    TypeWidth.W256 => EmbedV256BinaryOpImm(src, imm8, id),
                    _ => none<DynamicDelegate>()
                };
            }
            catch(Exception e)
            {
                term.error(e);
                return none<DynamicDelegate>();
            }
        }


        public static DynamicDelegate<UnaryOp<Vector128<T>>> EmbedVUnaryOpImm<T>(Vec128Kind<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var wrapped = src.Reify(typeof(T));
            var idTarget = id.WithImm8(imm8);
            var tOperand = typeof(Vector128<T>); 
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand);            
            target.GetILGenerator().EmitImmUnaryCall(wrapped, imm8);
            return DynamicDelegate.Create<UnaryOp<Vector128<T>>>(idTarget, wrapped, target);
        }

        public static DynamicDelegate<UnaryOp<Vector256<T>>> EmbedVUnaryOpImm<T>(Vec256Kind<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var wrapped = src.Reify(typeof(T));
            var idTarget = id.WithImm8(imm8);
            var tOperand = typeof(Vector256<T>);                        
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand);            
            target.GetILGenerator().EmitImmUnaryCall(wrapped, imm8);
            return DynamicDelegate.Create<UnaryOp<Vector256<T>>>(idTarget, wrapped, target);
        }

        public static DynamicDelegate<BinaryOp<Vector128<T>>> EmbedVBinaryOpImm<T>(Vec128Kind<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var wrapped = src.Reify(typeof(T));
            var idTarget = id.WithImm8(imm8);
            var tOperand = typeof(Vector128<T>);
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand, tOperand);            
            target.GetILGenerator().EmitImmBinaryCall(wrapped,imm8);
            return DynamicDelegate.Create<BinaryOp<Vector128<T>>>(idTarget, wrapped, target);
        }

        public static DynamicDelegate<BinaryOp<Vector256<T>>> EmbedImmVBinaryOpImm<T>(Vec256Kind<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var wrapped = src.Reify(typeof(T));
            var idTarget = id.WithImm8(imm8);
            var tOperand = typeof(Vector256<T>);  
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand, tOperand);            
            target.GetILGenerator().EmitImmBinaryCall(wrapped,imm8);
            return DynamicDelegate.Create<BinaryOp<Vector256<T>>>(idTarget, wrapped, target);
        }

        public static DynamicDelegate<UnaryBlockedOp128<T>> EmbedBlockedUnaryOpImm<T>(W128 w, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var wrapped = src.Reify(typeof(T));
            var idTarget = id.WithImm8(imm8);
            var tOperand = typeof(Block128<T>); 
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, @return: tOperand, args: array(tOperand, tOperand));            
            var gTarget = target.GetILGenerator();
            gTarget.Emit(OpCodes.Ldarg_0);
            gTarget.EmitImmLoad(imm8);
            gTarget.Emit(OpCodes.Ldarg_1);
            gTarget.EmitCall(OpCodes.Call, wrapped, null);
            gTarget.Emit(OpCodes.Ret);
            return DynamicDelegate.Create<UnaryBlockedOp128<T>>(idTarget, wrapped, target);
        }
    }
}
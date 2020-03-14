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

    partial class Dynop
    {
        static DynamicDelegate EmitImmV128BinaryOp(OpIdentity id, MethodInfo src, byte imm8, Type tCell)
        {
            var wrapped = src.Reify(tCell);
            var tId = id.WithImm8(imm8);
            var tOperand = typeof(Vector128<>).MakeGenericType(tCell);  
            var tOp = typeof(BinaryOp<>).MakeGenericType(tOperand);
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand, tOperand);            
            target.GetILGenerator().EmitImmBinaryCall(wrapped, imm8);
            return DynamicDelegate.Create(tId, wrapped, target, tOp);
        }

        static DynamicDelegate EmitImmV256BinaryOp(OpIdentity id, MethodInfo src, byte imm8, Type tCell)
        {
            var wrapped = src.Reify(tCell);
            var tId = id.WithImm8(imm8);
            var tOperand = typeof(Vector256<>).MakeGenericType(tCell);  
            var tOp = typeof(BinaryOp<>).MakeGenericType(tOperand);
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand, tOperand);            
            target.GetILGenerator().EmitImmBinaryCall(wrapped, imm8);
            return DynamicDelegate.Create(tId, wrapped, target, tOp);
        }

        static DynamicDelegate EmitImmVUnaryOp(Type typedef, OpIdentity id, MethodInfo src, byte imm8, Type tCell)
        {
            var wrapped = src.Reify(tCell);
            var tId = id.WithImm8(imm8);
            var tOperand = typedef.MakeGenericType(tCell); 
            var tOp = typeof(UnaryOp<>).MakeGenericType(tOperand);
            var target = DynamicSignature(wrapped.Name, wrapped.DeclaringType, tOperand, tOperand);            
            target.GetILGenerator().EmitImmUnaryCall(wrapped, imm8);
            return DynamicDelegate.Create(tId, wrapped, target, tOp);
        }

        static DynamicDelegate EmitImmV128UnaryOp(OpIdentity id, MethodInfo src, byte imm8, Type tCell)
            => EmitImmVUnaryOp(typeof(Vector128<>), id, src, imm8, tCell);

        static DynamicDelegate EmitImmV256UnaryOp(OpIdentity id, MethodInfo src, byte imm8, Type tCell)
            => EmitImmVUnaryOp(typeof(Vector256<>), id, src, imm8, tCell);        

        static ILGenerator EmitImmLoad(this ILGenerator gTarget, byte imm)
        {
            var code = imm switch {
                0 => OpCodes.Ldc_I4_0,
                1 => OpCodes.Ldc_I4_1,
                2 => OpCodes.Ldc_I4_2,
                3 => OpCodes.Ldc_I4_3,
                4 => OpCodes.Ldc_I4_4,
                5 => OpCodes.Ldc_I4_5,
                6 => OpCodes.Ldc_I4_6,
                7 => OpCodes.Ldc_I4_7,
                8 => OpCodes.Ldc_I4_8,
                _ => OpCodes.Ldc_I4_S
            }; 
            if(imm <= 8)
                gTarget.Emit(code);
            else
                gTarget.Emit(code, imm);

            return gTarget;
        }

        static void EmitImmBinaryCall(this ILGenerator gTarget, MethodInfo wrapped, byte imm8)        
        {
            gTarget.Emit(OpCodes.Ldarg_0);
            gTarget.Emit(OpCodes.Ldarg_1);
            gTarget.EmitImmLoad(imm8);
            gTarget.EmitCall(OpCodes.Call, wrapped, null);
            gTarget.Emit(OpCodes.Ret);
        }

        static void EmitImmUnaryCall(this ILGenerator gTarget, MethodInfo wrapped, byte imm8)        
        {
            gTarget.Emit(OpCodes.Ldarg_0);
            gTarget.EmitImmLoad(imm8);
            gTarget.EmitCall(OpCodes.Call, wrapped, null);
            gTarget.Emit(OpCodes.Ret);
        }
    }
}
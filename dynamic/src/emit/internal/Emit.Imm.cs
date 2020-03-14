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
    using System.Linq;

    using static Root;
    using static FKT;
    using static Nats;

    partial class Dynop
    {
        static ILGenerator EmitImmLoad(this ILGenerator g, byte imm)
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
                g.Emit(code);
            else
                g.Emit(code, imm);

            return g;
        }

        static void EmitImmBinaryCall(this ILGenerator g, MethodInfo reified, byte imm8)        
        {
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);
            g.EmitImmLoad(imm8);
            g.EmitCall(OpCodes.Call, reified, null);
            g.Emit(OpCodes.Ret);
        }

        static void EmitImmUnaryCall(this ILGenerator g, MethodInfo reified, byte imm8)        
        {
            g.Emit(OpCodes.Ldarg_0);
            g.EmitImmLoad(imm8);
            g.EmitCall(OpCodes.Call, reified, null);
            g.Emit(OpCodes.Ret);
        }

        static DynamicDelegate EmitImmV128BinaryOp(OpIdentity id, MethodInfo src, byte imm8, Type component)
        {
            var reified = src.Reify(component);
            var operand = typeof(Vector128<>).MakeGenericType(component);  
            var target = typeof(BinaryOp<>).MakeGenericType(operand);
            var dst = DynamicSignature(reified.Name, reified.DeclaringType, operand, operand, operand);            
            var gen = dst.GetILGenerator();
            dst.GetILGenerator().EmitImmBinaryCall(reified,imm8);
            return DynamicDelegate.Create(dst, id.WithImm8(imm8),reified, target);
        }

        static DynamicDelegate EmitImmV256BinaryOp(OpIdentity id, MethodInfo src, byte imm8, Type component)
        {
            var reified = src.Reify(component);
            var operand = typeof(Vector256<>).MakeGenericType(component);  
            var target = typeof(BinaryOp<>).MakeGenericType(operand);
            var dst = DynamicSignature(reified.Name, reified.DeclaringType, operand, operand, operand);            
            var gen = dst.GetILGenerator();
            dst.GetILGenerator().EmitImmBinaryCall(reified,imm8);
            return DynamicDelegate.Create(dst, id.WithImm8(imm8),reified, target);
        }

        static DynamicDelegate EmitImmVUnaryOp(Type typedef, OpIdentity id, MethodInfo inner, byte imm8, Type component)
        {
            var reified = inner.Reify(component);
            var operand = typedef.MakeGenericType(component); 
            var target = typeof(UnaryOp<>).MakeGenericType(operand);
            var dst = DynamicSignature(reified.Name, reified.DeclaringType, operand, operand);            
            dst.GetILGenerator().EmitImmUnaryCall(reified, imm8);
            return DynamicDelegate.Create(dst, id.WithImm8(imm8), reified, target);
        }

        static DynamicDelegate EmitImmV128UnaryOp(OpIdentity id, MethodInfo src, byte imm8, Type seg)
            => EmitImmVUnaryOp(typeof(Vector128<>), id, src, imm8, seg);

        static DynamicDelegate EmitImmV256UnaryOp(OpIdentity id, MethodInfo src, byte imm8, Type seg)
            => EmitImmVUnaryOp(typeof(Vector256<>), id, src, imm8, seg);        
    }
}
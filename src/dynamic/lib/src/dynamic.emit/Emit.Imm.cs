//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;

    partial class Dynop
    {
        internal static ILGenerator EmitImmLoad(this ILGenerator gTarget, byte imm)
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

        internal static void EmitImmBinaryCall(this ILGenerator gTarget, MethodInfo wrapped, byte imm8)        
        {
            gTarget.Emit(OpCodes.Ldarg_0);
            gTarget.Emit(OpCodes.Ldarg_1);
            gTarget.EmitImmLoad(imm8);
            gTarget.EmitCall(OpCodes.Call, wrapped, null);
            gTarget.Emit(OpCodes.Ret);
        }

        internal static void EmitImmUnaryCall(this ILGenerator gTarget, MethodInfo wrapped, byte imm8)        
        {
            gTarget.Emit(OpCodes.Ldarg_0);
            gTarget.EmitImmLoad(imm8);
            gTarget.EmitCall(OpCodes.Call, wrapped, null);
            gTarget.Emit(OpCodes.Ret);
        }
    }
}
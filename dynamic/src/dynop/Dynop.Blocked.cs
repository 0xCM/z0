//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Linq;

    using static Root;

    partial class Dynop
    {
        public static DynamicDelegate<UnaryBlockedOp128<T>> ImmBlockedUnaryOp<T>(N128 w, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Block128<T>); 
            var generated = DynamicSignature(reified.Name, reified.DeclaringType, @return: operand, args: array(operand, operand));            
            var gen = generated.GetILGenerator();
            gen.Emit(OpCodes.Ldarg_0);
            gen.EmitImmLoad(imm8);
            gen.Emit(OpCodes.Ldarg_1);
            gen.EmitCall(OpCodes.Call, reified, null);
            gen.Emit(OpCodes.Ret);
            return generated.CreateDynamicDelegate<UnaryBlockedOp128<T>>(id.WithImm8(imm8), reified);
        }
   }
}
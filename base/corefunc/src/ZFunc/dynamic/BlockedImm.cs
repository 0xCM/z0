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
    using System.Reflection.Emit;
    using System.Runtime.Intrinsics.X86;
    
    using static zfunc;    
    using static As;


    public static class BlockedImm
    {
        public static DynamicDelegate<UnaryBlockedOp128<T>> unary<T>(N128 w, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Block128<T>); 
            var method = DynamicEmit.method(reified.Name, reified.DeclaringType, @return: operand, args: array(operand, operand));            
            var gen = method.GetILGenerator();
            gen.Emit(OpCodes.Ldarg_0);
            gen.EmitConstLoad(imm8);
            gen.Emit(OpCodes.Ldarg_1);
            gen.EmitCall(OpCodes.Call, reified, null);
            gen.Emit(OpCodes.Ret);
            return method.CreateDelegate<UnaryBlockedOp128<T>>(reified);
        }

    }
}

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

    using static zfunc;

    static class EmissionX
    {
        public static void UnaryEmit(this ILGenerator g, MethodInfo reified, byte imm8)        
        {
            g.Emit(OpCodes.Ldarg_0);
            g.EmitConstLoad(imm8);
            g.EmitCall(OpCodes.Call, reified, null);
            g.Emit(OpCodes.Ret);
        }

        public static void BinaryEmit(this ILGenerator g, MethodInfo reified, byte imm8)        
        {
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);
            g.EmitConstLoad(imm8);
            g.EmitCall(OpCodes.Call, reified, null);
            g.Emit(OpCodes.Ret);
        }


    }

}
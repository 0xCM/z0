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

    using static Part;
    using static z;

    [ApiHost]
    public readonly struct FunctionEmitter
    {
        public static Func<T0,R> emit<T0,R>(ApiCodeBlock src, Span<byte> buffer, out Func<T0,R> fx)
        {
            fx = (Func<T0,R>)DynamicFunctions.create(n1).Emit(src.OpUri.OpId, functype:typeof(Func<T0,R>), result:typeof(R), args: array(typeof(T0)), buffer);
            return fx;
        }

        public static void emit<T>(N1 n, ApiCodeBlock code, MemoryAddress dst, out UnaryOp<T> fx)
            where T : unmanaged
        {
            var tOperand = typeof(T);
            var tResult = typeof(T);
            var tOperator = typeof(UnaryOp<T>);
            var builder = DynamicFunctions.create(n);
            fx = (UnaryOp<T>)builder.Emit(code.OpUri.OpId, functype:tOperator, result:tResult, args: array(tOperand), dst);
        }

        public static void emit<T>(N2 n, ApiCodeBlock code, MemoryAddress dst, out BinaryOp<T> fx)
            where T : unmanaged
        {
            var tOperand = typeof(T);
            var tResult = typeof(T);
            var tOperator = typeof(BinaryOp<T>);
            var builder = DynamicFunctions.create(n);
            fx = (BinaryOp<T>)builder.Emit(code.OpUri.OpId, functype:tOperator, result:tResult, args: array(tOperand), dst);
        }

        public static void emit<T>(N3 n, ApiCodeBlock code, MemoryAddress dst, out TernaryOp<T> fx)
            where T : unmanaged
        {
            var tOperand = typeof(T);
            var tResult = typeof(T);
            var tOperator = typeof(TernaryOp<T>);
            var builder = DynamicFunctions.create(n);
            fx = (TernaryOp<T>)builder.Emit(code.OpUri.OpId, functype:tOperator, result:tResult, args: array(tOperand), dst);
        }

        public static void emit<T0,T1,R>(MethodInfo src, bool calli, out Func<T0,T1,R> fx)
        {
            var args = new Type[]{typeof(T0), typeof(T1)};
            var returnType = typeof(R);
            var method = new DynamicMethod(src.Name, returnType, args, src.Module);
            var g = method.GetILGenerator();
            if(calli)
            {
                g.Emit(OpCodes.Ldarg_0);
                g.Emit(OpCodes.Ldarg_1);
                g.EmitCall(OpCodes.Call, src, null);
                g.Emit(OpCodes.Ret);
            }
            else
            {
                g.Emit(OpCodes.Ldarg_0);
                g.Emit(OpCodes.Ldarg_1);
                g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, args);
                g.Emit(OpCodes.Ret);
            }

            fx = (Func<T0,T1,R>)method.CreateDelegate(typeof(Func<T0,T1,R>));
        }
    }
}
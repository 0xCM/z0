//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Reflection;
    using System.Reflection.Emit;

    using static zfunc;
    
    [SuppressUnmanagedCodeSecurity]
    public static unsafe class AsmDelegate
    {
        /// <summary>
        /// Creates a value-producing operator that accepts no arguments
        /// </summary>
        /// <param name="code">The code to execute</param>
        /// <typeparam name="T">The emission type</typeparam>
        public static Emitter<T> CreateEmitter<T>(this AsmCode code)
            where T : unmanaged
        {
            var t = typeof(T);
            var argTypes = new Type[]{};
            var returnType = t;
            var method = new DynamicMethod(code.Name, returnType, argTypes, t.Module);            
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldc_I8, (long)code.Pointer);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, argTypes);
            g.Emit(OpCodes.Ret);
            
            return (Emitter<T>)method.CreateDelegate(typeof(Emitter<T>));
        }

        public static BinaryOp<T> CreateBinOp<T>(long pCode, Moniker m)
            where T : unmanaged
        {
            var t = typeof(T);
            var argTypes = new Type[]{t,t};
            var returnType = t;
            var method = new DynamicMethod(m, returnType, argTypes, t.Module);            
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);
            g.Emit(OpCodes.Ldc_I8, pCode);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, argTypes);
            g.Emit(OpCodes.Ret);
            return (BinaryOp<T>)method.CreateDelegate(typeof(BinaryOp<T>));
        }

        /// <summary>
        /// Creates a unary operator 
        /// </summary>
        /// <param name="code">The code to execute</param>
        /// <param name="name">The operator name</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static UnaryOp<T> CreateUnaryOp<T>(long pCode, Moniker m)
            where T : unmanaged
        {
            var t = typeof(T);
            var argTypes = new Type[]{t};
            var returnType = t;
            var method = new DynamicMethod(m, returnType, argTypes, t.Module);            
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldc_I8, pCode);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, argTypes);
            g.Emit(OpCodes.Ret);
            return (UnaryOp<T>)method.CreateDelegate(typeof(UnaryOp<T>));
        }

    }
}
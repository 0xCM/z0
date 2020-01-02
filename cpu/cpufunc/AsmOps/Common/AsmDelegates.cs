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
    public delegate T AsmEmitter<T>()
        where T : unmanaged;

    [SuppressUnmanagedCodeSecurity]
    public static unsafe class AsmDelegate
    {
        /// <summary>
        /// Creates a value-producing assembly operator that accepts no arguments
        /// </summary>
        /// <param name="code">The code to execute</param>
        /// <param name="name">The emitter name</param>
        /// <typeparam name="T">The emission type</typeparam>
        public static AsmEmitter<T> CreateEmitter<T>(this AsmCode<T> code, string name = null)
            where T : unmanaged

        {
            var t = typeof(T);
            var argTypes = new Type[]{};
            var returnType = t;
            var method = new DynamicMethod(name ?? "anon", returnType, argTypes, t.Module);            
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldc_I8, (long)code.Pointer);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, argTypes);
            g.Emit(OpCodes.Ret);
            
            return (AsmEmitter<T>)method.CreateDelegate(typeof(AsmEmitter<T>));
        }

        /// <summary>
        /// Creates a unary assembly operator 
        /// </summary>
        /// <param name="code">The code to execute</param>
        /// <param name="name">The operator name</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static UnaryOp<T> CreateUnaryOp<T>(this AsmCode<T> code, string name = null)
            where T : unmanaged
        {
            var t = typeof(T);
            var argTypes = new Type[]{t};
            var returnType = t;
            var method = new DynamicMethod(name ?? "anon", returnType, argTypes, t.Module);            
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldc_I8, (long)code.Pointer);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, argTypes);
            g.Emit(OpCodes.Ret);
            return (UnaryOp<T>)method.CreateDelegate(typeof(UnaryOp<T>));
        }

        /// <summary>
        /// Creates a binary assembly operator 
        /// </summary>
        /// <param name="code">The code to execute</param>
        /// <param name="name">The operator name</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static BinaryOp<T> CreateBinOp<T>(this AsmCode<T> code, string name = null)
            where T : unmanaged
        {
            var t = typeof(T);
            var argTypes = new Type[]{t,t};
            var returnType = t;
            var method = new DynamicMethod(name ?? "anon", returnType, argTypes, t.Module);            
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);
            g.Emit(OpCodes.Ldc_I8, (long)code.Pointer);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, argTypes);
            g.Emit(OpCodes.Ret);
            return (BinaryOp<T>)method.CreateDelegate(typeof(BinaryOp<T>));                
        }

        public static BinaryOp<T> CreateBinOp<T>(long pCode, string name = null)
            where T : unmanaged
        {
            var t = typeof(T);
            var argTypes = new Type[]{t,t};
            var returnType = t;
            var method = new DynamicMethod(name ?? "anon", returnType, argTypes, t.Module);            
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);
            g.Emit(OpCodes.Ldc_I8, pCode);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, argTypes);
            g.Emit(OpCodes.Ret);
            return (BinaryOp<T>)method.CreateDelegate(typeof(BinaryOp<T>));
        }


        /// <summary>
        /// Creates a binary assembly operator 
        /// </summary>
        /// <param name="code">The code to execute</param>
        /// <param name="name">The operator name</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static BinaryOp<T> CreateBinOp<T>(byte* pCode, string name = null)
            where T : unmanaged
        {
            var t = typeof(T);
            var argTypes = new Type[]{t,t};
            var returnType = t;
            var method = new DynamicMethod(name ?? "anon", returnType, argTypes, t.Module);            
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);
            g.Emit(OpCodes.Ldc_I8, (long)pCode);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, argTypes);
            g.Emit(OpCodes.Ret);
            return (BinaryOp<T>)method.CreateDelegate(typeof(BinaryOp<T>));
                
        }

    }
}
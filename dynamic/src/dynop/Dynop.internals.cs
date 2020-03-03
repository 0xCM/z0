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

    using static Root;

    public static class DynamicX
    {
        /// <summary>
        /// Finds the magical function pointer for a dynamic method
        /// </summary>
        /// <param name="method">The source method</param>
        /// <remarks>See https://stackoverflow.com/questions/45972562/c-sharp-how-to-get-runtimemethodhandle-from-dynamicmethod</remarks>
        internal static IntPtr NativePointer(this DynamicMethod method)
        {
            var descriptor = typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.NonPublic | BindingFlags.Instance);
            return ((RuntimeMethodHandle)descriptor.Invoke(method, null)).GetFunctionPointer();
        }

        internal static DynamicDelegate<D> CreateDelegate<D>(this DynamicMethod dst, OpIdentity id,  MethodInfo src)
            where D : Delegate
                => new DynamicDelegate<D>(id, src,dst, (D)dst.CreateDelegate(typeof(D)));

        internal static DynamicDelegate CreateDelegate(this DynamicMethod dst, OpIdentity id, MethodInfo src, Type @delegate)
            => new DynamicDelegate(id, src, dst, dst.CreateDelegate(@delegate));

        /// <summary>
        /// Constructs the dynamic pointer determined by the source delegate
        /// </summary>
        /// <param name="src">The source delegate</param>
        [MethodImpl(Inline)]
        internal static unsafe DynamicPointer ToDynamicPtr(this DynamicDelegate src)
            => DynamicPointer.Define(src, src.DynamicMethod.NativePointer());

        /// <summary>
        /// Constructs the dynamic pointer determined by the source delegate
        /// </summary>
        /// <param name="src">The source delegate</param>
        [MethodImpl(Inline)]
        internal static unsafe DynamicPointer ToDynamicPtr<D>(this DynamicDelegate<D> src)
            where D : Delegate
                => DynamicPointer.Define(src, src.DynamicMethod.NativePointer());

        /// <summary>
        /// Creates a binary operator delegate from a conforming method
        /// </summary>
        /// <param name="src">The methodd that defines a binary operator</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static Func<T,T,T> BinOp<T>(this MethodInfo src)
        {
            var operand = typeof(T);                        
            var args = new Type[]{operand, operand};
            var method = new DynamicMethod($"{src.Name}", operand, args, operand.Module);            
            var gen = method.GetILGenerator();
            gen.Emit(OpCodes.Ldarg_0);
            gen.Emit(OpCodes.Ldarg_1);
            gen.EmitCall(OpCodes.Call, src, null);
            gen.Emit(OpCodes.Ret);
            return (Func<T,T,T>) method.CreateDelegate(typeof(Func<T,T,T>));
        }

        /// <summary>
        /// Creates a delegate via dynamic method emit via that is invoked via the Calli opcode
        /// </summary>
        /// <param name="target">The method for which a binary operator delegate will be created</param>
        /// <param name="t">A declaring type representative</param>
        /// <typeparam name="T">The declaring type</typeparam>
        public static Func<T,T,T> BinOpCalli<T>(this MethodInfo target, T t = default)
            where T : unmanaged
        {
            var operand = typeof(T);
            var args = new Type[]{operand, operand};
            var returnType = operand;
            var method = new DynamicMethod($"{target.Name}", returnType, args, operand.Module);            
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, args);
            g.Emit(OpCodes.Ret);
            return (Func<T,T,T>)method.CreateDelegate(typeof(Func<T,T,T>));
        }

        internal static ILGenerator EmitImmLoad(this ILGenerator g, byte imm)
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

        internal static void EmitUnaryImmCall(this ILGenerator g, MethodInfo reified, byte imm8)        
        {
            g.Emit(OpCodes.Ldarg_0);
            g.EmitImmLoad(imm8);
            g.EmitCall(OpCodes.Call, reified, null);
            g.Emit(OpCodes.Ret);
        }

        internal static void EmitBinaryImmCall(this ILGenerator g, MethodInfo reified, byte imm8)        
        {
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);
            g.EmitImmLoad(imm8);
            g.EmitCall(OpCodes.Call, reified, null);
            g.Emit(OpCodes.Ret);
        }

        internal static FixedDelegate FixedFunc(this IntPtr src, OpIdentity id, Type functype, Type result, params Type[] args)
        {
            var method = new DynamicMethod(id, result, args, functype.Module);            
            var g = method.GetILGenerator();
            switch(args.Length)
            {
                case 1:
                    g.Emit(OpCodes.Ldarg_0);
                break;
                case 2:
                    g.Emit(OpCodes.Ldarg_0);
                    g.Emit(OpCodes.Ldarg_1);                
                break;
                case 3:
                    g.Emit(OpCodes.Ldarg_0);
                    g.Emit(OpCodes.Ldarg_1);                
                    g.Emit(OpCodes.Ldarg_2);                
                break;
                case 4:
                    g.Emit(OpCodes.Ldarg_0);
                    g.Emit(OpCodes.Ldarg_1);                
                    g.Emit(OpCodes.Ldarg_2);                
                    g.Emit(OpCodes.Ldarg_3);                
                break;                

            }
            g.Emit(OpCodes.Ldc_I8, (long)src);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, result, args);
            g.Emit(OpCodes.Ret);
            return FixedDelegate.Define(id, src, method, method.CreateDelegate(functype));
        }          
    }
}
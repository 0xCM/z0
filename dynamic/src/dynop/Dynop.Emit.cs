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

    partial class Dynop
    {
        [MethodImpl(Inline)]
        public static FixedBinaryOp<F> EmitFixedBinaryOp<F>(this IBufferToken buffer, in AsmCode src)
            where F : unmanaged, IFixed
                => (FixedBinaryOp<F>)buffer.Load(src).AsFixedBinaryOp(src.Id, typeof(FixedBinaryOp<F>), typeof(F));

        /// <summary>
        /// Creates a binary operator over a primal type to execute specified asm code
        /// </summary>
        /// <param name="id">Identity conferred upon the manufactured operator</param>
        /// <param name="buffer">A pointer to executable memory loaded with selected code</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryOp<T> EmitBinaryOp<T>(this IBufferToken buffer, OpIdentity id)
            where T : unmanaged
                => (BinaryOp<T>)buffer.AsFixedBinaryOp(id,typeof(BinaryOp<T>), typeof(T));

        [MethodImpl(Inline)]
        public static BinaryOp<T> EmitBinaryOp<T>(this IBufferToken buffer, in AsmCode src)
            where T : unmanaged
                => buffer.Load(src).EmitBinaryOp<T>(src.Id);

        /// <summary>
        /// Creates a binary operator delegate from a conforming method that is optionally invoked via the Calli opcode
        /// </summary>
        /// <param name="src">The methodd that defines a binary operator</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static Func<T,T,T> EmitBinaryOp<T>(this MethodInfo src, bool calli)
        {
            if(calli)
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
            else
            {
                var operand = typeof(T);
                var args = new Type[]{operand, operand};
                var returnType = operand;
                var method = new DynamicMethod($"{src.Name}", returnType, args, operand.Module);            
                var g = method.GetILGenerator();
                g.Emit(OpCodes.Ldarg_0);
                g.Emit(OpCodes.Ldarg_1);
                g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, args);
                g.Emit(OpCodes.Ret);
                return (Func<T,T,T>)method.CreateDelegate(typeof(Func<T,T,T>));
            }
        }

        internal static DynamicDelegate<D> CreateDynamicDelegate<D>(this DynamicMethod dst, OpIdentity id,  MethodInfo src)
            where D : Delegate
                => new DynamicDelegate<D>(id, src,dst, (D)dst.CreateDelegate(typeof(D)));

        internal static DynamicDelegate CreateDynamicDelegate(this DynamicMethod dst, OpIdentity id, MethodInfo src, Type @delegate)
            => new DynamicDelegate(id, src, dst, dst.CreateDelegate(@delegate));


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

        internal static void EmitImmUnaryCall(this ILGenerator g, MethodInfo reified, byte imm8)        
        {
            g.Emit(OpCodes.Ldarg_0);
            g.EmitImmLoad(imm8);
            g.EmitCall(OpCodes.Call, reified, null);
            g.Emit(OpCodes.Ret);
        }

        internal static void EmitImmBinaryCall(this ILGenerator g, MethodInfo reified, byte imm8)        
        {
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);
            g.EmitImmLoad(imm8);
            g.EmitCall(OpCodes.Call, reified, null);
            g.Emit(OpCodes.Ret);
        }

        internal static FixedDelegate EmitFixedAdapter(this IntPtr src, OpIdentity id, Type functype, Type result, params Type[] args)
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
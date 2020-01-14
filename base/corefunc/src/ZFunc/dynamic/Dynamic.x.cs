//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.IO;

    using static zfunc;

    public static class DynamicX
    {
        static DynamicMethod DynamicInit(string name, Type owner, Type @return, params Type[] args)
            => new DynamicMethod(name: name, 
                attributes: MethodAttributes.Public | MethodAttributes.Static,  
                callingConvention: CallingConventions.Standard,
                returnType: @return, 
                parameterTypes: args, 
                owner: owner,
                skipVisibility: false);       

        static D CreateDelegate<D>(this DynamicMethod m)
            where D : Delegate
                => (D)m.CreateDelegate(typeof(D));

        static DynamicDelegate<D> CreateDelegate<D>(this DynamicMethod dst, MethodInfo src)
            where D : Delegate
        {
            var dynop = (D)dst.CreateDelegate(typeof(D));
            return DynamicDelegate.Define(src,dst, dynop);
        }

        public static DynamicDelegate<UnaryOp<Vector128<T>>> UnaryOpImm8<T>(this MethodInfo src, N128 w, byte imm8)
            where T :  unmanaged
        {
            var operand = typeof(Vector128<T>);                        
            var method = new DynamicMethod(name: src.Name, 
                attributes: MethodAttributes.Public | MethodAttributes.Static,  
                callingConvention: CallingConventions.Standard,
                returnType: operand, 
                parameterTypes: new Type[]{operand}, 
                owner: src.DeclaringType,
                skipVisibility: false);       
            
            var gen = method.GetILGenerator();
            gen.Emit(OpCodes.Ldarg_0);
            gen.Emit(OpCodes.Ldc_I4_S, imm8);
            gen.EmitCall(OpCodes.Call, src, null);
            gen.Emit(OpCodes.Ret);

            var op = (UnaryOp<Vector128<T>>)method.CreateDelegate(typeof(UnaryOp<Vector128<T>>));                
            return DynamicDelegate.Define(src, method, op);
        }

        public static DynamicDelegate<UnaryOp<Vector256<T>>> UnaryOpImm8<T>(this MethodInfo src, N256 w, byte imm8)
            where T :  unmanaged
        {
            var operand = typeof(Vector256<T>);                        
            var method = new DynamicMethod(name: src.Name, 
                attributes: MethodAttributes.Public | MethodAttributes.Static,  
                callingConvention: CallingConventions.Standard,
                returnType: operand, 
                parameterTypes: new Type[]{operand}, 
                owner: src.DeclaringType,
                skipVisibility: false);       
            
            var gen = method.GetILGenerator();
            gen.Emit(OpCodes.Ldarg_0);
            gen.Emit(OpCodes.Ldc_I4_S, imm8);
            gen.EmitCall(OpCodes.Call, src, null);
            gen.Emit(OpCodes.Ret);

            var op = (UnaryOp<Vector256<T>>)method.CreateDelegate(typeof(UnaryOp<Vector256<T>>));                
            return DynamicDelegate.Define(src, method, op);
        }

        public static DynamicDelegate<BinaryOp<Vector128<T>>> BinaryOpImm8<T>(this MethodInfo src, N128 w, byte imm8)
            where T :  unmanaged
        {
            var operand = typeof(Vector128<T>);                        
            var method = DynamicInit(src.Name, src.DeclaringType, operand, operand, operand);            
            var gen = method.GetILGenerator();
            gen.Emit(OpCodes.Ldarg_0);
            gen.Emit(OpCodes.Ldarg_1);
            gen.Emit(OpCodes.Ldc_I4_S, imm8);
            gen.EmitCall(OpCodes.Call, src, null);
            gen.Emit(OpCodes.Ret);

            return method.CreateDelegate<BinaryOp<Vector128<T>>>(src);
        }

        public static DynamicDelegate<BinaryOp<Vector256<T>>> BinaryOpImm8<T>(this MethodInfo src, N256 w, byte imm8)
            where T :  unmanaged
        {
            var operand = typeof(Vector256<T>);  
            var method = DynamicInit(src.Name, src.DeclaringType, operand, operand, operand);            
            var gen = method.GetILGenerator();
            gen.Emit(OpCodes.Ldarg_0);
            gen.Emit(OpCodes.Ldarg_1);
            gen.Emit(OpCodes.Ldc_I4_S, imm8);
            gen.EmitCall(OpCodes.Call, src, null);
            gen.Emit(OpCodes.Ret);        
            return method.CreateDelegate<BinaryOp<Vector256<T>>>(src);
        }
    }
}
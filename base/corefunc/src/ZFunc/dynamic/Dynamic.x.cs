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

    public static class DynamicX
    {
        static DynamicMethod DynamicInit(string name, Type owner, Type @return, params Type[] parameters)
            => new DynamicMethod(name: name, 
                attributes: MethodAttributes.Public | MethodAttributes.Static,  
                callingConvention: CallingConventions.Standard,
                returnType: @return, 
                parameterTypes: parameters, 
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

        static ILGenerator EmitConstLoad(this ILGenerator g, byte imm)
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

        public static DynamicDelegate<UnaryOp<Vector128<T>>> UnaryOpImm8<T>(this MethodInfo src, N128 w, byte imm8)
            where T :  unmanaged
        {
            var operand = typeof(Vector128<T>); 
            var target = typeof(UnaryOp<Vector128<T>>);                       
            var method = DynamicInit(src.Name, src.DeclaringType, operand, operand);            
            var gen = method.GetILGenerator();
            gen.Emit(OpCodes.Ldarg_0);
            gen.EmitConstLoad(imm8);
            gen.EmitCall(OpCodes.Call, src, null);
            gen.Emit(OpCodes.Ret);
            var op = (UnaryOp<Vector128<T>>)method.CreateDelegate(target);                
            return DynamicDelegate.Define(src, method, op);
        }

        public static DynamicDelegate<UnaryOp<Vector256<T>>> UnaryOpImm8<T>(this MethodInfo src, N256 w, byte imm8)
            where T :  unmanaged
        {
            var optype = typeof(Vector256<T>);                        
            var target = typeof(UnaryOp<Vector256<T>>);
            // var method = new DynamicMethod(name: src.Name, 
            //     attributes: MethodAttributes.Public | MethodAttributes.Static,  
            //     callingConvention: CallingConventions.Standard,
            //     returnType: operand, 
            //     parameterTypes: new Type[]{operand}, 
            //     owner: src.DeclaringType,
            //     skipVisibility: false);       

            var method = DynamicInit(src.Name, src.DeclaringType, optype, optype);            

            var gen = method.GetILGenerator();
            gen.Emit(OpCodes.Ldarg_0);
            //gen.Emit(OpCodes.Ldc_I4_S, imm8);
            gen.EmitConstLoad(imm8);
            gen.EmitCall(OpCodes.Call, src, null);
            gen.Emit(OpCodes.Ret);

            var op = (UnaryOp<Vector256<T>>)method.CreateDelegate(target);   
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
            //gen.Emit(OpCodes.Ldc_I4_S, imm8);
            gen.EmitConstLoad(imm8);
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
            //gen.Emit(OpCodes.Ldc_I4_S, imm8);
            gen.EmitConstLoad(imm8);
            gen.EmitCall(OpCodes.Call, src, null);
            gen.Emit(OpCodes.Ret);        
            return method.CreateDelegate<BinaryOp<Vector256<T>>>(src);
        }
    }
}
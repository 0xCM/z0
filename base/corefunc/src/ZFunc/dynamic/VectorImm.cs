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

    public static class VectorImm
    {
        static void UnaryEmit(this ILGenerator g, MethodInfo reified, byte imm8)        
        {
            g.Emit(OpCodes.Ldarg_0);
            g.EmitConstLoad(imm8);
            g.EmitCall(OpCodes.Call, reified, null);
            g.Emit(OpCodes.Ret);
        }

        static void BinaryEmit(this ILGenerator g, MethodInfo reified, byte imm8)        
        {
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);
            g.EmitConstLoad(imm8);
            g.EmitCall(OpCodes.Call, reified, null);
            g.Emit(OpCodes.Ret);
        }

        static DynamicDelegate unary(Type vtypedef, MethodInfo src, byte imm8, Type celltype)
        {
            var reified = src.Reify(celltype);
            var operand = vtypedef.MakeGenericType(celltype); 
            var target = typeof(UnaryOp<>).MakeGenericType(operand);
            var method = DynamicEmit.method(reified.Name, reified.DeclaringType, operand, operand);            
            method.GetILGenerator().UnaryEmit(reified, imm8);
            return method.CreateDelegate(reified, target);
        }

        static DynamicDelegate binary(Type vtypedef, MethodInfo src, byte imm8, Type celltype)
        {
            var reified = src.Reify(celltype);
            var operand = vtypedef.MakeGenericType(celltype); 
            var target = typeof(BinaryOp<>).MakeGenericType(operand);
            var method = DynamicEmit.method(reified.Name, reified.DeclaringType, operand, operand);            
            method.GetILGenerator().BinaryEmit(reified, imm8);
            return method.CreateDelegate(reified, target);
        }

        public static DynamicDelegate unary(N128 w, MethodInfo src, byte imm8, Type celltype)
            => unary(typeof(Vector128<>), src, imm8,celltype);

        public static DynamicDelegate unary(N256 w, MethodInfo src, byte imm8, Type celltype)
            => unary(typeof(Vector256<>), src, imm8,celltype);

        public static Func<byte,DynamicDelegate> unaryfactory(FixedWidth w, MethodInfo src, Type celltype)
        {
            switch(w)
            {
                case FixedWidth.W128:
                    return unaryfactory(n128, src, celltype);
                case FixedWidth.W256:
                    return unaryfactory(n256, src, celltype);
                default:
                    throw new NotSupportedException(w.ToString());
            }
        }

        public static Func<byte,DynamicDelegate> unaryfactory(N128 w, MethodInfo src, Type celltype)
            => imm8 => unary(w,src,imm8,celltype);

        public static Func<byte,DynamicDelegate> unaryfactory(N256 w, MethodInfo src, Type celltype)
            => imm8 => unary(w,src,imm8,celltype);

        public static DynamicDelegate binary(N128 w, MethodInfo src, byte imm8, Type celltype)
            => binary(typeof(Vector128<>), src, imm8,celltype);

        public static DynamicDelegate binary(N256 w, MethodInfo src, byte imm8, Type celltype)
            => binary(typeof(Vector256<>), src, imm8,celltype);

        public static Func<byte,DynamicDelegate> binaryfactory(N128 w, MethodInfo src, Type celltype)
            => imm8 => binary(w,src,imm8,celltype);

        public static Func<byte,DynamicDelegate> binaryfactory(N256 w, MethodInfo src, Type celltype)
            => imm8 => binary(w,src,imm8,celltype);

        public static Func<byte,DynamicDelegate> binaryfactory(FixedWidth w, MethodInfo src, Type celltype)
        {
            switch(w)
            {
                case FixedWidth.W128:
                    return binaryfactory(n128, src, celltype);
                case FixedWidth.W256:
                    return binaryfactory(n256, src, celltype);
                default:
                    throw new NotSupportedException(w.ToString());
            }
        }

        public static DynamicDelegate<UnaryOp<Vector128<T>>> unary<T>(N128 w, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector128<T>); 
            var method = DynamicEmit.method(reified.Name, reified.DeclaringType, operand, operand);            
            method.GetILGenerator().UnaryEmit(reified, imm8);
            return method.CreateDelegate<UnaryOp<Vector128<T>>>(reified);
        }

        public static DynamicDelegate<UnaryOp<Vector256<T>>> unary<T>(N256 w, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var optype = typeof(Vector256<T>);                        
            var method = DynamicEmit.method(reified.Name, reified.DeclaringType, optype, optype);            
            method.GetILGenerator().UnaryEmit(reified,imm8);
            return method.CreateDelegate<UnaryOp<Vector256<T>>>(reified);
        }

        public static DynamicDelegate<BinaryOp<Vector128<T>>> binary<T>(N128 w, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector128<T>);                        
            var method = DynamicEmit.method(reified.Name, reified.DeclaringType, operand, operand, operand);            
            method.GetILGenerator().BinaryEmit(reified,imm8);
            // gen.Emit(OpCodes.Ldarg_0);
            // gen.Emit(OpCodes.Ldarg_1);
            // gen.EmitConstLoad(imm8);
            // gen.EmitCall(OpCodes.Call, reified, null);
            // gen.Emit(OpCodes.Ret);
            return method.CreateDelegate<BinaryOp<Vector128<T>>>(reified);
        }

        public static DynamicDelegate<BinaryOp<Vector256<T>>> binary<T>(N256 w, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector256<T>);  
            var method = DynamicEmit.method(reified.Name, reified.DeclaringType, operand, operand, operand);            
            var gen = method.GetILGenerator();
            method.GetILGenerator().BinaryEmit(reified,imm8);
            // gen.Emit(OpCodes.Ldarg_0);
            // gen.Emit(OpCodes.Ldarg_1);
            // gen.EmitConstLoad(imm8);
            // gen.EmitCall(OpCodes.Call, reified, null);
            // gen.Emit(OpCodes.Ret);        
            return method.CreateDelegate<BinaryOp<Vector256<T>>>(reified);
        }
    }

}
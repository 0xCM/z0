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

    public static class Dynop
    {
        public static DynamicMethod method(string name, Type owner, Type @return, params Type[] args)
            => new DynamicMethod(name: name, 
                attributes: MethodAttributes.Public | MethodAttributes.Static,  
                callingConvention: CallingConventions.Standard,
                returnType: @return, 
                parameterTypes: args, 
                owner: owner,
                skipVisibility: false);       

        /// <summary>
        /// Constructs the dynamic pointer determined by the source delegate
        /// </summary>
        /// <param name="src">The source delegate</param>
        [MethodImpl(Inline)]
        public static unsafe DynamicPointer ptr(DynamicDelegate src)
        {
            var ptr = src.DynamicMethod.NativePointer();
            return new DynamicPointer(src, (byte*)ptr.ToPointer());
        }

        /// <summary>
        /// Constructs the dynamic pointer determined by the source delegate
        /// </summary>
        /// <param name="src">The source delegate</param>
        [MethodImpl(Inline)]
        public static unsafe DynamicPointer ptr<D>(DynamicDelegate<D> src)
            where D : Delegate
        {
            var ptr = src.DynamicMethod.NativePointer();
            return new DynamicPointer(src, (byte*)ptr.ToPointer());
        }

        public static DynamicDelegate<UnaryBlockedOp128<T>> unary<T>(HK.Blocked128 k, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Block128<T>); 
            var method = Dynop.method(reified.Name, reified.DeclaringType, @return: operand, args: array(operand, operand));            
            var gen = method.GetILGenerator();
            gen.Emit(OpCodes.Ldarg_0);
            gen.EmitConstLoad(imm8);
            gen.Emit(OpCodes.Ldarg_1);
            gen.EmitCall(OpCodes.Call, reified, null);
            gen.Emit(OpCodes.Ret);
            return method.CreateDelegate<UnaryBlockedOp128<T>>(reified);
        }

        internal static DynamicDelegate unary(HK.Vec k, Type typedef, MethodInfo src, byte imm8, Type seg)
        {
            var reified = src.Reify(seg);
            var operand = typedef.MakeGenericType(seg); 
            var target = typeof(UnaryOp<>).MakeGenericType(operand);
            var method = Dynop.method(reified.Name, reified.DeclaringType, operand, operand);            
            method.GetILGenerator().UnaryEmit(reified, imm8);
            return method.CreateDelegate(reified, target);
        }

        internal static DynamicDelegate binary(HK.Vec k, Type typedef, MethodInfo src, byte imm8, Type seg)
        {
            var reified = src.Reify(seg);
            var operand = typedef.MakeGenericType(seg); 
            var target = typeof(BinaryOp<>).MakeGenericType(operand);
            var method = Dynop.method(reified.Name, reified.DeclaringType, operand, operand);            
            method.GetILGenerator().BinaryEmit(reified, imm8);
            return method.CreateDelegate(reified, target);
        }

        public static DynamicDelegate unary(HK.Vec128 k, MethodInfo src, byte imm8, Type seg)
            => unary(k, typeof(Vector128<>), src, imm8, seg);

        public static DynamicDelegate unary(HK.Vec256 k, MethodInfo src, byte imm8, Type seg)
            => unary(k, typeof(Vector256<>), src, imm8, seg);

        public static DynamicDelegate binary(HK.Vec128 k, MethodInfo src, byte imm8, Type seg)
            => binary(k, typeof(Vector128<>), src, imm8, seg);

        public static DynamicDelegate binary(HK.Vec256 k, MethodInfo src, byte imm8, Type seg)
            => binary(k, typeof(Vector256<>), src, imm8,seg);

        public static Func<byte,DynamicDelegate> unaryfactory(HK.Vec128 k, MethodInfo src, Type seg)
            => imm8 => unary(k,src,imm8,seg);

        public static Func<byte,DynamicDelegate> unaryfactory(HK.Vec256 k, MethodInfo src, Type seg)
            => imm8 => unary(k, src,imm8,seg);
        public static Func<byte,DynamicDelegate> binaryfactory(HK.Vec128 k, MethodInfo src, Type seg)
            => imm8 => binary(k,src,imm8,seg);

        public static Func<byte,DynamicDelegate> binaryfactory(HK.Vec256 k, MethodInfo src, Type seg)
            => imm8 => binary(k,src,imm8,seg);

        public static DynamicDelegate<UnaryOp<Vector128<T>>> unary<T>(HK.Vec128 k, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector128<T>); 
            var method = Dynop.method(reified.Name, reified.DeclaringType, operand, operand);            
            method.GetILGenerator().UnaryEmit(reified, imm8);
            return method.CreateDelegate<UnaryOp<Vector128<T>>>(reified);
        }

        public static DynamicDelegate<UnaryOp<Vector256<T>>> unary<T>(HK.Vec256 k, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var optype = typeof(Vector256<T>);                        
            var method = Dynop.method(reified.Name, reified.DeclaringType, optype, optype);            
            method.GetILGenerator().UnaryEmit(reified,imm8);
            return method.CreateDelegate<UnaryOp<Vector256<T>>>(reified);
        }

        public static DynamicDelegate<BinaryOp<Vector128<T>>> binary<T>(HK.Vec128 k, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector128<T>);                        
            var method = Dynop.method(reified.Name, reified.DeclaringType, operand, operand, operand);            
            method.GetILGenerator().BinaryEmit(reified,imm8);
            return method.CreateDelegate<BinaryOp<Vector128<T>>>(reified);
        }

        public static DynamicDelegate<BinaryOp<Vector256<T>>> binary<T>(HK.Vec256 k, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector256<T>);  
            var method = Dynop.method(reified.Name, reified.DeclaringType, operand, operand, operand);            
            var gen = method.GetILGenerator();
            method.GetILGenerator().BinaryEmit(reified,imm8);
            return method.CreateDelegate<BinaryOp<Vector256<T>>>(reified);
        }
    }
}
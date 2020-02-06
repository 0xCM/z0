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
    using System.Collections.Generic;
    using System.Linq;
    
    using static zfunc;    
    using static As;

    public static class DynopImm
    {
        public static Func<byte,DynamicDelegate> OpBuilder(HK.Vec128 vk, HK.UnaryOpFunc opk, MethodInfo src)
            => imm8 => UnaryOp(vk,src.Identify(),src,imm8, src.ParameterTypes().First());

        public static Func<byte,DynamicDelegate> OpBuilder(HK.Vec256 vk, HK.UnaryOpFunc opk, MethodInfo src)
            => imm8 => UnaryOp(vk,src.Identify(),src,imm8, src.ParameterTypes().First());

        public static Func<byte,DynamicDelegate> OpBuilder(HK.Vec128 vk, HK.BinaryOpFunc opk, MethodInfo src)
            => imm8 => BinaryOp(vk,src.Identify(),src,imm8, src.ParameterTypes().First());

        public static Func<byte,DynamicDelegate> OpBuilder(HK.Vec256 vk, HK.BinaryOpFunc opk, MethodInfo src)
            => imm8 => BinaryOp(vk,src.Identify(),src,imm8, src.ParameterTypes().First());

        public static Func<byte,DynamicDelegate> UnaryOpProvider(HK.Vec128 k, OpIdentity id, MethodInfo src, Type component)
            => imm8 => UnaryOp(k,id,src,imm8,component);

        public static Func<byte,DynamicDelegate> UnaryOpProvider(HK.Vec256 k, OpIdentity id, MethodInfo src, Type component)
            => imm8 => UnaryOp(k, id, src,imm8,component);

        public static Func<byte,DynamicDelegate> BinaryOpProvider(HK.Vec128 k, OpIdentity id, MethodInfo src, Type component)
            => imm8 => BinaryOp(k,id,src,imm8,component);

        public static Func<byte,DynamicDelegate> BinaryOpProvider(HK.Vec256 k, OpIdentity id, MethodInfo src, Type component)
            => imm8 => BinaryOp(k, id, src,imm8,component);

        /// <summary>
        /// Creates a vectorized unary operator with an immediate capture
        /// </summary>
        /// <param name="k">The kind selector</param>
        /// <param name="method">The method that defines a unary operator that accepts an immediate value in the second operand</param>
        /// <param name="baseid">The identity upon which the dynamic immediate will be predicated</param>
        /// <param name="imm">The immediate value to capture</param>
        public static DynamicDelegate UnaryOp(HK.Vec k, MethodInfo method, OpIdentity baseid, byte imm)
            => UnaryOpFactory(k,method,baseid)(imm);

        /// <summary>
        /// Creates a vectorized binary operator with an immediate capture
        /// </summary>
        /// <param name="k">The kind selector</param>
        /// <param name="method">The method that defines a unary operator that accepts an immediate value in the third operand</param>
        /// <param name="baseid">The identity upon which the dynamic immediate will be predicated</param>
        /// <param name="imm">The immediate value to capture</param>
        public static DynamicDelegate BinaryOp(HK.Vec k, MethodInfo method, OpIdentity baseid, byte imm)
            => BinaryOpFactory(k,method,baseid)(imm);

        public static Func<byte,DynamicDelegate<UnaryOp<Vector128<T>>>> UnaryOpProvider<T>(HK.Vec128<T> k, OpIdentity id, MethodInfo src)
            where T : unmanaged
            => imm8 => UnaryOp(k,id, src,imm8);

        public static Func<byte,DynamicDelegate<UnaryOp<Vector256<T>>>> UnaryOpProvider<T>(HK.Vec256<T> k, OpIdentity id, MethodInfo src)
            where T : unmanaged
                => imm8 => UnaryOp(k, id, src,imm8);

        public static Func<byte,DynamicDelegate<BinaryOp<Vector128<T>>>> BinaryOpProvider<T>(HK.Vec128<T> k, OpIdentity id, MethodInfo src)
            where T : unmanaged
            => imm8 => BinaryOp(k,id, src,imm8);

        public static Func<byte,DynamicDelegate<BinaryOp<Vector256<T>>>> BinaryOpProvider<T>(HK.Vec256<T> k, OpIdentity id, MethodInfo src)
            where T : unmanaged
                => imm8 => BinaryOp(k, id, src,imm8);

        public static DynamicDelegate<UnaryBlockedOp128<T>> UnaryOp<T>(HK.Blocked128 k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Block128<T>); 
            var method = DynopImm.method(reified.Name, reified.DeclaringType, @return: operand, args: array(operand, operand));            
            var gen = method.GetILGenerator();
            gen.Emit(OpCodes.Ldarg_0);
            gen.EmitImmLoad(imm8);
            gen.Emit(OpCodes.Ldarg_1);
            gen.EmitCall(OpCodes.Call, reified, null);
            gen.Emit(OpCodes.Ret);
            return method.CreateDelegate<UnaryBlockedOp128<T>>(id.WithImm8(imm8), reified);
        }

        public static DynamicDelegate<UnaryOp<Vector128<T>>> UnaryOp<T>(HK.Vec128<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector128<T>); 
            var wrapper = method(reified.Name, reified.DeclaringType, operand, operand);            
            wrapper.GetILGenerator().EmitUnaryImmCall(reified, imm8);
            return wrapper.CreateDelegate<UnaryOp<Vector128<T>>>(id.WithImm8(imm8), reified);
        }

        public static DynamicDelegate<UnaryOp<Vector256<T>>> UnaryOp<T>(HK.Vec256<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector256<T>);                        
            var wrapper = method(reified.Name, reified.DeclaringType, operand, operand);            
            wrapper.GetILGenerator().EmitUnaryImmCall(reified,imm8);
            return wrapper.CreateDelegate<UnaryOp<Vector256<T>>>(id.WithImm8(imm8), reified);
        }

        public static DynamicDelegate<BinaryOp<Vector128<T>>> BinaryOp<T>(HK.Vec128<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector128<T>);                        
            var wrapper = method(reified.Name, reified.DeclaringType, operand, operand, operand);            
            wrapper.GetILGenerator().EmitBinaryImmCall(reified,imm8);
            return wrapper.CreateDelegate<BinaryOp<Vector128<T>>>(id.WithImm8(imm8), reified);
        }

        public static DynamicDelegate<BinaryOp<Vector256<T>>> BinaryOp<T>(HK.Vec256<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector256<T>);  
            var wrapper = method(reified.Name, reified.DeclaringType, operand, operand, operand);            
            var gen = wrapper.GetILGenerator();
            wrapper.GetILGenerator().EmitBinaryImmCall(reified,imm8);
            return wrapper.CreateDelegate<BinaryOp<Vector256<T>>>(id.WithImm8(imm8),reified);
        }

        static DynamicDelegate unaryimm(HK.Vec k, Type typedef, OpIdentity id, MethodInfo inner, byte imm8, Type component)
        {
            var reified = inner.Reify(component);
            var operand = typedef.MakeGenericType(component); 
            var target = typeof(UnaryOp<>).MakeGenericType(operand);
            var wrapper = method(reified.Name, reified.DeclaringType, operand, operand);            
            wrapper.GetILGenerator().EmitUnaryImmCall(reified, imm8);
            return wrapper.CreateDelegate(id.WithImm8(imm8), reified, target);
        }

        static DynamicDelegate UnaryOp(HK.Vec128 k, OpIdentity id, MethodInfo src, byte imm8, Type seg)
            => unaryimm(k, typeof(Vector128<>), id, src, imm8, seg);

        static DynamicDelegate UnaryOp(HK.Vec256 k, OpIdentity id, MethodInfo src, byte imm8, Type seg)
            => unaryimm(k, typeof(Vector256<>), id, src, imm8, seg);

        static DynamicDelegate BinaryOp(HK.Vec128 k, OpIdentity id, MethodInfo src, byte imm8, Type component)
        {
            var reified = src.Reify(component);
            var operand = typeof(Vector128<>).MakeGenericType(component);  
            var target = typeof(BinaryOp<>).MakeGenericType(operand);
            var wrapper = method(reified.Name, reified.DeclaringType, operand, operand, operand);            
            var gen = wrapper.GetILGenerator();
            wrapper.GetILGenerator().EmitBinaryImmCall(reified,imm8);
            return wrapper.CreateDelegate(id.WithImm8(imm8),reified, target);
        }

        static DynamicDelegate BinaryOp(HK.Vec256 k, OpIdentity id, MethodInfo src, byte imm8, Type component)
        {
            var reified = src.Reify(component);
            var operand = typeof(Vector256<>).MakeGenericType(component);  
            var target = typeof(BinaryOp<>).MakeGenericType(operand);
            var wrapper = method(reified.Name, reified.DeclaringType, operand, operand, operand);            
            var gen = wrapper.GetILGenerator();
            wrapper.GetILGenerator().EmitBinaryImmCall(reified,imm8);
            return wrapper.CreateDelegate(id.WithImm8(imm8),reified, target);
        }

        static Func<byte,DynamicDelegate> UnaryOpFactory(HK.Vec k, MethodInfo method, OpIdentity baseid)
        {
            (var celltype, var width) = method.ParameterTypes()
                    .Where(p => p.IsVector())
                    .Select(x => (x.SuppliedTypeArgs().Single(),x.Width()))
                    .FirstOrDefault();            

            var factory = width switch{
                FixedWidth.W128 => DynopImm.UnaryOpProvider(HK.vk128(), baseid, method, celltype),
                FixedWidth.W256 => DynopImm.UnaryOpProvider(HK.vk256(), baseid, method, celltype),
                _ => throw new NotSupportedException(width.ToString())
            };
            return factory;
        }

        static Func<byte,DynamicDelegate> BinaryOpFactory(HK.Vec k, MethodInfo method, OpIdentity baseid)
        {
            (var celltype, var width) = method.ParameterTypes()
                    .Where(p => p.IsVector())
                    .Select(x => (x.SuppliedTypeArgs().Single(),x.Width()))
                    .FirstOrDefault();            

            var factory = width switch{
                FixedWidth.W128 => BinaryOpProvider(HK.vk128(), baseid, method, celltype),
                FixedWidth.W256 => BinaryOpProvider(HK.vk256(), baseid, method, celltype),
                _ => throw new NotSupportedException(width.ToString())
            };
            return factory;
        }

        static DynamicMethod method(string name, Type owner, Type @return, params Type[] args)
            => new DynamicMethod(name: name, 
                attributes: MethodAttributes.Public | MethodAttributes.Static,  
                callingConvention: CallingConventions.Standard,
                returnType: @return, 
                parameterTypes: args, 
                owner: owner,
                skipVisibility: false);       
    }
}
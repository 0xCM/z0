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
    using System.Linq;

    using static Root;
    using static Nats;
    using static FKT;

    partial class Dynop
    {
        public static DynamicDelegate<BinaryOp<Vector128<T>>> ImmVBinaryOp<T>(VKT.Vec128<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector128<T>);                        
            var wrapper = DynamicSignature(reified.Name, reified.DeclaringType, operand, operand, operand);            
            wrapper.GetILGenerator().EmitImmBinaryCall(reified,imm8);
            return wrapper.CreateDynamicDelegate<BinaryOp<Vector128<T>>>(id.WithImm8(imm8), reified);
        }

        public static DynamicDelegate<BinaryOp<Vector256<T>>> ImmVBinaryOp<T>(VKT.Vec256<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector256<T>);  
            var wrapper = DynamicSignature(reified.Name, reified.DeclaringType, operand, operand, operand);            
            var gen = wrapper.GetILGenerator();
            wrapper.GetILGenerator().EmitImmBinaryCall(reified,imm8);
            return wrapper.CreateDynamicDelegate<BinaryOp<Vector256<T>>>(id.WithImm8(imm8),reified);
        }

        /// <summary>
        /// Creates a parametric 128-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]            
        public static DynamicDelegate<BinaryOp<Vector128<T>>> ImmV128BinaryOp<T>(MethodInfo src, byte imm)
            where T : unmanaged
                => ImmV128BinaryFactory(VK.vk128<T>(), Identity.identify(src), src)(imm);

        /// <summary>
        /// Creates a parametric 256-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]            
        public static DynamicDelegate<BinaryOp<Vector256<T>>> ImmV256BinaryOp<T>(MethodInfo src, byte imm)
            where T : unmanaged
                => ImmV256BinaryFactory(VK.vk256<T>(), Identity.identify(src), src)(imm);

        /// <summary>
        /// Creates a vectorized binary operator with an immediate capture
        /// </summary>
        /// <param name="k">The kind selector</param>
        /// <param name="method">The method that defines a unary operator that accepts an immediate value in the third operand</param>
        /// <param name="baseid">The identity upon which the dynamic immediate will be predicated</param>
        /// <param name="imm">The immediate value to capture</param>
        public static DynamicDelegate ImmVBinaryDelegate(VKT.Vec k, MethodInfo method, OpIdentity baseid, byte imm)
            => ImmVBinaryFactory(k,method,baseid)(imm);

        /// <summary>
        /// Creates a non-parametric 128-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]            
        public static DynamicDelegate ImmV128BinaryDelegate(MethodInfo src, byte imm)
            => ImmV128BinaryFactory(VK.vk128(), FK.op(n2), src)(imm);

        /// <summary>
        /// Creates a non-parametric 256-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]            
        public static DynamicDelegate ImmV256BinaryDelegate(MethodInfo src, byte imm)
            => ImmV256BinaryFactory(VK.vk256(), FK.op(n2), src)(imm);

        internal static Func<byte,DynamicDelegate> ImmV128BinaryFactory(VKT.Vec128 vk, BinaryOpType opk, MethodInfo src)
            => imm8 => ImmVBinaryDelegate(vk,Identity.identify(src),src,imm8, src.ParameterTypes().First());

        internal static Func<byte,DynamicDelegate> ImmV256BinaryFactory(VKT.Vec256 vk, BinaryOpType opk, MethodInfo src)
            => imm8 => ImmVBinaryDelegate(vk,Identity.identify(src),src,imm8, src.ParameterTypes().First());

        internal static Func<byte,DynamicDelegate> ImmV128BinaryFactory(VKT.Vec128 k, OpIdentity id, MethodInfo src, Type component)
            => imm8 => ImmVBinaryDelegate(k,id,src,imm8,component);

        internal static Func<byte,DynamicDelegate> ImmV256BinaryFactory(VKT.Vec256 k, OpIdentity id, MethodInfo src, Type component)
            => imm8 => ImmVBinaryDelegate(k, id, src,imm8,component);

        internal static DynamicDelegate ImmVBinaryDelegate(VKT.Vec128 k, OpIdentity id, MethodInfo src, byte imm8, Type component)
        {
            var reified = src.Reify(component);
            var operand = typeof(Vector128<>).MakeGenericType(component);  
            var target = typeof(BinaryOp<>).MakeGenericType(operand);
            var wrapper = DynamicSignature(reified.Name, reified.DeclaringType, operand, operand, operand);            
            var gen = wrapper.GetILGenerator();
            wrapper.GetILGenerator().EmitImmBinaryCall(reified,imm8);
            return wrapper.CreateDynamicDelegate(id.WithImm8(imm8),reified, target);
        }

        internal static DynamicDelegate ImmVBinaryDelegate(VKT.Vec256 k, OpIdentity id, MethodInfo src, byte imm8, Type component)
        {
            var reified = src.Reify(component);
            var operand = typeof(Vector256<>).MakeGenericType(component);  
            var target = typeof(BinaryOp<>).MakeGenericType(operand);
            var wrapper = DynamicSignature(reified.Name, reified.DeclaringType, operand, operand, operand);            
            var gen = wrapper.GetILGenerator();
            wrapper.GetILGenerator().EmitImmBinaryCall(reified,imm8);
            return wrapper.CreateDynamicDelegate(id.WithImm8(imm8),reified, target);
        }

        internal static Func<byte,DynamicDelegate> ImmVBinaryFactory(VKT.Vec k, MethodInfo method, OpIdentity baseid)
        {
            (var celltype, var width) = method.ParameterTypes()
                    .Where(p => p.IsVector())
                    .Select(x => (x.SuppliedTypeArgs().Single(),x.Width()))
                    .FirstOrDefault();            

            var factory = width switch{
                FixedWidth.W128 => ImmV128BinaryFactory(VK.vk128(), baseid, method, celltype),
                FixedWidth.W256 => ImmV256BinaryFactory(VK.vk256(), baseid, method, celltype),
                _ => throw new NotSupportedException(width.ToString())
            };
            return factory;
        }

        internal static Func<byte,DynamicDelegate<BinaryOp<Vector128<T>>>> ImmV128BinaryFactory<T>(VKT.Vec128<T> k, OpIdentity id, MethodInfo src)
            where T : unmanaged
            => imm8 => Dynop.ImmVBinaryOp(k,id, src,imm8);

        internal static Func<byte,DynamicDelegate<BinaryOp<Vector256<T>>>> ImmV256BinaryFactory<T>(VKT.Vec256<T> k, OpIdentity id, MethodInfo src)
            where T : unmanaged
                => imm8 => ImmVBinaryOp(k, id, src,imm8);
    }
}

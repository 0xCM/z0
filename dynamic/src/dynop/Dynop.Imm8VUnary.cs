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
        public static DynamicDelegate<UnaryOp<Vector128<T>>> ImmVUnaryOP<T>(VKT.Vec128<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector128<T>); 
            var dst = DynamicSignature(reified.Name, reified.DeclaringType, operand, operand);            
            dst.GetILGenerator().EmitImmUnaryCall(reified, imm8);
            return dst.CreateDynamicDelegate<UnaryOp<Vector128<T>>>(id.WithImm8(imm8), reified);
        }

        public static DynamicDelegate<UnaryOp<Vector256<T>>> ImmVUnaryOp<T>(VKT.Vec256<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector256<T>);                        
            var dst = DynamicSignature(reified.Name, reified.DeclaringType, operand, operand);            
            dst.GetILGenerator().EmitImmUnaryCall(reified,imm8);
            return dst.CreateDynamicDelegate<UnaryOp<Vector256<T>>>(id.WithImm8(imm8), reified);
        }

        /// <summary>
        /// Creates a 128-bit vectorized parametric unary operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]            
        public static DynamicDelegate<UnaryOp<Vector128<T>>> ImmV128UnaryOp<T>(MethodInfo src, byte imm)
            where T : unmanaged
                => ImmV128UnaryFactory(VK.vk128<T>(), Identity.identify(src), src)(imm);

        /// <summary>
        /// Creates a parametric 128-bit vectorized unary operator that adapts a like-kinded operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]            
        public static DynamicDelegate<UnaryOp<Vector256<T>>> ImmV256UnaryOp<T>(MethodInfo src, byte imm)
            where T : unmanaged
                => ImmV256UnaryFactory(VK.vk256<T>(), Identity.identify(src), src)(imm);

        /// <summary>
        /// Creates a parametric 256-bit vectorized unary operator that adapts a like-kinded operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="k">The kind selector</param>
        /// <param name="method">The method that defines a unary operator that accepts an immediate value in the second operand</param>
        /// <param name="baseid">The identity upon which the dynamic immediate will be predicated</param>
        /// <param name="imm">The immediate value to capture</param>
        public static DynamicDelegate ImmVUnaryDelegate(VKT.Vec k, MethodInfo method, OpIdentity baseid, byte imm)
            => ImmVUnaryFactory(k,method,baseid)(imm);

        /// <summary>
        /// Creates a non-parametric 128-bit vectorized unary operator that adapts a like-kinded operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]            
        public static DynamicDelegate ImmV128UnaryDelegate(MethodInfo src, byte imm)
            => ImmVUnaryFactory(VK.vk128(), FK.op(n1), src)(imm);

        /// <summary>
        /// Creates a non-parametric 256-bit vectorized unary operator that adapts a like-kinded operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]            
        public static DynamicDelegate ImmV256UnaryDelegate(MethodInfo src, byte imm)
            => ImmVUnaryFactory(VK.vk256(), FK.op(n1), src)(imm);

        internal static DynamicDelegate ImmVUnaryDelegate(VKT.Vec128 k, OpIdentity id, MethodInfo src, byte imm8, Type seg)
            => ImmVUnaryDelegate(k, typeof(Vector128<>), id, src, imm8, seg);

        internal static DynamicDelegate ImmVUnaryDelegate(VKT.Vec256 k, OpIdentity id, MethodInfo src, byte imm8, Type seg)
            => ImmVUnaryDelegate(k, typeof(Vector256<>), id, src, imm8, seg);

        internal static DynamicDelegate ImmVUnaryDelegate(VKT.Vec k, Type typedef, OpIdentity id, MethodInfo inner, byte imm8, Type component)
        {
            var reified = inner.Reify(component);
            var operand = typedef.MakeGenericType(component); 
            var target = typeof(UnaryOp<>).MakeGenericType(operand);
            var dst = DynamicSignature(reified.Name, reified.DeclaringType, operand, operand);            
            dst.GetILGenerator().EmitImmUnaryCall(reified, imm8);
            return dst.CreateDynamicDelegate(id.WithImm8(imm8), reified, target);
        }

        internal static Func<byte,DynamicDelegate> ImmVUnaryFactory(VKT.Vec k, MethodInfo method, OpIdentity baseid)
        {
            (var celltype, var width) = method.ParameterTypes()
                    .Where(p => p.IsVector())
                    .Select(x => (x.SuppliedTypeArgs().Single(),x.Width()))
                    .FirstOrDefault();            

            var factory = width switch{
                FixedWidth.W128 => ImmV128UnaryFactory(VK.vk128(), baseid, method, celltype),
                FixedWidth.W256 => ImmV256UnaryFactory(VK.vk256(), baseid, method, celltype),
                _ => throw new NotSupportedException(width.ToString())
            };
            return factory;
        }

        internal static Func<byte,DynamicDelegate<UnaryOp<Vector128<T>>>> ImmV128UnaryFactory<T>(VKT.Vec128<T> k, OpIdentity id, MethodInfo src)
            where T : unmanaged
            => imm8 => Dynop.ImmVUnaryOP(k,id, src,imm8);

        internal static Func<byte,DynamicDelegate<UnaryOp<Vector256<T>>>> ImmV256UnaryFactory<T>(VKT.Vec256<T> k, OpIdentity id, MethodInfo src)
            where T : unmanaged
                => imm8 => Dynop.ImmVUnaryOp(k, id, src,imm8);

        internal static Func<byte,DynamicDelegate> ImmVUnaryFactory(VKT.Vec128 vk, UnaryOpType opk, MethodInfo src)
            => imm8 => ImmVUnaryDelegate(vk, Identity.identify(src), src,imm8, src.ParameterTypes().First());

        internal static Func<byte,DynamicDelegate> ImmVUnaryFactory(VKT.Vec256 vk, UnaryOpType opk, MethodInfo src)
            => imm8 => ImmVUnaryDelegate(vk,Identity.identify(src), src,imm8, src.ParameterTypes().First());

        internal static Func<byte,DynamicDelegate> ImmV128UnaryFactory(VKT.Vec128 k, OpIdentity id, MethodInfo src, Type component)
            => imm8 => ImmVUnaryDelegate(k,id,src,imm8,component);

        internal static Func<byte,DynamicDelegate> ImmV256UnaryFactory(VKT.Vec256 k, OpIdentity id, MethodInfo src, Type component)
            => imm8 => ImmVUnaryDelegate(k, id, src,imm8,component);
    }
}
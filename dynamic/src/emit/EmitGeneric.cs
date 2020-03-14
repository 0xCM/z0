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
        public static UnaryOp<T> EmitUnaryOp<T>(this IBufferToken buffer, in ApiCode src)
            where T : unmanaged
                => buffer.Load(src.Data).EmitUnaryOp<T>(src.Id);

        public static BinaryOp<T> EmitBinaryOp<T>(this IBufferToken buffer, in ApiCode src)
            where T : unmanaged
                => buffer.Load(src.Data).EmitBinaryOp<T>(src.Id);

        public static TernaryOp<T> EmitTernaryOp<T>(this IBufferToken buffer, in ApiCode src)
            where T : unmanaged
                => buffer.Load(src.Data).EmitTernaryOp<T>(src.Id);

        public static FixedUnaryOp<F> EmitFixedUnaryOp<F>(this in BufferSeq<F> buffers, int index, AsmCode src)
            where F : unmanaged, IFixed
                => buffers[index].EmitFixedUnaryOp<F>(src);

        public static FixedBinaryOp<F> EmitFixedBinaryOp<F>(this in BufferSeq<F> buffers, int index, AsmCode src)
            where F : unmanaged, IFixed
                => buffers[index].EmitFixedBinaryOp<F>(src);

        public static FixedTernaryOp<F> EmitFixedTernaryOp<F>(this in BufferSeq<F> buffers, int index, in ApiCode src)
            where F : unmanaged, IFixed
                => buffers[index].EmitFixedTernaryOp<F>(src);

        public static DynamicDelegate<BinaryOp<Vector128<T>>> EmitImmVBinaryOp<T>(VKT.Vec128<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector128<T>);                        
            var wrapper = DynamicSignature(reified.Name, reified.DeclaringType, operand, operand, operand);            
            wrapper.GetILGenerator().EmitImmBinaryCall(reified,imm8);
            return DynamicDelegate.Create<BinaryOp<Vector128<T>>>(wrapper, id.WithImm8(imm8), reified);
        }

        public static DynamicDelegate<BinaryOp<Vector256<T>>> EmitImmVBinaryOp<T>(VKT.Vec256<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector256<T>);  
            var wrapper = DynamicSignature(reified.Name, reified.DeclaringType, operand, operand, operand);            
            var gen = wrapper.GetILGenerator();
            wrapper.GetILGenerator().EmitImmBinaryCall(reified,imm8);
            return DynamicDelegate.Create<BinaryOp<Vector256<T>>>(wrapper, id.WithImm8(imm8), reified);
        }

        /// <summary>
        /// Creates a parametric 128-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static DynamicDelegate<BinaryOp<Vector128<T>>> EmitImmV128BinaryOp<T>(MethodInfo src, byte imm)
            where T : unmanaged
                => EmitImmV128BinaryOpProducer<T>(Identity.identify(src), src)(imm);

        public static DynamicDelegate<UnaryBlockedOp128<T>> EmitImmBlockedUnaryOp<T>(N128 w, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Block128<T>); 
            var dst = DynamicSignature(reified.Name, reified.DeclaringType, @return: operand, args: array(operand, operand));            
            var gen = dst.GetILGenerator();
            gen.Emit(OpCodes.Ldarg_0);
            gen.EmitImmLoad(imm8);
            gen.Emit(OpCodes.Ldarg_1);
            gen.EmitCall(OpCodes.Call, reified, null);
            gen.Emit(OpCodes.Ret);
            return DynamicDelegate.Create<UnaryBlockedOp128<T>>(dst, id.WithImm8(imm8), reified);
        }

        public static DynamicDelegate<UnaryOp<Vector128<T>>> EmitImmVUnaryOp<T>(VKT.Vec128<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector128<T>); 
            var dst = DynamicSignature(reified.Name, reified.DeclaringType, operand, operand);            
            dst.GetILGenerator().EmitImmUnaryCall(reified, imm8);
            return DynamicDelegate.Create<UnaryOp<Vector128<T>>>(dst, id.WithImm8(imm8), reified);
        }

        public static DynamicDelegate<UnaryOp<Vector256<T>>> EmitImmVUnaryOp<T>(VKT.Vec256<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector256<T>);                        
            var dst = DynamicSignature(reified.Name, reified.DeclaringType, operand, operand);            
            dst.GetILGenerator().EmitImmUnaryCall(reified,imm8);
            return DynamicDelegate.Create<UnaryOp<Vector256<T>>>(dst, id.WithImm8(imm8), reified);
        }

        /// <summary>
        /// Creates a 128-bit vectorized parametric unary operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]            
        public static DynamicDelegate<UnaryOp<Vector128<T>>> EmitImmV128UnaryOp<T>(MethodInfo src, byte imm)
            where T : unmanaged
                => EmitImmV128UnaryOpProducer<T>(Identity.identify(src), src)(imm);

        /// <summary>
        /// Creates a parametric 128-bit vectorized unary operator that adapts a like-kinded operator that consumes an immediate value in the second argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]            
        public static DynamicDelegate<UnaryOp<Vector256<T>>> EmitImmV256UnaryOp<T>(MethodInfo src, byte imm)
            where T : unmanaged
                => EmitImmV256UnaryOpProducer<T>(Identity.identify(src), src)(imm);

        /// <summary>
        /// Creates a parametric 256-bit vectorized binary operator that adapts a like-kinded operator that consumes an immediate value in the third argument
        /// </summary>
        /// <param name="src">The defining method</param>
        /// <param name="imm">The immediate value to embed</param>
        /// <typeparam name="T">The operand type</typeparam>
        public static DynamicDelegate<BinaryOp<Vector256<T>>> EmitImmV256BinaryOp<T>(MethodInfo src, byte imm)
            where T : unmanaged
                => EmitImmV256BinaryOpProducer<T>(Identity.identify(src), src)(imm);

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary operator over the buffer
        /// </summary>
        /// <param name="buffer">The target buffer</param>
        /// <param name="src">The executable source</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        [MethodImpl(Inline)]
        public static FixedUnaryOp<F> EmitFixedUnaryOp<F>(this IBufferToken dst, in AsmCode src)
            where F : unmanaged, IFixed
               => (FixedUnaryOp<F>)dst.Handle.EmitFixed(src.Id,  typeof(FixedUnaryOp<F>), typeof(F), typeof(F));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary operator over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        [MethodImpl(Inline)]
        public static FixedBinaryOp<F> EmitFixedBinaryOp<F>(this IBufferToken dst, in AsmCode src)
            where F : unmanaged, IFixed
                => (FixedBinaryOp<F>)dst.Handle.EmitFixed(src.Id, typeof(FixedBinaryOp<F>), typeof(F), typeof(F), typeof(F));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary operator over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        /// <typeparam name="F">The fixed operand type</typeparam>
        [MethodImpl(Inline)]
        public static FixedTernaryOp<F> EmitFixedTernaryOp<F>(this IBufferToken dst, in ApiCode src)
            where F : unmanaged, IFixed
                => (FixedTernaryOp<F>)dst.Handle.EmitFixed(src.Id,  typeof(FixedTernaryOp<F>), typeof(F), typeof(F), typeof(F), typeof(F));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed unary function over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        [MethodImpl(Inline)]
        public static FixedFunc<X0,R> EmitFixedFunc<X0,R>(this IBufferToken dst, in ApiCode src)
            where X0 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => (FixedFunc<X0,R>)dst.Handle.EmitFixed(src.Id, typeof(FixedFunc<X0,R>), typeof(R), typeof(X0));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed binary function over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        [MethodImpl(Inline)]
        public static FixedFunc<X0,X1,R> EmitFixedFunc<X0,X1,R>(this IBufferToken dst, in ApiCode src)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => (FixedFunc<X0,X1,R>)dst.Handle.EmitFixed(src.Id, typeof(FixedFunc<X0,X1,R>), typeof(R), typeof(X0), typeof(X1));

        /// <summary>
        /// Loads executable source into an identified buffer and creates a fixed binary function over the buffer
        /// </summary>
        /// <param name="dst">The target buffer</param>
        /// <param name="src">The executable source</param>
        [MethodImpl(Inline)]
        public static FixedFunc<X0,X1,X2,R> EmitFixedFunc<X0,X1,X2,R>(this IBufferToken dst, in ApiCode src)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where X2 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => (FixedFunc<X0,X1,X2,R>)dst.Handle.EmitFixed(src.Id, typeof(FixedFunc<X0,X1,X2,R>), typeof(R), typeof(X0), typeof(X1), typeof(X2));        

        static Func<byte,DynamicDelegate<UnaryOp<Vector128<T>>>> EmitImmV128UnaryOpProducer<T>(OpIdentity id, MethodInfo src)
            where T : unmanaged
                => imm8 => EmitImmVUnaryOp(VK.vk128<T>(),id, src,imm8);

        static Func<byte,DynamicDelegate<UnaryOp<Vector256<T>>>> EmitImmV256UnaryOpProducer<T>(OpIdentity id, MethodInfo src)
            where T : unmanaged
                => imm8 => EmitImmVUnaryOp(VK.vk256<T>(), id, src,imm8);

        static Func<byte,DynamicDelegate<BinaryOp<Vector128<T>>>> EmitImmV128BinaryOpProducer<T>(OpIdentity id, MethodInfo src)
            where T : unmanaged
                => imm8 => EmitImmVBinaryOp(VK.vk128<T>(), id, src,imm8);

        static Func<byte,DynamicDelegate<BinaryOp<Vector256<T>>>> EmitImmV256BinaryOpProducer<T>(OpIdentity id, MethodInfo src)
            where T : unmanaged
                => imm8 => EmitImmVBinaryOp(VK.vk256<T>(), id, src,imm8);

    }
}
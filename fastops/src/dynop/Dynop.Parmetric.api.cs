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

    using static zfunc;

    public static partial class Dynop
    {
        public static DynamicDelegate<UnaryOp<Vector128<T>>> UnaryOpImm<T>(VKT.Vec128<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector128<T>); 
            var wrapper = method(reified.Name, reified.DeclaringType, operand, operand);            
            wrapper.GetILGenerator().EmitUnaryImmCall(reified, imm8);
            return wrapper.CreateDelegate<UnaryOp<Vector128<T>>>(id.WithImm8(imm8), reified);
        }

        public static DynamicDelegate<UnaryOp<Vector256<T>>> UnaryOpImm<T>(VKT.Vec256<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector256<T>);                        
            var wrapper = method(reified.Name, reified.DeclaringType, operand, operand);            
            wrapper.GetILGenerator().EmitUnaryImmCall(reified,imm8);
            return wrapper.CreateDelegate<UnaryOp<Vector256<T>>>(id.WithImm8(imm8), reified);
        }

        public static DynamicDelegate<BinaryOp<Vector128<T>>> BinaryOpImm<T>(VKT.Vec128<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector128<T>);                        
            var wrapper = method(reified.Name, reified.DeclaringType, operand, operand, operand);            
            wrapper.GetILGenerator().EmitBinaryImmCall(reified,imm8);
            return wrapper.CreateDelegate<BinaryOp<Vector128<T>>>(id.WithImm8(imm8), reified);
        }

        public static DynamicDelegate<BinaryOp<Vector256<T>>> BinaryOpImm<T>(VKT.Vec256<T> k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Vector256<T>);  
            var wrapper = method(reified.Name, reified.DeclaringType, operand, operand, operand);            
            var gen = wrapper.GetILGenerator();
            wrapper.GetILGenerator().EmitBinaryImmCall(reified,imm8);
            return wrapper.CreateDelegate<BinaryOp<Vector256<T>>>(id.WithImm8(imm8),reified);
        }

        public static DynamicDelegate<UnaryBlockedOp128<T>> UnaryOpImm<T>(BKT.Blocked128 k, OpIdentity id, MethodInfo src, byte imm8)
            where T : unmanaged
        {
            var reified = src.Reify(typeof(T));
            var operand = typeof(Block128<T>); 
            var generated = method(reified.Name, reified.DeclaringType, @return: operand, args: array(operand, operand));            
            var gen = generated.GetILGenerator();
            gen.Emit(OpCodes.Ldarg_0);
            gen.EmitImmLoad(imm8);
            gen.Emit(OpCodes.Ldarg_1);
            gen.EmitCall(OpCodes.Call, reified, null);
            gen.Emit(OpCodes.Ret);
            return generated.CreateDelegate<UnaryBlockedOp128<T>>(id.WithImm8(imm8), reified);
        }

        [MethodImpl(Inline)]
        public static UnaryOp<T> UnaryOp<T>(this ExecBufferToken buffer, in AsmCode<T> src)
            where T : unmanaged
                => buffer.Load(src).UnaryOp<T>(src.Id);

        [MethodImpl(Inline)]
        public static BinaryOp<T> BinaryOp<T>(this ExecBufferToken buffer, in AsmCode<T> src)
            where T : unmanaged
                => buffer.Load(src).BinaryOp<T>(src.Id);
        
        [MethodImpl(Inline)]
        public static FixedFunc<T,T> UnaryOp<T>(this ExecBufferToken buffer, in AsmCode src)
            where T : unmanaged, IFixed
                => buffer.F<T,T>(src);

        [MethodImpl(Inline)]
        public static FixedFunc<T,T,T> BinaryOp<T>(this ExecBufferToken buffer, in AsmCode src)
            where T : unmanaged, IFixed
                => buffer.Load(src).F<T,T,T>(src);

        /// <summary>
        /// Manufactures a fixed unary function with a native body
        /// </summary>
        /// <param name="id">The identity that will be conferred on the produced function</param>
        /// <param name="src">A pointer to executable memory loaded with the native function body</param>
        /// <typeparam name="X0">The first argument type</typeparam>
        /// <typeparam name="R">The return type</typeparam>
        [MethodImpl(Inline)]
        public static FixedFunc<X0,R> Func<X0,R>(this ExecBufferToken buffer, OpIdentity id )
            where X0 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => (FixedFunc<X0,R>)buffer.Handle.FixedFunc(id, typeof(FixedFunc<X0,R>), typeof(R), typeof(X0));

        [MethodImpl(Inline)]
        public static FixedFunc<X0,R> F<X0,R>(this ExecBufferToken buffer, in AsmCode src)
            where X0 : unmanaged, IFixed
            where R : unmanaged, IFixed             
                => buffer.Load(src).Func<X0,R>(src.Id);                                

        [MethodImpl(Inline)]
        public static FixedFunc<X0,X1,R> F<X0,X1,R>(this ExecBufferToken buffer, in AsmCode src)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => buffer.Load(src).Func<X0,X1,R>(src.Id);

        /// <summary>
        /// Manufactures a fixed binary function with a native body
        /// </summary>
        /// <param name="id">The identity that will be conferred on the produced function</param>
        /// <param name="src">A pointer to executable memory loaded with the native function body</param>
        /// <typeparam name="X0">The first argument type</typeparam>
        /// <typeparam name="X1">The second argument type</typeparam>
        /// <typeparam name="R">The return type</typeparam>
        [MethodImpl(Inline)]
        public static FixedFunc<X0,X1,R> Func<X0,X1,R>(this ExecBufferToken buffer, OpIdentity id)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => (FixedFunc<X0,X1,R>)buffer.Handle.FixedFunc(id, typeof(FixedFunc<X0,X1,R>), typeof(R), typeof(X0), typeof(X1));
        
        /// <summary>
        /// Manufactures a fixed ternary function with a native body
        /// </summary>
        /// <param name="id">The identity that will be conferred on the produced function</param>
        /// <param name="src">A pointer to executable memory loaded with the native function body</param>
        /// <typeparam name="X0">The first argument type</typeparam>
        /// <typeparam name="X1">The second argument type</typeparam>
        /// <typeparam name="X2">The third argument type</typeparam>
        /// <typeparam name="R">The return type</typeparam>
        [MethodImpl(Inline)]
        public static FixedFunc<X0,X1,X2,R> Func<X0,X1,X2,R>(this ExecBufferToken buffer, OpIdentity id)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where X2 : unmanaged, IFixed
            where R : unmanaged, IFixed    
                => (FixedFunc<X0,X1,X2,R>)buffer.Handle.FixedFunc(id,  typeof(FixedFunc<X0,X1,X2,R>), typeof(R), typeof(X0), typeof(X1), typeof(X2));

        /// <summary>
        /// Manufactures a fixed 4-argument function with a native body
        /// </summary>
        /// <param name="id">The identity that will be conferred on the produced function</param>
        /// <param name="src">A pointer to executable memory loaded with the native function body</param>
        /// <typeparam name="X0">The first argument type</typeparam>
        /// <typeparam name="X1">The second argument type</typeparam>
        /// <typeparam name="X2">The third argument type</typeparam>
        /// <typeparam name="X3">The fourth argument type</typeparam>
        /// <typeparam name="R">The return type</typeparam>
        [MethodImpl(Inline)]
        public static FixedFunc<X0,X1,X2,X3,R> Func<X0,X1,X2,X3,R>(this ExecBufferToken buffer, OpIdentity id)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where X2 : unmanaged, IFixed
            where X3 : unmanaged, IFixed
            where R : unmanaged, IFixed    
                => (FixedFunc<X0,X1,X2,X3,R>)buffer.Handle.FixedFunc(id, typeof(FixedFunc<X0,X1,X2,X3,R>), typeof(R), typeof(X0), typeof(X1), typeof(X2), typeof(X3));

        /// <summary>
        /// Creates a unary operator over a primal type defined by supplied asm code
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryOp<T> UnaryOp<T>(this ExecBufferToken buffer, OpIdentity id)
            where T : unmanaged
                => (UnaryOp<T>)buffer.UnaryOp(id,typeof(UnaryOp<T>), typeof(T));

        /// <summary>
        /// Creates a binary operator over a primal type to execute specified asm code
        /// </summary>
        /// <param name="id">Identity conferred upon the manufactured operator</param>
        /// <param name="buffer">A pointer to executable memory loaded with selected code</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryOp<T> BinaryOp<T>(this ExecBufferToken buffer, OpIdentity id)
            where T : unmanaged
                => (BinaryOp<T>)buffer.BinaryOp(id,typeof(BinaryOp<T>), typeof(T));

        [MethodImpl(Inline)]
        public static UnaryOp128 UnaryOp<T>(Func<Vector128<T>,Vector128<T>> f, VKT.Vec128<T> k = default)
            where T : unmanaged
                => (Fixed128 a) =>f(a.ToVector<T>()).ToFixed();

        [MethodImpl(Inline)]
        public static UnaryOp256 UnaryOp<T>(Func<Vector256<T>,Vector256<T>> f, VKT.Vec256<T> k = default)
            where T : unmanaged
                => (Fixed256 a) =>f(a.ToVector<T>()).ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp128 BinaryOp<T>(Func<Vector128<T>,Vector128<T>,Vector128<T>> f, VKT.Vec128<T> k = default)
            where T : unmanaged
                => (Fixed128 a, Fixed128 b) =>f(a.ToVector<T>(),b.ToVector<T>()).ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp256 BinaryOp<T>(Func<Vector256<T>,Vector256<T>,Vector256<T>> f, VKT.Vec256<T> k = default)
            where T : unmanaged
                => (Fixed256 a, Fixed256 b) => f(a.ToVector<T>(),b.ToVector<T>()).ToFixed();

        [MethodImpl(Inline)]            
        public static DynamicDelegate<UnaryOp<Vector128<T>>> UnaryOpV128Imm<T>(MethodInfo src, byte imm)
            where T : unmanaged
                => UnaryOpProvider(VK.vk128<T>(), src.Identify(), src)(imm);

        [MethodImpl(Inline)]            
        public static DynamicDelegate<BinaryOp<Vector128<T>>> BinaryOpV128Imm<T>(MethodInfo src, byte imm)
            where T : unmanaged
                => BinaryOpProvider(VK.vk128<T>(), src.Identify(), src)(imm);

        [MethodImpl(Inline)]            
        public static DynamicDelegate<UnaryOp<Vector256<T>>> UnaryOpV256Imm<T>(MethodInfo src, byte imm)
            where T : unmanaged
                => UnaryOpProvider(VK.vk256<T>(), src.Identify(), src)(imm);

        [MethodImpl(Inline)]            
        public static DynamicDelegate<BinaryOp<Vector256<T>>> BinaryOpV256Imm<T>(MethodInfo src, byte imm)
            where T : unmanaged
                => BinaryOpProvider(VK.vk256<T>(), src.Identify(), src)(imm);

        [MethodImpl(Inline)]
        public static AsmCode<T> Typed<T>(this AsmCode src)
            where T : unmanaged
                => new AsmCode<T>(src);

        /// <summary>
        /// Returns a dynamic delegate's dynamic pointer
        /// </summary>
        /// <param name="src">The source delegate</param>
        [MethodImpl(Inline)]
        public static unsafe DynamicPointer GetDynamicPointer<D>(this DynamicDelegate<D> src)
            where D : Delegate
                => src.ToDynamicPtr();

        [MethodImpl(Inline)]
        public static CilFunctionBody CilFunc<D>(this DynamicDelegate<D> src)
            where D : Delegate
                => CilFunctionBody.From(src); 

        internal static Func<byte,DynamicDelegate<UnaryOp<Vector128<T>>>> UnaryOpProvider<T>(VKT.Vec128<T> k, OpIdentity id, MethodInfo src)
            where T : unmanaged
            => imm8 => Dynop.UnaryOpImm(k,id, src,imm8);

        internal static Func<byte,DynamicDelegate<UnaryOp<Vector256<T>>>> UnaryOpProvider<T>(VKT.Vec256<T> k, OpIdentity id, MethodInfo src)
            where T : unmanaged
                => imm8 => Dynop.UnaryOpImm(k, id, src,imm8);

        internal static Func<byte,DynamicDelegate<BinaryOp<Vector128<T>>>> BinaryOpProvider<T>(VKT.Vec128<T> k, OpIdentity id, MethodInfo src)
            where T : unmanaged
            => imm8 => Dynop.BinaryOpImm(k,id, src,imm8);

        internal static Func<byte,DynamicDelegate<BinaryOp<Vector256<T>>>> BinaryOpProvider<T>(VKT.Vec256<T> k, OpIdentity id, MethodInfo src)
            where T : unmanaged
                => imm8 => Dynop.BinaryOpImm(k, id, src,imm8);
    }
}
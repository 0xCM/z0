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

    public static class Dynop
    {
        public static FixedDelegate UnaryOp(OpIdentity id, IntPtr src,  Type operatorType, Type operandType)        
            => FixedFunc(id,src, functype: operatorType, result: operandType, args: operandType);

        public static FixedDelegate BinaryOp(OpIdentity id, IntPtr src,  Type operatorType, Type operandType)        
            => FixedFunc(id,src, functype:operatorType, result:operandType, args: array(operandType, operandType));

        public static FixedDelegate TernaryOp(OpIdentity id, IntPtr src,  Type operatorType, Type operandType)        
            => FixedFunc(id,src, functype:operatorType, result:operandType, args: array(operandType, operandType,operandType));

        /// <summary>
        /// Manufactures a fixed unary function with a native body
        /// </summary>
        /// <param name="id">The identity that will be conferred on the produced function</param>
        /// <param name="src">A pointer to executable memory loaded with the native function body</param>
        /// <typeparam name="X0">The first argument type</typeparam>
        /// <typeparam name="R">The return type</typeparam>
        [MethodImpl(Inline)]
        public static FixedFunc<X0,R> Func<X0,R>(OpIdentity id, IntPtr src)
            where X0 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => (FixedFunc<X0,R>)FixedFunc(id, src, typeof(FixedFunc<X0,R>), typeof(R), typeof(X0));

        /// <summary>
        /// Manufactures a fixed binary function with a native body
        /// </summary>
        /// <param name="id">The identity that will be conferred on the produced function</param>
        /// <param name="src">A pointer to executable memory loaded with the native function body</param>
        /// <typeparam name="X0">The first argument type</typeparam>
        /// <typeparam name="X1">The second argument type</typeparam>
        /// <typeparam name="R">The return type</typeparam>
        [MethodImpl(Inline)]
        public static FixedFunc<X0,X1,R> Func<X0,X1,R>(OpIdentity id, IntPtr src)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where R : unmanaged, IFixed
                => (FixedFunc<X0,X1,R>)FixedFunc(id, src, typeof(FixedFunc<X0,X1,R>), typeof(R), typeof(X0), typeof(X1));
        
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
        public static FixedFunc<X0,X1,X2,R> Func<X0,X1,X2,R>(OpIdentity id, IntPtr src)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where X2 : unmanaged, IFixed
            where R : unmanaged, IFixed    
                => (FixedFunc<X0,X1,X2,R>)FixedFunc(id, src, typeof(FixedFunc<X0,X1,X2,R>), typeof(R), typeof(X0), typeof(X1), typeof(X2));

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
        public static FixedFunc<X0,X1,X2,X3,R> Func<X0,X1,X2,X3,R>(OpIdentity id, IntPtr src)
            where X0 : unmanaged, IFixed
            where X1 : unmanaged, IFixed
            where X2 : unmanaged, IFixed
            where X3 : unmanaged, IFixed
            where R : unmanaged, IFixed    
                => (FixedFunc<X0,X1,X2,X3,R>)FixedFunc(id, src, typeof(FixedFunc<X0,X1,X2,X3,R>), typeof(R), typeof(X0), typeof(X1), typeof(X2), typeof(X3));

        /// <summary>
        /// Creates a unary operator over a primal type defined by supplied asm code
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryOp<T> UnaryOp<T>(OpIdentity m, IntPtr address)
            where T : unmanaged
                => (UnaryOp<T>)UnaryOp(m,address,typeof(UnaryOp<T>), typeof(T));

        /// <summary>
        /// Creates a binary operator over a primal type to execute specified asm code
        /// </summary>
        /// <param name="id">Identity conferred upon the manufactured operator</param>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryOp<T> BinOp<T>(OpIdentity id, IntPtr address)
            where T : unmanaged
                => (BinaryOp<T>)BinaryOp(id,address, typeof(BinaryOp<T>), typeof(T));

        [MethodImpl(Inline)]
        public static UnaryOp128 UnaryOp<T>(Func<Vector128<T>,Vector128<T>> f, HK.Vec128<T> k = default)
            where T : unmanaged
                => (Fixed128 a) =>f(a.ToVector<T>()).ToFixed();

        [MethodImpl(Inline)]
        public static UnaryOp256 UnaryOp<T>(Func<Vector256<T>,Vector256<T>> f, HK.Vec256<T> k = default)
            where T : unmanaged
                => (Fixed256 a) =>f(a.ToVector<T>()).ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp128 BinOp<T>(Func<Vector128<T>,Vector128<T>,Vector128<T>> f, HK.Vec128<T> k = default)
            where T : unmanaged
                => (Fixed128 a, Fixed128 b) =>f(a.ToVector<T>(),b.ToVector<T>()).ToFixed();

        [MethodImpl(Inline)]
        public static BinaryOp256 BinOp<T>(Func<Vector256<T>,Vector256<T>,Vector256<T>> f, HK.Vec256<T> k = default)
            where T : unmanaged
                => (Fixed256 a, Fixed256 b) =>f(a.ToVector<T>(),b.ToVector<T>()).ToFixed();              

        /// <summary>
        /// Creates a 8-bit unary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp8 UnaryOp(N8 w, OpIdentity m, IntPtr address)
            => (UnaryOp8)UnaryOp(m, address, typeof(UnaryOp8), typeof(Fixed8));

        /// <summary>
        /// Creates a 16-bit unary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp16 UnaryOp(N16 w, OpIdentity m, IntPtr address)
            => (UnaryOp16)UnaryOp(m, address, typeof(UnaryOp16), typeof(Fixed16));

        /// <summary>
        /// Creates a 32-bit unary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp32 UnaryOp(N32 w, OpIdentity m, IntPtr address)
            => (UnaryOp32)UnaryOp(m, address, typeof(UnaryOp32), typeof(Fixed32));

        /// <summary>
        /// Creates a 64-bit unary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp64 UnaryOp(N64 w, OpIdentity m, IntPtr address)
            => (UnaryOp64)UnaryOp(m, address, typeof(UnaryOp64), typeof(Fixed64));

        /// <summary>
        /// Creates a 128-bit unary operator defined by supplied asm code
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp128 UnaryOp(N128 w, OpIdentity m, IntPtr address)
            => (UnaryOp128)UnaryOp(m, address, typeof(UnaryOp128), typeof(Fixed128));

        /// <summary>
        /// Creates a 256-bit unary operator defined by supplied asm code
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static UnaryOp256 UnaryOp(N256 w, OpIdentity m, IntPtr address)
            => (UnaryOp256)UnaryOp(m, address, typeof(UnaryOp256), typeof(Fixed256));

        /// <summary>
        /// Creates a 8-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp8 BinOp(N8 w,OpIdentity m, IntPtr address)
            => (BinaryOp8)BinaryOp(m,address, typeof(BinaryOp8), typeof(Fixed8));

        /// <summary>
        /// Creates a 32-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp16 BinOp(N16 w, OpIdentity id, IntPtr address)
            => (BinaryOp16)BinaryOp(id,address, typeof(BinaryOp16), typeof(Fixed16));

        /// <summary>
        /// Creates a 32-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp32 BinOp(N32 w, OpIdentity id, IntPtr address)
            => (BinaryOp32)BinaryOp(id,address, typeof(BinaryOp32), typeof(Fixed32));

        /// <summary>
        /// Creates a 64-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp64 BinOp(N64 w, OpIdentity id, IntPtr address)
            => (BinaryOp64)BinaryOp(id,address, typeof(BinaryOp64), typeof(Fixed64));

        /// <summary>
        /// Creates a 128-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp128 BinOp(N128 w, OpIdentity id, IntPtr address)
            => (BinaryOp128)BinaryOp(id,address, typeof(BinaryOp128), typeof(Fixed128));

        /// <summary>
        /// Creates a 256-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="address">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        [MethodImpl(Inline)]
        public static BinaryOp256 BinOp(N256 w, OpIdentity id, IntPtr address)
            => (BinaryOp256)BinaryOp(id,address, typeof(BinaryOp256), typeof(Fixed256));

        static FixedDelegate FixedFunc(OpIdentity id, IntPtr src, Type functype, Type result, params Type[] args)
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
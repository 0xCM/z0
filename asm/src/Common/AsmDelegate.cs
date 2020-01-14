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
    
    [SuppressUnmanagedCodeSecurity]
    public static unsafe class AsmDelegate
    {
        /// <summary>
        /// Creates a unary operator over a primal type defined by supplied asm code
        /// </summary>
        /// <param name="pCode">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        public static UnaryOp<T> CreateUnaryOp<T>(IntPtr pCode, Moniker m)
            where T : unmanaged
                => (UnaryOp<T>)CreateUnaryOp(pCode, m, typeof(T), typeof(UnaryOp<T>));

        /// <summary>
        /// Creates a binary operator over a primal type to execute specified asm code
        /// </summary>
        /// <param name="pCode">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        public static BinaryOp<T> CreateBinOp<T>(IntPtr pCode, Moniker m)
            where T : unmanaged
                => (BinaryOp<T>)CreateBinOp(pCode, m, typeof(T), typeof(BinaryOp<T>));

        /// <summary>
        /// Creates a 128-bit unary operator defined by supplied asm code
        /// </summary>
        /// <param name="pCode">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        public static UnaryOp128 CreateUnaryOp128(IntPtr pCode, Moniker m)
            => (UnaryOp128)CreateBinOp(pCode, m, typeof(Fixed128), typeof(UnaryOp128));

        /// <summary>
        /// Creates a 256-bit unary operator defined by supplied asm code
        /// </summary>
        /// <param name="pCode">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        public static UnaryOp256 CreateUnaryOp256(IntPtr pCode, Moniker m)
            => (UnaryOp256)CreateBinOp(pCode, m, typeof(Fixed256), typeof(UnaryOp256));

        /// <summary>
        /// Creates a 8-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="pCode">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        public static BinaryOp8 CreateBinOp8(IntPtr pCode, Moniker m)
            => (BinaryOp8)CreateBinOp(pCode, m, typeof(Fixed8), typeof(BinaryOp8));

        /// <summary>
        /// Creates a 32-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="pCode">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        public static BinaryOp16 CreateBinOp16(IntPtr pCode, Moniker m)
            => (BinaryOp16)CreateBinOp(pCode, m, typeof(Fixed16), typeof(BinaryOp16));

        /// <summary>
        /// Creates a 32-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="pCode">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        public static BinaryOp32 CreateBinOp32(IntPtr pCode, Moniker m)
            => (BinaryOp32)CreateBinOp(pCode, m, typeof(Fixed32), typeof(BinaryOp32));

        /// <summary>
        /// Creates a 64-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="pCode">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        public static BinaryOp64 CreateBinOp64(IntPtr pCode, Moniker m)
            => (BinaryOp64)CreateBinOp(pCode, m, typeof(Fixed64), typeof(BinaryOp64));

        /// <summary>
        /// Creates a 128-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="pCode">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        public static BinaryOp128 CreateBinOp128(IntPtr pCode, Moniker m)
            => (BinaryOp128)CreateBinOp(pCode, m, typeof(Fixed128), typeof(BinaryOp128));

        /// <summary>
        /// Creates a 256-bit binary operator over a specified executable memory location
        /// </summary>
        /// <param name="pCode">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        public static BinaryOp256 CreateBinOp256(IntPtr pCode, Moniker m)
            => (BinaryOp256)CreateBinOp(pCode, m, typeof(Fixed256), typeof(BinaryOp256));

        static Delegate CreateUnaryOp(IntPtr pCode, Moniker m, Type operandType, Type operatorType)
        {
            var argTypes = new Type[]{operandType};
            var returnType = operandType;
            var method = new DynamicMethod(m, returnType, argTypes, operandType.Module);            
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldc_I8, (long)pCode);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, argTypes);
            g.Emit(OpCodes.Ret);
            return method.CreateDelegate(operatorType);
        }

        static Delegate CreateBinOp(IntPtr pCode, Moniker m, Type operandType, Type operatorType)
        {
            var argTypes = new Type[]{operandType,operandType};
            var returnType = operandType;
            var method = new DynamicMethod(m, returnType, argTypes, operandType.Module);            
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);
            g.Emit(OpCodes.Ldc_I8, (long)pCode);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, argTypes);
            g.Emit(OpCodes.Ret);
            return method.CreateDelegate(operatorType);
        }
    }
}
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
        public static UnaryOp<T> CreateUnaryOp<T>(long pCode, Moniker m)
            where T : unmanaged
                => (UnaryOp<T>)CreateUnaryOp(pCode, m, typeof(T), typeof(UnaryOp<T>));

        /// <summary>
        /// Creates a 128-bit unary operator defined by supplied asm code
        /// </summary>
        /// <param name="pCode">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        public static UnaryOp128 CreateUnaryOp128(long pCode, Moniker m)
            => (UnaryOp128)CreateBinOp(pCode, m, typeof(Fixed128), typeof(UnaryOp128));

        /// <summary>
        /// Creates a 256-bit unary operator defined by supplied asm code
        /// </summary>
        /// <param name="pCode">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        public static UnaryOp256 CreateUnaryOp256(long pCode, Moniker m)
            => (UnaryOp256)CreateBinOp(pCode, m, typeof(Fixed256), typeof(UnaryOp256));

        /// <summary>
        /// Creates a binary operator over a primal type to execute specified asm code
        /// </summary>
        /// <param name="pCode">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        public static BinaryOp<T> CreateBinOp<T>(long pCode, Moniker m)
            where T : unmanaged
                => (BinaryOp<T>)CreateBinOp(pCode,m,typeof(T), typeof(BinaryOp<T>));

        /// <summary>
        /// Creates a 128-bit binary operator defined by supplied asm code
        /// </summary>
        /// <param name="pCode">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        public static BinaryOp128 CreateBinOp128(long pCode, Moniker m)
            => (BinaryOp128)CreateBinOp(pCode, m, typeof(Fixed128), typeof(BinaryOp128));

        /// <summary>
        /// Creates a 256-bit binary operator defined by supplied asm code
        /// </summary>
        /// <param name="pCode">A pointer to executable memory loaded with selected code</param>
        /// <param name="name">Identity conferred to the manufactured operator</param>
        public static BinaryOp256 CreateBinOp256(long pCode, Moniker m)
            => (BinaryOp256)CreateBinOp(pCode, m, typeof(Fixed256), typeof(BinaryOp256));
 
        static Delegate CreateUnaryOp(long pCode, Moniker m, Type operandType, Type operatorType)
        {
            var argTypes = new Type[]{operandType};
            var returnType = operandType;
            var method = new DynamicMethod(m, returnType, argTypes, operandType.Module);            
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldc_I8, pCode);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, argTypes);
            g.Emit(OpCodes.Ret);
            return method.CreateDelegate(operatorType);
        }

        static Delegate CreateBinOp(long pCode, Moniker m, Type operandType, Type operatorType)
        {
            var argTypes = new Type[]{operandType,operandType};
            var returnType = operandType;
            var method = new DynamicMethod(m, returnType, argTypes, operandType.Module);            
            var g = method.GetILGenerator();
            g.Emit(OpCodes.Ldarg_0);
            g.Emit(OpCodes.Ldarg_1);
            g.Emit(OpCodes.Ldc_I8, pCode);
            g.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, argTypes);
            g.Emit(OpCodes.Ret);
            return method.CreateDelegate(operatorType);
        }
    }
}
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

    using C = OpClass;

    using static Core;

    partial class FixedDynamic
    {
        /// <summary>
        /// Creates a fixed 8-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp8 Emit(IBufferToken dst, C.BinaryOp op, W8 w, in ApiCode src)
            => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

        /// <summary>
        /// Creates a fixed 16-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp16 Emit(IBufferToken dst, C.BinaryOp op, W16 w, in ApiCode src)
            => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

        /// <summary>
        /// Creates a fixed 32-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp32 Emit(IBufferToken dst, C.BinaryOp op, W32 w, in ApiCode src)
            => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

        /// <summary>
        /// Creates a fixed 64-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp64 Emit(IBufferToken dst, C.BinaryOp op, W64 w, in ApiCode src)
            => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

        /// <summary>
        /// Creates a fixed 128-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp128 Emit(IBufferToken dst, C.BinaryOp op, W128 w, in ApiCode src)
            => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

        /// <summary>
        /// Creates a fixed 256-bit binary operator from caller-supplied x86 source code
        /// </summary>
        /// <param name="dst">The target buffer sequence</param>
        /// <param name="index">The index of the buffer to load</param>
        /// <param name="w">The width selector</param>
        /// <param name="src">The source code</param>
        [MethodImpl(Inline)]
        public static BinaryOp256 Emit(IBufferToken dst, C.BinaryOp op, W256 w, in ApiCode src)
            => Emit(dst.Load(src.BinaryCode), src.Id, op, w);

        [MethodImpl(Inline)]
        static BinaryOp8 Emit(IBufferToken buffer, OpIdentity id, C.BinaryOp op, W8 w)
            => (BinaryOp8)Emit(buffer, id, op, typeof(BinaryOp8), typeof(Fixed8));

        [MethodImpl(Inline)]
        static BinaryOp16 Emit(IBufferToken buffer, OpIdentity id, C.BinaryOp op, W16 w)
            => (BinaryOp16)Emit(buffer, id, op, typeof(BinaryOp16), typeof(Fixed16));

        [MethodImpl(Inline)]
        static BinaryOp32 Emit(IBufferToken buffer, OpIdentity id, C.BinaryOp op, W32 w)
            => (BinaryOp32)Emit(buffer, id, op, typeof(BinaryOp32), typeof(Fixed32));

        [MethodImpl(Inline)]
        static BinaryOp64 Emit(IBufferToken buffer, OpIdentity id, C.BinaryOp op, W64 w)
            => (BinaryOp64)Emit(buffer, id, op, typeof(BinaryOp64), typeof(Fixed64));

        [MethodImpl(Inline)]
        static BinaryOp128 Emit(IBufferToken buffer, OpIdentity id, C.BinaryOp op, N128 w)
            => (BinaryOp128)Emit(buffer, id, op, typeof(BinaryOp128), typeof(Fixed128));

        [MethodImpl(Inline)]
        static BinaryOp256 Emit(IBufferToken buffer, OpIdentity id, C.BinaryOp op, N256 w)
            => (BinaryOp256)Emit(buffer, id, op, typeof(BinaryOp256), typeof(Fixed256));

        [MethodImpl(Inline)]
        internal static FixedDelegate Emit(IBufferToken buffer, OpIdentity id, C.BinaryOp op, Type operatorType, Type operandType)        
            => Emit(buffer.Handle, id, functype:operatorType, result:operandType, args:array(operandType, operandType));

        internal static FixedDelegate Emit(IntPtr src, OpIdentity id, Type functype, Type result, params Type[] args)
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
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
    using System.Linq;

    using static Root;
    using static FKT;
    using static Nats;

    partial class Dynop
    {
        [MethodImpl(Inline)]
        static UnaryOp<T> EmitUnaryOp<T>(this IBufferToken buffer, OpIdentity id)
            where T : unmanaged
                => (UnaryOp<T>)buffer.EmitFixedUnaryOp(id,typeof(UnaryOp<T>), typeof(T));

        [MethodImpl(Inline)]
        static BinaryOp<T> EmitBinaryOp<T>(this IBufferToken buffer, OpIdentity id)
            where T : unmanaged
                => (BinaryOp<T>)buffer.EmitFixedBinaryOp(id,typeof(BinaryOp<T>), typeof(T));

        [MethodImpl(Inline)]
        static TernaryOp<T> EmitTernaryOp<T>(this IBufferToken buffer, OpIdentity id)
            where T : unmanaged
                => (TernaryOp<T>)buffer.EmitFixedTernaryOp(id,typeof(TernaryOp<T>), typeof(T));

        [MethodImpl(Inline)]
        static FixedDelegate EmitFixedUnaryOp(this IBufferToken buffer, OpIdentity id, Type operatorType, Type operandType)        
            => buffer.Handle.EmitFixed(id, functype: operatorType, result: operandType, args: operandType);

        [MethodImpl(Inline)]
        static FixedDelegate EmitFixedBinaryOp(this IBufferToken buffer, OpIdentity id, Type operatorType, Type operandType)        
            => buffer.Handle.EmitFixed(id,functype:operatorType, result:operandType, args: array(operandType, operandType));

        [MethodImpl(Inline)]
        static FixedDelegate EmitFixedTernaryOp(this IBufferToken buffer, OpIdentity id, Type operatorType, Type operandType)        
            => buffer.Handle.EmitFixed(id, functype:operatorType, result:operandType, args: array(operandType, operandType, operandType));

        [MethodImpl(Inline)]
        static UnaryOp8 EmitFixedUnaryOp(this IBufferToken buffer, N8 w, OpIdentity id)
            => (UnaryOp8)buffer.EmitFixedUnaryOp(id, typeof(UnaryOp8), typeof(Fixed8));

        [MethodImpl(Inline)]
        static UnaryOp16 EmitFixedUnaryOp(this IBufferToken buffer, N16 w, OpIdentity id)
            => (UnaryOp16)buffer.EmitFixedUnaryOp(id, typeof(UnaryOp16), typeof(Fixed16));

        [MethodImpl(Inline)]
        static UnaryOp32 EmitFixedUnaryOp(this IBufferToken buffer, N32 w, OpIdentity id)
            => (UnaryOp32)buffer.EmitFixedUnaryOp(id, typeof(UnaryOp32), typeof(Fixed32));

        [MethodImpl(Inline)]
        static UnaryOp64 EmitFixedUnaryOp(this IBufferToken buffer, N64 w, OpIdentity id)
            => (UnaryOp64)buffer.EmitFixedUnaryOp(id, typeof(UnaryOp64), typeof(Fixed64));

        [MethodImpl(Inline)]
        static UnaryOp128 EmitFixedUnaryOp(this IBufferToken buffer, N128 w, OpIdentity id)
            => (UnaryOp128)buffer.EmitFixedUnaryOp(id, typeof(UnaryOp128), typeof(Fixed128));

        [MethodImpl(Inline)]
        static UnaryOp256 EmitFixedUnaryOp(this IBufferToken buffer, N256 w, OpIdentity id)
            => (UnaryOp256)buffer.EmitFixedUnaryOp(id, typeof(UnaryOp256), typeof(Fixed256));

        [MethodImpl(Inline)]
        static BinaryOp8 EmitFixedBinaryOp(this IBufferToken buffer, N8 w,OpIdentity id)
            => (BinaryOp8)buffer.EmitFixedBinaryOp(id, typeof(BinaryOp8), typeof(Fixed8));

        [MethodImpl(Inline)]
        static BinaryOp16 EmitFixedBinaryOp(this IBufferToken buffer, N16 w, OpIdentity id)
            => (BinaryOp16)buffer.EmitFixedBinaryOp(id, typeof(BinaryOp16), typeof(Fixed16));

        [MethodImpl(Inline)]
        static BinaryOp32 EmitFixedBinaryOp(this IBufferToken buffer,N32 w, OpIdentity id)
            => (BinaryOp32)buffer.EmitFixedBinaryOp(id, typeof(BinaryOp32), typeof(Fixed32));

        [MethodImpl(Inline)]
        static BinaryOp64 EmitFixedBinaryOp(this IBufferToken buffer, N64 w, OpIdentity id)
            => (BinaryOp64)buffer.EmitFixedBinaryOp(id, typeof(BinaryOp64), typeof(Fixed64));

        [MethodImpl(Inline)]
        static BinaryOp128 EmitFixedBinaryOp(this IBufferToken buffer, N128 w, OpIdentity id)
            => (BinaryOp128)buffer.EmitFixedBinaryOp(id, typeof(BinaryOp128), typeof(Fixed128));

        [MethodImpl(Inline)]
        static BinaryOp256 EmitFixedBinaryOp(this IBufferToken buffer, N256 w, OpIdentity id)
            => (BinaryOp256)buffer.EmitFixedBinaryOp(id, typeof(BinaryOp256), typeof(Fixed256));

        static FixedDelegate EmitFixed(this IntPtr src, OpIdentity id, Type functype, Type result, params Type[] args)
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
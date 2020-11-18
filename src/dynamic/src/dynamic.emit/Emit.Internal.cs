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

    using static Konst;
    using static z;

    partial class Dynop
    {
        internal static DynamicMethod DynamicSignature(string name, Type owner, Type @return, params Type[] args)
            => new DynamicMethod(name: name,
                attributes: MethodAttributes.Public | MethodAttributes.Static,
                callingConvention: CallingConventions.Standard,
                returnType: @return,
                parameterTypes: args,
                owner: owner,
                skipVisibility: false);

        [MethodImpl(Inline)]
        internal static UnaryOp<T> EmitUnaryOp<T>(this IBufferToken dst, OpIdentity id)
            where T : unmanaged
                => (UnaryOp<T>)dst.EmitFixedUnaryOp(id,typeof(UnaryOp<T>), typeof(T));

        [MethodImpl(Inline)]
        internal static BinaryOp<T> EmitBinaryOp<T>(this IBufferToken dst, OpIdentity id)
            where T : unmanaged
                => (BinaryOp<T>)dst.EmitFixedBinaryOp(id,typeof(BinaryOp<T>), typeof(T));

        [MethodImpl(Inline)]
        internal static TernaryOp<T> EmitTernaryOp<T>(this IBufferToken dst, OpIdentity id)
            where T : unmanaged
                => (TernaryOp<T>)dst.EmitFixedTernaryOp(id,typeof(TernaryOp<T>), typeof(T));

        [MethodImpl(Inline)]
        internal static CellDelegate EmitFixedUnaryOp(this IBufferToken dst, OpIdentity id, Type operatorType, Type operandType)
            => dst.Handle.EmitFixed(id, functype: operatorType, result: operandType, args: operandType);

        [MethodImpl(Inline)]
        internal static CellDelegate EmitFixedBinaryOp(this IBufferToken dst, OpIdentity id, Type operatorType, Type operandType)
            => dst.Handle.EmitFixed(id,functype:operatorType, result:operandType, args: array(operandType, operandType));

        [MethodImpl(Inline)]
        internal static CellDelegate EmitFixedTernaryOp(this IBufferToken dst, OpIdentity id, Type operatorType, Type operandType)
            => dst.Handle.EmitFixed(id, functype:operatorType, result:operandType, args: array(operandType, operandType, operandType));

        [MethodImpl(Inline)]
        internal static BinaryOp8 EmitFixedBinaryOp(this IBufferToken buffer, N8 w,OpIdentity id)
            => (BinaryOp8)buffer.EmitFixedBinaryOp(id, typeof(BinaryOp8), typeof(Cell8));

        [MethodImpl(Inline)]
        internal static BinaryOp16 EmitFixedBinaryOp(this IBufferToken buffer, N16 w, OpIdentity id)
            => (BinaryOp16)buffer.EmitFixedBinaryOp(id, typeof(BinaryOp16), typeof(Cell16));

        [MethodImpl(Inline)]
        internal static BinaryOp32 EmitFixedBinaryOp(this IBufferToken buffer, N32 w, OpIdentity id)
            => (BinaryOp32)buffer.EmitFixedBinaryOp(id, typeof(BinaryOp32), typeof(Cell32));

        [MethodImpl(Inline)]
        internal static BinaryOp64 EmitFixedBinaryOp(this IBufferToken buffer, N64 w, OpIdentity id)
            => (BinaryOp64)buffer.EmitFixedBinaryOp(id, typeof(BinaryOp64), typeof(Cell64));

        [MethodImpl(Inline)]
        internal static BinaryOp128 EmitFixedBinaryOp(this IBufferToken buffer, N128 w, OpIdentity id)
            => (BinaryOp128)buffer.EmitFixedBinaryOp(id, typeof(BinaryOp128), typeof(Cell128));

        [MethodImpl(Inline)]
        internal static BinaryOp256 EmitFixedBinaryOp(this IBufferToken buffer, N256 w, OpIdentity id)
            => (BinaryOp256)buffer.EmitFixedBinaryOp(id, typeof(BinaryOp256), typeof(Cell256));

        internal static CellDelegate EmitFixed(this IntPtr src, OpIdentity id, Type functype, Type result, params Type[] args)
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
            return CellDelegates.define(id, src, method, method.CreateDelegate(functype));
        }
    }
}